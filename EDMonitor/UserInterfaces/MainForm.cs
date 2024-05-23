using BrightIdeasSoftware;
using EDMonitor.Business;
using EDMonitor.DataClasses.LogEvents;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;

namespace EDMonitor.UserInterfaces
{
    public partial class MainForm : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private DirectoryInfo LogDirectory { get; set; }
        private FileInfo CurrentFile { get; set; }
        private FileSystemWatcher FileSystemWatcher { get; set; }
        private AutoResetEvent AutoResetEvent { get; set; }
        private List<LogEvent> JournalEventsTMP { get; set; } = new List<LogEvent>();
        private List<LogEvent> JournalEvents { get; set; } = new List<LogEvent>();
        private PrivateFontCollection FontsMono { get; set; } = new PrivateFontCollection();
        private PrivateFontCollection FontsLCD { get; set; } = new PrivateFontCollection();
        private Font FontMono { get; set; }
        private Font FontMonoBig { get; set; }
        private Font FontLCD { get; set; }
        private Font FontLCDBig { get; set; }
        private Font FontLCDBold { get; set; }
        private Font FontLCDBigBold { get; set; }
        private MaterialsItems Materials { get; set; } = new MaterialsItems();
        private int CargoSize { get; set; } = 0;
        private int UsedCargo { get; set; } = 0;
        private List<CargoItem> CargoItems { get; set; } = new List<CargoItem>();
        private long Credits { get; set; } = 0;
        private List<SolarSystem> Route { get; set; } = new List<SolarSystem>();
        private Color ColorBackground { get; set; }
        private Color ColorForeground { get; set; }

        public delegate void UpdateListBox(string text);

        public MainForm()
        {
            InitializeComponent();
            InitializeFont();
            LoadColorFromConfig();
            ChangeColors();
            InitializeOLV();
            DoubleBuffered = true;
            InitializeDirectory();
        }

        private void InitializeOLV()
        {
            OLVColumn colEventsHour = new OLVColumn
            {
                Text = "TIME",
                HeaderTextAlign = HorizontalAlignment.Center,
                TextAlign = HorizontalAlignment.Center,
                Sortable = false,
                Width = 70,
                AspectGetter = TimeEvent,
            };
            OLVEvents.Columns.Add(colEventsHour);
            OLVColumn colEventsDesc = new OLVColumn
            {
                Text = " EVENT",
                HeaderTextAlign = HorizontalAlignment.Left,
                TextAlign = HorizontalAlignment.Left,
                Sortable = false,
                Width = OLVEvents.Width - 20 - 100 - 2,
                AspectGetter = DescEvent,
            };
            OLVEvents.Columns.Add(colEventsDesc);
            OLVEvents.HeaderMaximumHeight = 15;
            OLVEvents.FullRowSelect = true;
            OLVColumn colTLVCargoName = new OLVColumn
            {
                Text = "NAME",
                AspectGetter = CargoNameGetter,
                Sortable = false,
                MinimumWidth = 230,
            };
            OLVCargo.Columns.Add(colTLVCargoName);
            OLVColumn colTLVCargoCount = new OLVColumn
            {
                Text = "QTY",
                AspectGetter = CargoCountGetter,
                HeaderTextAlign = HorizontalAlignment.Center,
                TextAlign = HorizontalAlignment.Right,
                Sortable = false,
                MinimumWidth = 16,
            };
            OLVCargo.Columns.Add(colTLVCargoCount);
            OLVCargo.HeaderMaximumHeight = 15;
            OLVCargo.Columns[0].Width = OLVCargo.Width - 20 - 2 - OLVCargo.Columns[1].Width;
            OLVCargo.FullRowSelect = true;

            OLVColumn colRefinedQuantity = new OLVColumn
            {
                Text = "TIME",
                HeaderTextAlign = HorizontalAlignment.Center,
                TextAlign = HorizontalAlignment.Center,
                Sortable = false,
                Width = 70,
                AspectGetter = TimeRefined,
            };
            OLVMiningRefined.Columns.Add(colRefinedQuantity);
            OLVColumn colRefinedName = new OLVColumn
            {
                Text = "MATERIAL",
                HeaderTextAlign = HorizontalAlignment.Left,
                TextAlign = HorizontalAlignment.Left,
                Sortable = false,
                Width = OLVMiningRefined.Width - 20 - 100 - 2,
                AspectGetter = NameRefined,
            };
            OLVMiningRefined.Columns.Add(colRefinedName);
            OLVMiningRefined.HeaderMaximumHeight = 15;
            OLVMiningRefined.Columns[1].Width = OLVMiningRefined.Width - 20 - 2 - OLVMiningRefined.Columns[0].Width;
            OLVMiningRefined.FullRowSelect = true;

            OLVColumn colMsgTime = new OLVColumn
            {
                Text = "TIME",
                HeaderTextAlign = HorizontalAlignment.Center,
                TextAlign = HorizontalAlignment.Center,
                Sortable = false,
                Width = 70,
                AspectGetter = TimeMessage,
            };
            OLVMessages.Columns.Add(colMsgTime);
            OLVColumn colMsgMsg = new OLVColumn
            {
                Text = "MESSAGE",
                HeaderTextAlign = HorizontalAlignment.Center,
                TextAlign = HorizontalAlignment.Left,
                Sortable = false,
                AspectGetter = TitleMessage,
            };
            OLVMessages.Columns.Add(colMsgMsg);
            OLVMessages.HeaderMaximumHeight = 15;
            OLVMessages.Columns[1].Width = OLVMessages.Width - 20 - 2 - OLVMessages.Columns[0].Width;
            OLVMessages.FullRowSelect = true;

            OLVColumn colWalletTime = new OLVColumn
            {
                Text = "TIME",
                HeaderTextAlign = HorizontalAlignment.Center,
                TextAlign = HorizontalAlignment.Center,
                Sortable = false,
                Width = 70,
                AspectGetter = TimeWallet,
            };
            OLVWallet.Columns.Add(colWalletTime);
            OLVColumn colWalletPrice = new OLVColumn
            {
                Text = "CREDITS",
                HeaderTextAlign = HorizontalAlignment.Center,
                TextAlign = HorizontalAlignment.Left,
                Sortable = false,
                AspectGetter = TitleWallet,
            };
            OLVWallet.Columns.Add(colWalletPrice);
            OLVWallet.HeaderMaximumHeight = 15;
            OLVWallet.Columns[1].Width = OLVWallet.Width - 20 - 2 - OLVWallet.Columns[0].Width;
            OLVWallet.FullRowSelect = true;

            TLVMaterials.CanExpandGetter = TLVCanExpandGetter;
            TLVMaterials.ChildrenGetter = TLVChildrenGetter;
            OLVColumn colTLVMatName = new OLVColumn
            {
                Text = "NAME",
                AspectGetter = MatNameGetter,
                Sortable = false,
                MinimumWidth = 230,
            };
            TLVMaterials.Columns.Add(colTLVMatName);
            OLVColumn colTLVMatCount = new OLVColumn
            {
                Text = "QTY",
                AspectGetter = MatCountGetter,
                TextAlign = HorizontalAlignment.Right,
                Sortable = false,
                MinimumWidth = 16,
            };
            TLVMaterials.Columns.Add(colTLVMatCount);
            TLVMaterials.HeaderMaximumHeight = 15;
            TLVMaterials.Columns[0].Width = TLVMaterials.Width - 20 - 2 - TLVMaterials.Columns[1].Width;
            TLVMaterials.SetObjects(Materials.Categories);
            TLVMaterials.FullRowSelect = true;
            ColorBackground = ColorBackground;
            ColorForeground = ColorForeground;
            ChangeColors();
        }

        private object TitleWallet(object rowObject) => rowObject is WalletItem walletItem
            ? walletItem.Price.ToString("n0", CultureInfo.InvariantCulture) + " CR" + ": " + walletItem.Description
            : (object)string.Empty;

        private object TimeWallet(object rowObject) => rowObject is WalletItem walletItem
            ? TimeZone.CurrentTimeZone.ToLocalTime(walletItem.Timestamp).ToString("HH:mm:ss")
            : (object)string.Empty;

        private object TitleMessage(object rowObject) => rowObject is Business.Message message
            ? message.From + ": " + message.Content
            : (object)string.Empty;

        private object TimeMessage(object rowObject) => rowObject is Business.Message message
            ? TimeZone.CurrentTimeZone.ToLocalTime(message.Timestamp).ToString("HH:mm:ss")
            : (object)string.Empty;

        private object TimeRefined(object rowObject) => rowObject is RefinedMaterial refinedMaterial
            ? TimeZone.CurrentTimeZone.ToLocalTime(refinedMaterial.Timestamp).ToString("HH:mm:ss")
            : (object)string.Empty;

        private object NameRefined(object rowObject) => rowObject is RefinedMaterial refinedMaterial ? refinedMaterial.Name : (object)string.Empty;

        private object CargoCountGetter(object rowObject) => rowObject is Business.CargoItem cargoItem
            ? cargoItem.Count.ToString()
            : (object)string.Empty;

        private object CargoNameGetter(object rowObject) => rowObject is Business.CargoItem cargoItem
            ? cargoItem.Name
            : (object)string.Empty;

        private object MatCountGetter(object rowObject) => rowObject is Business.Material material
            ? material.Count.ToString()
            : (object)string.Empty;

        private object MatNameGetter(object rowObject)
        {
            switch (rowObject)
            {
                case CategoryMaterials categoryMaterials:
                    return categoryMaterials.Name;

                case Material material:
                    return material.Name;

                default:
                    return string.Empty;
            }
        }

        private IEnumerable TLVChildrenGetter(object model)
        {
            switch (model)
            {
                case CategoryMaterials categoryMaterials:
                    return categoryMaterials.Materials;

                default:
                    return null;
            }
        }

        private bool TLVCanExpandGetter(object model)
        {
            switch (model)
            {
                case CategoryMaterials categoryMaterials:
                    return categoryMaterials.CanBeExpandable;

                default:
                    return false;
            }
        }

        private object DescEvent(object rowObject) => rowObject is LogEvent logEvent
            ? logEvent.ToString()
            : (object)string.Empty;

        private object TimeEvent(object rowObject) => rowObject is LogEvent logEvent
            ? TimeZone.CurrentTimeZone.ToLocalTime(logEvent.Timestamp).ToString("HH:mm:ss")
            : (object)string.Empty;

        private void InitializeFont()
        {
            byte[] fontData = Properties.Resources.PTMONO;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            FontsMono.AddMemoryFont(fontPtr, fontData.Length);
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            FontMono = new Font(FontsMono.Families[0], 8.0F, FontStyle.Regular);
            FontMonoBig = new Font(FontsMono.Families[0], 16.0F, FontStyle.Bold);

            byte[] fontDataTest = Properties.Resources.digital;
            IntPtr fontPtrTest = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontDataTest.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontDataTest, 0, fontPtrTest, fontDataTest.Length);
            uint dummyTest = 0;
            FontsLCD.AddMemoryFont(fontPtrTest, fontDataTest.Length);
            AddFontMemResourceEx(fontPtrTest, (uint)fontDataTest.Length, IntPtr.Zero, ref dummyTest);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtrTest);

            FontLCD = new Font(FontsMono.Families[0], 9.0F, FontStyle.Regular);
            FontLCDBig = new Font(FontsMono.Families[0], 14.0F, FontStyle.Regular);
            FontLCDBold = new Font(FontsMono.Families[0], 9.0F, FontStyle.Bold);
            FontLCDBigBold = new Font(FontsLCD.Families[0], 23.0F, FontStyle.Bold);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeCurrentFile();
            InitializeFontInControl();
        }

        private void InitializeDirectory()
        {
            LogDirectory = new DirectoryInfo($@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Saved Games\Frontier Developments\Elite Dangerous");
        }

        private void InitializeCurrentFile()
        {
            try
            {
                CurrentFile = LogDirectory.GetFiles("Journal*.log").OrderByDescending(f => f.LastWriteTime).First();
                BackgroundWorkerFile.RunWorkerAsync(CurrentFile);
            }
            catch { }
        }

        private void AppendTextInListBox(string text)
        {
            ProcessLog(text);
            JournalEventsTMP.ForEach(e =>
            {
                if (!string.IsNullOrEmpty(e.ToString()))
                {
                    OLVEvents.AddObject(e);
                    OLVEvents.EnsureModelVisible(e);
                    switch (e.EventType)
                    {
                        case "MaterialCollected":
                            AddMaterial(((MaterialCollected)e).Category, (string.IsNullOrEmpty(((MaterialCollected)e).NameLocalised) ? ((MaterialCollected)e).Name : ((MaterialCollected)e).NameLocalised), (long)((MaterialCollected)e).Count);
                            Materials.Sort();
                            TLVMaterials.SetObjects(Materials.Categories);
                            break;

                        case "Materials":
                            Materials.Categories.Clear();
                            ((Materials)e).Raw.ForEach(m =>
                            {
                                AddMaterial("Raw", m.Name, (long)m.Count);
                            });
                            ((Materials)e).Manufactured.ForEach(m =>
                            {
                                AddMaterial("Manufactured", string.IsNullOrEmpty(m.NameLocalised) ? m.Name : m.NameLocalised, (long)m.Count);
                            });
                            ((Materials)e).Encoded.ForEach(m =>
                            {
                                AddMaterial("Encoded", string.IsNullOrEmpty(m.NameLocalised) ? m.Name : m.NameLocalised, (long)m.Count);
                            });
                            Materials.Sort();
                            TLVMaterials.SetObjects(Materials.Categories);
                            break;

                        case "Cargo":
                        case "CargoTransfer":
                            LoadCargo();
                            break;

                        case "Loadout":
                            LoadCargoSize(e);
                            break;

                        case "Location":
                        case "StartJump":
                        case "Scan":
                            LoadCurrentSystem(e);
                            break;

                        case "LoadGame":
                            LoadCredits(e);
                            break;

                        case "Bounty":
                        case "CapShipBond":
                        case "CommunityGoalReward":
                        case "DatalinkVoucher":
                        case "FactionKillBond":
                        case "MarketSell":
                        case "MissionCompleted":
                        case "ModuleSell":
                        case "ModuleSellRemote":
                        case "MultiSellExplorationData":
                        case "RedeemVoucher":
                        case "SellExplorationData":
                        case "ShipyardSell":
                            GainCredits(e);
                            break;

                        case "BuyAmmo":
                        case "BuyDrones":
                        case "BuyExplorationData":
                        case "BuyTradeData":
                        case "FetchRemoteModule":
                        case "MarketBuy":
                        case "ModuleBuy":
                        case "PayFines":
                        case "RefuelAll":
                        case "Repair":
                        case "RepairAll":
                        case "Resurrect":
                        case "ShipyardBuy":
                        case "ShipyardTransfer":
                        case "SquadronCreated":
                            SpendCredits(e);
                            break;

                        case "Synthesis":
                            SpendMaterials(e);
                            break;

                        case "MaterialTrade":
                            ExchangeMaterials(e);
                            break;

                        case "NavRoute":
                        case "NavRouteClear":
                            TraceRoute();
                            break;

                        case "MiningRefined":
                            ShowRefinedMaterials(e);
                            break;

                        case "ReceiveText":
                            ShowMessage(e);
                            break;

                        case "ShipLocker":
                            LoadShipLocker();
                            break;
                    }
                }
            });
            JournalEventsTMP.Clear();
        }

        private void ShowMessage(LogEvent e)
        {
            if (e is ReceiveText receiveText)
            {
                Business.Message message = new Business.Message
                {
                    From = receiveText.FromProcessed,
                    Content = receiveText.MessageLocalised ?? receiveText.Message,
                    Timestamp = receiveText.Timestamp,
                };
                OLVMessages.AddObject(message);
                OLVMessages.EnsureModelVisible(message);
            }
        }

        private void ShowRefinedMaterials(LogEvent e)
        {
            if (e is MiningRefined miningRefined)
            {
                RefinedMaterial refinedMaterial = new RefinedMaterial
                {
                    Name = miningRefined.TypeLocalised ?? miningRefined.Type,
                    Timestamp = miningRefined.Timestamp,
                };
                OLVMiningRefined.AddObject(refinedMaterial);
                OLVMiningRefined.EnsureModelVisible(refinedMaterial);
            }
        }

        private void ExchangeMaterials(LogEvent e)
        {
            if (e is MaterialTrade MaterialTrade)
            {
                Materials.Categories.ForEach(c =>
                {
                    c.Materials.ForEach(m2 =>
                    {
                        if (m2.Name == (string.IsNullOrEmpty(MaterialTrade.Received.MaterialLocalised) ? MaterialTrade.Received.Material : MaterialTrade.Received.MaterialLocalised))
                        {
                            m2.Count -= (int)MaterialTrade.Paid.Quantity;
                        }
                    });
                });
                Materials.Categories.ForEach(c =>
                {
                    c.Materials.ForEach(m2 =>
                    {
                        if (m2.Name == MaterialTrade.Received.Material)
                        {
                            AddMaterial(MaterialTrade.Received.Category, (string.IsNullOrEmpty(MaterialTrade.Received.MaterialLocalised) ? MaterialTrade.Received.Material : MaterialTrade.Received.MaterialLocalised), (int)MaterialTrade.Received.Quantity);
                        }
                    });
                });
                Materials.Sort();
                TLVMaterials.SetObjects(Materials.Categories);
            }
        }

        private void SpendMaterials(LogEvent e)
        {
            if (e is Synthesis Synthesis)
            {
                Synthesis.Materials.ForEach(m =>
                {
                    Materials.Categories.ForEach(c =>
                    {
                        c.Materials.ForEach(m2 =>
                        {
                            if (m2.Name == m.Name)
                            {
                                m2.Count -= (int)m.Count;
                            }
                        });
                    });
                });
                Materials.Sort();
                TLVMaterials.SetObjects(Materials.Categories);
            }
        }

        private void LoadCredits(LogEvent e)
        {
            if (e is LoadGame LoadGame) { Credits = LoadGame.Credits ?? 0; }
            LabelCredits.Text = Credits.ToString("n0", CultureInfo.InvariantCulture) + " CR";
        }

        private void GainCredits(LogEvent e)
        {
            long gain = 0;
            string description = "";
            if (e is Bounty bounty) { gain = bounty.TotalReward ?? 0; description = "Bounty - " + bounty.Description; }
            if (e is CapShipBond capShipBond) { gain = capShipBond.Reward ?? 0; description = "Cap Ship Bond - " + capShipBond.Description; }
            if (e is CommunityGoalReward communityGoalReward) { gain = communityGoalReward.Reward ?? 0; description = "Community Goal Reward - " + communityGoalReward.Description; }
            if (e is DatalinkVoucher datalinkVoucher) { gain = datalinkVoucher.Reward ?? 0; description = "Datalink Voucher - " + datalinkVoucher.Description; }
            if (e is FactionKillBond factionKillBond) { gain = factionKillBond.Reward ?? 0; description = "Faction Kill Bond - " + factionKillBond.Description; }
            if (e is MarketSell marketSell) { gain = marketSell.TotalSale ?? 0; description = "Market Sell - " + marketSell.Description; }
            if (e is MissionCompleted missionCompleted)
            {
                if (missionCompleted.Reward.HasValue)
                {
                    gain = (long)missionCompleted.Reward;
                }
                else if (missionCompleted.Donated.HasValue)
                {
                    gain = -(long)missionCompleted.Donated;
                }
                description = "Mission Completed - " + missionCompleted.Description;
            }
            if (e is ModuleSell moduleSell) { gain = moduleSell.SellPrice ?? 0; description = "Module Sell - " + moduleSell.Description; }
            if (e is ModuleSellRemote moduleSellRemote) { gain = moduleSellRemote.SellPrice ?? 0; description = "Module Sell Remote - " + moduleSellRemote.Description; }
            if (e is MultiSellExplorationData multiSellExplorationData) { gain = multiSellExplorationData.TotalEarnings ?? 0; description = "Multi Sell Exploration Data - " + multiSellExplorationData.Description; }
            if (e is RedeemVoucher redeemVoucher) { gain = redeemVoucher.Amount ?? 0; description = "Redeem Voucher - " + redeemVoucher.Description; }
            if (e is SellExplorationData sellExplorationData) { gain = sellExplorationData.TotalEarnings ?? 0; description = "Sell Exploration Data - " + sellExplorationData.Description; }
            if (e is ShipyardSell shipyardSell) { gain = shipyardSell.ShipPrice ?? 0; description = "Shipyard Sell - " + shipyardSell.Description; }
            Credits += gain;
            WalletItem walletItem = new WalletItem
            {
                Timestamp = e.Timestamp,
                Price = gain,
                Description = description,
            };
            OLVWallet.AddObject(walletItem);
            OLVWallet.EnsureModelVisible(walletItem);
            LabelCredits.Text = Credits.ToString("n0", CultureInfo.InvariantCulture) + " CR";
        }

        private void SpendCredits(LogEvent e)
        {
            long lose = 0;
            string description = "";
            if (e is BuyAmmo buyAmmo) { lose = buyAmmo.Cost ?? 0; description = "Buy Ammo"; }
            if (e is BuyDrones buyDrones) { lose = buyDrones.TotalCost ?? 0; description = "Buy Drones - " + buyDrones.Description; }
            if (e is BuyExplorationData buyExplorationData) { lose = buyExplorationData.Cost ?? 0; description = "Buy Exploration Data - " + buyExplorationData.Description; }
            if (e is BuyTradeData buyTradeData) { lose = buyTradeData.Cost ?? 0; description = "Buy Trade Data - " + buyTradeData.Description; }
            if (e is FetchRemoteModule fetchRemoteModule) { lose = fetchRemoteModule.TransferCost ?? 0; description = "Fetch Remote Module - " + fetchRemoteModule.Description; }
            if (e is MarketBuy marketBuy) { lose = marketBuy.TotalCost ?? 0; description = "Market Buy - " + marketBuy.Description; }
            if (e is ModuleBuy moduleBuy) { lose = moduleBuy.BuyPrice ?? 0; Credits += moduleBuy.SellPrice ?? 0; description = "Module Buy - " + moduleBuy.Description; }
            if (e is PayFines payFines) { lose = payFines.Amount ?? 0; description = "Pay Fines - " + payFines.Description; }
            if (e is RefuelAll refuelAll) { lose = refuelAll.Cost ?? 0; description = "Refuel All"; }
            if (e is Repair repair) { lose = repair.Cost ?? 0; description = "Repair - " + repair.Description; }
            if (e is RepairAll repairAll) { lose = repairAll.Cost ?? 0; description = "Repair All"; }
            if (e is Resurrect resurrect) { lose = resurrect.Cost ?? 0; description = "Resurrect"; }
            if (e is ShipyardBuy shipyardBuy) { lose = shipyardBuy.ShipPrice ?? 0; description = "Shipyard Buy - " + shipyardBuy.Description; }
            if (e is ShipyardTransfer shipyardTransfer) { lose = shipyardTransfer.TransferPrice ?? 0; description = "Shipyard Transfer - " + shipyardTransfer.Description; }
            if (e is SquadronCreated) { lose = 10000000; description = "Squadron Created"; }
            Credits -= lose;
            WalletItem walletItem = new WalletItem
            {
                Timestamp = e.Timestamp,
                Price = -lose,
                Description = description,
            };
            OLVWallet.AddObject(walletItem);
            OLVWallet.EnsureModelVisible(walletItem);
            LabelCredits.Text = Credits.ToString("n0", CultureInfo.InvariantCulture) + " CR";
        }

        private void LoadCurrentSystem(DataClasses.LogEvents.LogEvent e)
        {
            string starClass = "";
            if (e is Location Location)
            {
                if (!string.IsNullOrEmpty(Location.StarSystem))
                {
                    LabelSystemName.Text = Location.StarSystem;
                    DrawRoute();
                }
            }
            if (e is StartJump StartJump)
            {
                if (!string.IsNullOrEmpty(StartJump.StarSystem))
                {
                    LabelSystemName.Text = StartJump.StarSystem;
                    DrawRoute();
                }
                if (!string.IsNullOrEmpty(StartJump.StarClass))
                {
                    starClass = StartJump.StarClass;
                }
            }
            if (e is Scan Scan)
            {
                if (!string.IsNullOrEmpty(Scan.StarType) && (Scan.DistanceFromArrivalLS == 0))
                {
                    starClass = Scan.StarType;
                }
            }
            if (!string.IsNullOrEmpty(starClass))
            {
                try
                {
                    PictureBoxStar.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(starClass);
                }
                catch
                {
                    PictureBoxStar.Image = Properties.Resources.unknown;
                }
            }
        }

        private void LoadCargoSize(LogEvent e)
        {
            CargoSize = 0;
            if (e is Loadout loadout)
            {
                loadout.Modules.ForEach(module =>
                {
                    if (module.Item.Contains("int_cargorack"))
                    {
                        switch (module.Item.ToLower())
                        {
                            case "int_cargorack_size1_class1":
                                CargoSize += 2;
                                break;

                            case "int_cargorack_size2_class1":
                                CargoSize += 4;
                                break;

                            case "int_cargorack_size3_class1":
                                CargoSize += 8;
                                break;

                            case "int_cargorack_size4_class1":
                                CargoSize += 16;
                                break;

                            case "int_cargorack_size5_class1":
                                CargoSize += 32;
                                break;

                            case "int_cargorack_size6_class1":
                                CargoSize += 64;
                                break;

                            case "int_cargorack_size7_class1":
                                CargoSize += 128;
                                break;

                            case "int_cargorack_size8_class1":
                                CargoSize += 256;
                                break;

                            case "int_cargorack_size9_class1":
                                CargoSize += 512;
                                break;
                        }
                    }
                });
            }
            LabelCargo.Text = "Cargo: " + UsedCargo + "/" + CargoSize.ToString() + " (" + (CargoSize - UsedCargo).ToString() + " left)";
        }

        private void TraceRoute()
        {
            Route.Clear();
            using (StreamReader r = new StreamReader(new FileStream($@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Saved Games\Frontier Developments\Elite Dangerous\NavRoute.json", FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
            {
                string json = r.ReadToEnd();
                dynamic navRoute = JsonConvert.DeserializeObject(json);
                foreach (dynamic item in navRoute.Route)
                {
                    Route.Add(new Business.SolarSystem { StarSystem = (string)item.StarSystem, StarClass = (string)item.StarClass });
                }
            }
            DrawRoute();
            foreach (Control control in FlowLayoutPanelRoute.Controls)
            {
                control.ForeColor = ColorForeground;
            }
        }

        private void DrawRoute()
        {
            FlowLayoutPanelRoute.Controls.Clear();
            int cpt = 0;
            if (Route.Count == 0)
            {
                GroupBoxRoute.Text = "Route:";
            }
            else
            {
                GroupBoxRoute.Text = "Route: " + (Route.Count - 1).ToString() + " jumps.";
            }
            var Route2 = Route.ToList();
            List<UCSystemRoute> listUC = new List<UCSystemRoute>();
            foreach (Business.SolarSystem system in Route)
            {
                UCSystemRoute ucSystem = new UCSystemRoute(cpt, system, LabelSystemName.Text)
                {
                    Font = FontLCD
                };
                cpt++;
                listUC.Add(ucSystem);
                if (Route2.Count > 17 && cpt > 9 && system.StarSystem == LabelSystemName.Text)
                {
                    for (int i = 0; i < Math.Min(cpt - 9, Route.Count - 18); i++)
                    {
                        listUC.RemoveAt(0);
                        Route2.RemoveAt(0);
                    }
                }
            }
            FlowLayoutPanelRoute.Controls.AddRange(listUC.ToArray());
            foreach (Control control in FlowLayoutPanelRoute.Controls)
            {
                control.ForeColor = ColorForeground;
            }
            PanelRoute.Invalidate();
        }

        private void LoadCargo()
        {
            UsedCargo = 0;
            CargoItems.Clear();
            using (StreamReader r = new StreamReader(new FileStream($@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Saved Games\Frontier Developments\Elite Dangerous\Cargo.json", FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
            {
                string json = r.ReadToEnd();
                dynamic cargoEvent = JsonConvert.DeserializeObject(json);
                foreach (dynamic item in cargoEvent.Inventory)
                {
                    UsedCargo += (int)item.Count;
                    CargoItems.Add(new Business.CargoItem { Name = string.IsNullOrEmpty((string)item.Name_Localised) ? (string)item.Name : (string)item.Name_Localised, Count = (int)item.Count });
                }
            }
            LabelCargo.Text = "Cargo: " + UsedCargo + "/" + CargoSize.ToString() + " (" + (CargoSize - UsedCargo).ToString() + " left)";
            OLVCargo.Items.Clear();
            CargoItems = CargoItems.OrderBy(i => i.Name).ToList();
            OLVCargo.AddObjects(CargoItems);
        }

        private void LoadShipLocker()
        {
            //using (StreamReader r = new StreamReader(new FileStream($@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Saved Games\Frontier Developments\Elite Dangerous\ShipLocker.json", FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
            //{
            //    string json = r.ReadToEnd();
            //    dynamic cargoEvent = JsonConvert.DeserializeObject(json);
            //    foreach (dynamic item in cargoEvent.Items)
            //    {
            //    }
            //    foreach (dynamic item in cargoEvent.Components)
            //    {
            //    }
            //    foreach (dynamic item in cargoEvent.Consumables)
            //    {
            //    }
            //    foreach (dynamic item in cargoEvent.Data)
            //    {
            //    }
            //}
        }

        private void AddMaterial(string category, string name, long count)
        {
            bool catFound = false;
            if (Materials.Categories.Count != 0)
            {
                Materials.Categories.ForEach(cat =>
                {
                    if (category == cat.Name)
                    {
                        catFound = true;
                    }
                });
            }
            if (!catFound)
            {
                Materials.Categories.Add(new Business.CategoryMaterials { Name = category });
            }
            Materials.Categories.ForEach(cat =>
            {
                if (category == cat.Name)
                {
                    bool matFound = false;
                    cat.Materials.ForEach(material =>
                    {
                        if (name == material.Name)
                        {
                            matFound = true;
                            material.Count += count;
                        }
                    });
                    if (!matFound)
                    {
                        cat.Materials.Add(new Business.Material { Name = name, Count = count });
                    }
                }
            });
        }

        private void ProcessLog(string text)
        {
            List<string> list = text.Split('\n').ToList();
            list.ForEach(x =>
            {
                if (!string.IsNullOrWhiteSpace(x))
                {
                    LogEvent logEvent = JsonConvert.DeserializeObject<LogEvent>(x);
                    switch (logEvent.EventType)
                    {
                        // Default - non managed events -- https://elite-journal.readthedocs.io/en/latest/
                        default: logEvent = JsonConvert.DeserializeObject<NeedSpecialization>(x); break;

                        // Startup
                        case "Cargo": logEvent = JsonConvert.DeserializeObject<Cargo>(x); break;
                        case "ClearSavedGame": logEvent = JsonConvert.DeserializeObject<ClearSavedGame>(x); break;
                        case "Commander": logEvent = JsonConvert.DeserializeObject<Commander>(x); break;
                        case "Loadout": logEvent = JsonConvert.DeserializeObject<Loadout>(x); break;
                        case "Materials": logEvent = JsonConvert.DeserializeObject<Materials>(x); break;
                        case "Missions": logEvent = JsonConvert.DeserializeObject<Missions>(x); break;
                        case "NewCommander": logEvent = JsonConvert.DeserializeObject<NewCommander>(x); break;
                        case "LoadGame": logEvent = JsonConvert.DeserializeObject<LoadGame>(x); break;
                        case "Passengers": logEvent = JsonConvert.DeserializeObject<Passengers>(x); break;
                        case "Powerplay": logEvent = JsonConvert.DeserializeObject<Powerplay>(x); break;
                        case "Progress": logEvent = JsonConvert.DeserializeObject<Progress>(x); break;
                        case "Rank": logEvent = JsonConvert.DeserializeObject<Rank>(x); break;
                        case "Reputation": logEvent = JsonConvert.DeserializeObject<Reputation>(x); break;
                        case "Statistics": logEvent = JsonConvert.DeserializeObject<Statistics>(x); break;

                        // Travel
                        case "ApproachBody": logEvent = JsonConvert.DeserializeObject<ApproachBody>(x); break;
                        case "Docked": logEvent = JsonConvert.DeserializeObject<Docked>(x); break;
                        case "DockingCancelled": logEvent = JsonConvert.DeserializeObject<DockingCancelled>(x); break;
                        case "DockingDenied": logEvent = JsonConvert.DeserializeObject<DockingDenied>(x); break;
                        case "DockingGranted": logEvent = JsonConvert.DeserializeObject<DockingGranted>(x); break;
                        case "DockingRequested": logEvent = JsonConvert.DeserializeObject<DockingRequested>(x); break;
                        case "DockingTimeout": logEvent = JsonConvert.DeserializeObject<DockingTimeout>(x); break;
                        case "FSDJump": logEvent = JsonConvert.DeserializeObject<FSDJump>(x); break;
                        case "FSDTarget": logEvent = JsonConvert.DeserializeObject<FSDTarget>(x); break;
                        case "LeaveBody": logEvent = JsonConvert.DeserializeObject<LeaveBody>(x); break;
                        case "Liftoff": logEvent = JsonConvert.DeserializeObject<Liftoff>(x); break;
                        case "Location": logEvent = JsonConvert.DeserializeObject<Location>(x); break;
                        case "StartJump": logEvent = JsonConvert.DeserializeObject<StartJump>(x); break;
                        case "SupercruiseEntry": logEvent = JsonConvert.DeserializeObject<SupercruiseEntry>(x); break;
                        case "SupercruiseExit": logEvent = JsonConvert.DeserializeObject<SupercruiseExit>(x); break;
                        case "Touchdown": logEvent = JsonConvert.DeserializeObject<Touchdown>(x); break;
                        case "Undocked": logEvent = JsonConvert.DeserializeObject<Undocked>(x); break;
                        case "NavRoute": logEvent = JsonConvert.DeserializeObject<NavRoute>(x); break;
                        case "NavRouteClear": logEvent = JsonConvert.DeserializeObject<NavRouteClear>(x); break;

                        // Combat
                        case "Bounty": logEvent = JsonConvert.DeserializeObject<Bounty>(x); break;
                        case "CapShipBond": logEvent = JsonConvert.DeserializeObject<CapShipBond>(x); break;
                        case "Died": logEvent = JsonConvert.DeserializeObject<Died>(x); break;
                        case "EscapeInterdiction": logEvent = JsonConvert.DeserializeObject<EscapeInterdiction>(x); break;
                        case "FactionKillBond": logEvent = JsonConvert.DeserializeObject<FactionKillBond>(x); break;
                        case "FighterDestroyed": logEvent = JsonConvert.DeserializeObject<FighterDestroyed>(x); break;
                        case "HeatDamage": logEvent = JsonConvert.DeserializeObject<HeatDamage>(x); break;
                        case "HeatWarning": logEvent = JsonConvert.DeserializeObject<HeatWarning>(x); break;
                        case "HullDamage": logEvent = JsonConvert.DeserializeObject<HullDamage>(x); break;
                        case "Interdicted": logEvent = JsonConvert.DeserializeObject<Interdicted>(x); break;
                        case "Interdiction": logEvent = JsonConvert.DeserializeObject<Interdiction>(x); break;
                        case "PVPKill": logEvent = JsonConvert.DeserializeObject<PVPKill>(x); break;
                        case "ShieldState": logEvent = JsonConvert.DeserializeObject<ShieldState>(x); break;
                        case "ShipTargeted": logEvent = JsonConvert.DeserializeObject<ShipTargeted>(x); break;
                        case "SRVDestroyed": logEvent = JsonConvert.DeserializeObject<SRVDestroyed>(x); break;
                        case "UnderAttack": logEvent = JsonConvert.DeserializeObject<UnderAttack>(x); break;

                        // Exploration
                        case "CodexEntry": logEvent = JsonConvert.DeserializeObject<CodexEntry>(x); break;
                        case "DiscoveryScan": logEvent = JsonConvert.DeserializeObject<DiscoveryScan>(x); break;
                        case "Scan": logEvent = JsonConvert.DeserializeObject<Scan>(x); break;
                        case "FSSAllBodiesFound": logEvent = JsonConvert.DeserializeObject<FSSAllBodiesFound>(x); break;
                        case "FSSBodySignals": logEvent = JsonConvert.DeserializeObject<FSSBodySignals>(x); break;
                        case "FSSDiscoveryScan": logEvent = JsonConvert.DeserializeObject<FSSDiscoveryScan>(x); break;
                        case "FSSSignalDiscovered": logEvent = JsonConvert.DeserializeObject<FSSSignalDiscovered>(x); break;
                        case "MaterialCollected": logEvent = JsonConvert.DeserializeObject<MaterialCollected>(x); break;
                        case "MaterialDiscarded": logEvent = JsonConvert.DeserializeObject<MaterialDiscarded>(x); break;
                        case "MaterialDiscovered": logEvent = JsonConvert.DeserializeObject<MaterialDiscovered>(x); break;
                        case "MultiSellExplorationData": logEvent = JsonConvert.DeserializeObject<MultiSellExplorationData>(x); break;
                        case "NavBeaconScan": logEvent = JsonConvert.DeserializeObject<NavBeaconScan>(x); break;
                        case "BuyExplorationData": logEvent = JsonConvert.DeserializeObject<BuyExplorationData>(x); break;
                        case "SAAScanComplete": logEvent = JsonConvert.DeserializeObject<SAAScanComplete>(x); break;
                        case "SAASignalsFound": logEvent = JsonConvert.DeserializeObject<SAASignalsFound>(x); break;
                        case "ScanBaryCentre": logEvent = JsonConvert.DeserializeObject<ScanBaryCentre>(x); break;
                        case "SellExplorationData": logEvent = JsonConvert.DeserializeObject<SellExplorationData>(x); break;
                        case "Screenshot": logEvent = JsonConvert.DeserializeObject<Screenshot>(x); break;

                        // Trade
                        case "AsteroidCracked": logEvent = JsonConvert.DeserializeObject<AsteroidCracked>(x); break;
                        case "BuyTradeData": logEvent = JsonConvert.DeserializeObject<BuyTradeData>(x); break;
                        case "CollectCargo": logEvent = JsonConvert.DeserializeObject<CollectCargo>(x); break;
                        case "EjectCargo": logEvent = JsonConvert.DeserializeObject<EjectCargo>(x); break;
                        case "MarketBuy": logEvent = JsonConvert.DeserializeObject<MarketBuy>(x); break;
                        case "MarketSell": logEvent = JsonConvert.DeserializeObject<MarketSell>(x); break;
                        case "MiningRefined": logEvent = JsonConvert.DeserializeObject<MiningRefined>(x); break;

                        // Station Services
                        case "BuyAmmo": logEvent = JsonConvert.DeserializeObject<BuyAmmo>(x); break;
                        case "BuyDrones": logEvent = JsonConvert.DeserializeObject<BuyDrones>(x); break;
                        case "CargoDepot": logEvent = JsonConvert.DeserializeObject<CargoDepot>(x); break;
                        case "CommunityGoal": logEvent = JsonConvert.DeserializeObject<CommunityGoal>(x); break;
                        case "CommunityGoalDiscard": logEvent = JsonConvert.DeserializeObject<CommunityGoalDiscard>(x); break;
                        case "CommunityGoalJoin": logEvent = JsonConvert.DeserializeObject<CommunityGoalJoin>(x); break;
                        case "CommunityGoalReward": logEvent = JsonConvert.DeserializeObject<CommunityGoalReward>(x); break;
                        //case "CrewAssign": logEvent = JsonConvert.DeserializeObject<CrewAssign>(x); break;
                        //case "CrewFire": logEvent = JsonConvert.DeserializeObject<CrewFire>(x); break;
                        //case "CrewHire": logEvent = JsonConvert.DeserializeObject<CrewHire>(x); break;
                        case "EngineerContribution": logEvent = JsonConvert.DeserializeObject<EngineerContribution>(x); break;
                        case "EngineerCraft": logEvent = JsonConvert.DeserializeObject<EngineerCraft>(x); break;
                        //case "EngineerLegacyConvert": logEvent = JsonConvert.DeserializeObject<EngineerLegacyConvert>(x); break;
                        case "EngineerProgress": logEvent = JsonConvert.DeserializeObject<EngineerProgress>(x); break;
                        case "FetchRemoteModule": logEvent = JsonConvert.DeserializeObject<FetchRemoteModule>(x); break;
                        case "Market": logEvent = JsonConvert.DeserializeObject<Market>(x); break;
                        //case "MassModuleStore": logEvent = JsonConvert.DeserializeObject<MassModuleStore>(x); break;
                        case "MaterialTrade": logEvent = JsonConvert.DeserializeObject<MaterialTrade>(x); break;
                        case "MissionAbandoned": logEvent = JsonConvert.DeserializeObject<MissionAbandoned>(x); break;
                        case "MissionAccepted": logEvent = JsonConvert.DeserializeObject<MissionAccepted>(x); break;
                        case "MissionCompleted": logEvent = JsonConvert.DeserializeObject<MissionCompleted>(x); break;
                        //case "MissionFailed": logEvent = JsonConvert.DeserializeObject<MissionFailed>(x); break;
                        case "MissionRedirected": logEvent = JsonConvert.DeserializeObject<MissionRedirected>(x); break;
                        case "ModuleBuy": logEvent = JsonConvert.DeserializeObject<ModuleBuy>(x); break;
                        case "ModuleRetrieve": logEvent = JsonConvert.DeserializeObject<ModuleRetrieve>(x); break;
                        case "ModuleSell": logEvent = JsonConvert.DeserializeObject<ModuleSell>(x); break;
                        case "ModuleSellRemote": logEvent = JsonConvert.DeserializeObject<ModuleSellRemote>(x); break;
                        case "ModuleStore": logEvent = JsonConvert.DeserializeObject<ModuleStore>(x); break;
                        case "ModuleSwap": logEvent = JsonConvert.DeserializeObject<ModuleSwap>(x); break;
                        case "Outfitting": logEvent = JsonConvert.DeserializeObject<Outfitting>(x); break;
                        //case "PayBounties": logEvent = JsonConvert.DeserializeObject<PayBounties>(x); break;
                        case "PayFines": logEvent = JsonConvert.DeserializeObject<PayFines>(x); break;
                        //case "PayLegacyFines": logEvent = JsonConvert.DeserializeObject<PayLegacyFines>(x); break;
                        case "RedeemVoucher": logEvent = JsonConvert.DeserializeObject<RedeemVoucher>(x); break;
                        case "RefuelAll": logEvent = JsonConvert.DeserializeObject<RefuelAll>(x); break;
                        //case "RefuelPartial": logEvent = JsonConvert.DeserializeObject<RefuelPartial>(x); break;
                        case "Repair": logEvent = JsonConvert.DeserializeObject<Repair>(x); break;
                        case "RepairAll": logEvent = JsonConvert.DeserializeObject<RepairAll>(x); break;
                        //case "RestockVehicle": logEvent = JsonConvert.DeserializeObject<RestockVehicle>(x); break;
                        //case "ScientificResearch": logEvent = JsonConvert.DeserializeObject<ScientificResearch>(x); break;
                        //case "SearchAndRescue": logEvent = JsonConvert.DeserializeObject<SearchAndRescue>(x); break;
                        //case "SellDrones": logEvent = JsonConvert.DeserializeObject<SellDrones>(x); break;
                        //case "SellShipOnRebuy": logEvent = JsonConvert.DeserializeObject<SellShipOnRebuy>(x); break;
                        case "SetUserShipName": logEvent = JsonConvert.DeserializeObject<SetUserShipName>(x); break;
                        case "Shipyard": logEvent = JsonConvert.DeserializeObject<Shipyard>(x); break;
                        case "ShipyardBuy": logEvent = JsonConvert.DeserializeObject<ShipyardBuy>(x); break;
                        case "ShipyardNew": logEvent = JsonConvert.DeserializeObject<ShipyardNew>(x); break;
                        case "ShipyardSell": logEvent = JsonConvert.DeserializeObject<ShipyardSell>(x); break;
                        case "ShipyardTransfer": logEvent = JsonConvert.DeserializeObject<ShipyardTransfer>(x); break;
                        case "ShipyardSwap": logEvent = JsonConvert.DeserializeObject<ShipyardSwap>(x); break;
                        case "StoredModules": logEvent = JsonConvert.DeserializeObject<StoredModules>(x); break;
                        case "StoredShips": logEvent = JsonConvert.DeserializeObject<StoredShips>(x); break;
                        case "TechnologyBroker": logEvent = JsonConvert.DeserializeObject<TechnologyBroker>(x); break;
                        //case "ClearImpound": logEvent = JsonConvert.DeserializeObject<ClearImpound>(x); break;

                        // Powerplay
                        //case "PowerplayCollect": logEvent = JsonConvert.DeserializeObject<PowerplayCollect>(x); break;
                        //case "PowerplayDefect": logEvent = JsonConvert.DeserializeObject<PowerplayDefect>(x); break;
                        //case "PowerplayDeliver": logEvent = JsonConvert.DeserializeObject<PowerplayDeliver>(x); break;
                        //case "PowerplayFastTrack": logEvent = JsonConvert.DeserializeObject<PowerplayFastTrack>(x); break;
                        //case "PowerplayJoin": logEvent = JsonConvert.DeserializeObject<PowerplayJoin>(x); break;
                        //case "PowerplayLeave": logEvent = JsonConvert.DeserializeObject<PowerplayLeave>(x); break;
                        //case "PowerplaySalary": logEvent = JsonConvert.DeserializeObject<PowerplaySalary>(x); break;
                        //case "PowerplayVote": logEvent = JsonConvert.DeserializeObject<PowerplayVote>(x); break;
                        //case "PowerplayVoucher": logEvent = JsonConvert.DeserializeObject<PowerplayVoucher>(x); break;

                        // Squadrons
                        case "AppliedToSquadron": logEvent = JsonConvert.DeserializeObject<AppliedToSquadron>(x); break;
                        //case "DisbandedSquadron": logEvent = JsonConvert.DeserializeObject<DisbandedSquadron>(x); break;
                        case "InvitedToSquadron": logEvent = JsonConvert.DeserializeObject<InvitedToSquadron>(x); break;
                        //case "JoinedSquadron": logEvent = JsonConvert.DeserializeObject<JoinedSquadron>(x); break;
                        //case "KickedFromSquadron": logEvent = JsonConvert.DeserializeObject<KickedFromSquadron>(x); break;
                        //case "LeftSquadron": logEvent = JsonConvert.DeserializeObject<LeftSquadron>(x); break;
                        //case "SharedBookmarkToSquadron": logEvent = JsonConvert.DeserializeObject<SharedBookmarkToSquadron>(x); break;
                        case "SquadronCreated": logEvent = JsonConvert.DeserializeObject<SquadronCreated>(x); break;
                        case "SquadronDemotion": logEvent = JsonConvert.DeserializeObject<SquadronDemotion>(x); break;
                        //case "SquadronPromotion": logEvent = JsonConvert.DeserializeObject<SquadronPromotion>(x); break;
                        case "SquadronStartup": logEvent = JsonConvert.DeserializeObject<SquadronStartup>(x); break;
                        //case "WonATrophyForSquadron": logEvent = JsonConvert.DeserializeObject<WonATrophyForSquadron>(x); break;

                        // Fleet Carriers
                        //case "CarrierJump": logEvent = JsonConvert.DeserializeObject<CarrierJump>(x); break;
                        //case "CarrierBuy": logEvent = JsonConvert.DeserializeObject<CarrierBuy>(x); break;
                        //case "CarrierStats": logEvent = JsonConvert.DeserializeObject<CarrierStats>(x); break;
                        //case "CarrierJumpRequest": logEvent = JsonConvert.DeserializeObject<CarrierJumpRequest>(x); break;
                        //case "CarrierDecommission": logEvent = JsonConvert.DeserializeObject<CarrierDecommission>(x); break;
                        //case "CarrierCancelDecommission": logEvent = JsonConvert.DeserializeObject<CarrierCancelDecommission>(x); break;
                        //case "CarrierBankTransfer": logEvent = JsonConvert.DeserializeObject<CarrierBankTransfer>(x); break;
                        case "CarrierDepositFuel": logEvent = JsonConvert.DeserializeObject<CarrierDepositFuel>(x); break;
                        //case "CarrierCrewServices": logEvent = JsonConvert.DeserializeObject<CarrierCrewServices>(x); break;
                        //case "CarrierFinance": logEvent = JsonConvert.DeserializeObject<CarrierFinance>(x); break;
                        //case "CarrierShipPack": logEvent = JsonConvert.DeserializeObject<CarrierShipPack>(x); break;
                        //case "CarrierModulePack": logEvent = JsonConvert.DeserializeObject<CarrierModulePack>(x); break;
                        //case "CarrierTradeOrder": logEvent = JsonConvert.DeserializeObject<CarrierTradeOrder>(x); break;
                        //case "CarrierDockingPermission": logEvent = JsonConvert.DeserializeObject<CarrierDockingPermission>(x); break;
                        //case "CarrierNameChanged": logEvent = JsonConvert.DeserializeObject<CarrierNameChanged>(x); break;
                        //case "CarrierJumpCancelled": logEvent = JsonConvert.DeserializeObject<CarrierJumpCancelled>(x); break;

                        // New in Odyssey
                        //case "Backpack": logEvent = JsonConvert.DeserializeObject<Backpack>(x); break;
                        //case "BackpackChange": logEvent = JsonConvert.DeserializeObject<BackpackChange>(x); break;
                        //case "BookDropship": logEvent = JsonConvert.DeserializeObject<BookDropship>(x); break;
                        //case "BookTaxi": logEvent = JsonConvert.DeserializeObject<BookTaxi>(x); break;
                        //case "BuyMicroResources": logEvent = JsonConvert.DeserializeObject<BuyMicroResources>(x); break;
                        //case "BuySuit": logEvent = JsonConvert.DeserializeObject<BuySuit>(x); break;
                        //case "BuyWeapon": logEvent = JsonConvert.DeserializeObject<BuyWeapon>(x); break;
                        //case "CancelDropship": logEvent = JsonConvert.DeserializeObject<CancelDropship>(x); break;
                        //case "CancelTaxi": logEvent = JsonConvert.DeserializeObject<CancelTaxi>(x); break;
                        //case "CollectItems": logEvent = JsonConvert.DeserializeObject<CollectItems>(x); break;
                        //case "CreateSuitLoadout": logEvent = JsonConvert.DeserializeObject<CreateSuitLoadout>(x); break;
                        //case "DeleteSuitLoadout": logEvent = JsonConvert.DeserializeObject<DeleteSuitLoadout>(x); break;
                        //case "Disembark": logEvent = JsonConvert.DeserializeObject<Disembark>(x); break;
                        //case "DropItems": logEvent = JsonConvert.DeserializeObject<DropItems>(x); break;
                        //case "DropShipDeploy": logEvent = JsonConvert.DeserializeObject<DropShipDeploy>(x); break;
                        //case "Embark": logEvent = JsonConvert.DeserializeObject<Embark>(x); break;
                        //case "FCMaterials": logEvent = JsonConvert.DeserializeObject<FCMaterials>(x); break;
                        //case "LoadoutEquipModule": logEvent = JsonConvert.DeserializeObject<LoadoutEquipModule>(x); break;
                        //case "LoadoutRemoveModule": logEvent = JsonConvert.DeserializeObject<LoadoutRemoveModule>(x); break;
                        //case "RenameSuitLoadout": logEvent = JsonConvert.DeserializeObject<RenameSuitLoadout>(x); break;
                        //case "ScanOrganic": logEvent = JsonConvert.DeserializeObject<ScanOrganic>(x); break;
                        //case "SellMicroResources": logEvent = JsonConvert.DeserializeObject<SellMicroResources>(x); break;
                        //case "SellOrganicData": logEvent = JsonConvert.DeserializeObject<SellOrganicData>(x); break;
                        //case "SellSuit": logEvent = JsonConvert.DeserializeObject<SellSuit>(x); break;
                        //case "SellWeapon": logEvent = JsonConvert.DeserializeObject<SellWeapon>(x); break;
                        case "ShipLocker": logEvent = JsonConvert.DeserializeObject<ShipLocker>(x); break;
                        //case "SwitchSuitLoadout": logEvent = JsonConvert.DeserializeObject<SwitchSuitLoadout>(x); break;
                        //case "TransferMicroResources": logEvent = JsonConvert.DeserializeObject<TransferMicroResources>(x); break;
                        //case "TradeMicroResources": logEvent = JsonConvert.DeserializeObject<TradeMicroResources>(x); break;
                        //case "UpgradeSuit": logEvent = JsonConvert.DeserializeObject<UpgradeSuit>(x); break;
                        //case "UpgradeWeapon": logEvent = JsonConvert.DeserializeObject<UpgradeWeapon>(x); break;
                        //case "UseConsumable": logEvent = JsonConvert.DeserializeObject<UseConsumable>(x); break;

                        // Other Events
                        //case "AfmuRepairs": logEvent = JsonConvert.DeserializeObject<AfmuRepairs>(x); break;
                        case "ApproachSettlement": logEvent = JsonConvert.DeserializeObject<ApproachSettlement>(x); break;
                        //case "ChangeCrewRole": logEvent = JsonConvert.DeserializeObject<ChangeCrewRole>(x); break;
                        //case "CockpitBreached": logEvent = JsonConvert.DeserializeObject<CockpitBreached>(x); break;
                        case "CommitCrime": logEvent = JsonConvert.DeserializeObject<CommitCrime>(x); break;
                        //case "Continued": logEvent = JsonConvert.DeserializeObject<Continued>(x); break;
                        //case "CrewLaunchFighter": logEvent = JsonConvert.DeserializeObject<CrewLaunchFighter>(x); break;
                        //case "CrewMemberJoins": logEvent = JsonConvert.DeserializeObject<CrewMemberJoins>(x); break;
                        //case "CrewMemberQuits": logEvent = JsonConvert.DeserializeObject<CrewMemberQuits>(x); break;
                        //case "CrewMemberRoleChange": logEvent = JsonConvert.DeserializeObject<CrewMemberRoleChange>(x); break;
                        case "CrimeVictim": logEvent = JsonConvert.DeserializeObject<CrimeVictim>(x); break;
                        case "DatalinkScan": logEvent = JsonConvert.DeserializeObject<DatalinkScan>(x); break;
                        case "DatalinkVoucher": logEvent = JsonConvert.DeserializeObject<DatalinkVoucher>(x); break;
                        case "DataScanned": logEvent = JsonConvert.DeserializeObject<DataScanned>(x); break;
                        case "DockFighter": logEvent = JsonConvert.DeserializeObject<DockFighter>(x); break;
                        case "DockSRV": logEvent = JsonConvert.DeserializeObject<DockSRV>(x); break;
                        //case "EndCrewSession": logEvent = JsonConvert.DeserializeObject<EndCrewSession>(x); break;
                        //case "FighterRebuilt": logEvent = JsonConvert.DeserializeObject<FighterRebuilt>(x); break;
                        case "FuelScoop": logEvent = JsonConvert.DeserializeObject<FuelScoop>(x); break;
                        case "Friends": logEvent = JsonConvert.DeserializeObject<Friends>(x); break;
                        case "JetConeBoost": logEvent = JsonConvert.DeserializeObject<JetConeBoost>(x); break;
                        //case "JetConeDamage": logEvent = JsonConvert.DeserializeObject<JetConeDamage>(x); break;
                        //case "JoinACrew": logEvent = JsonConvert.DeserializeObject<JoinACrew>(x); break;
                        //case "KickCrewMember": logEvent = JsonConvert.DeserializeObject<KickCrewMember>(x); break;
                        case "LaunchDrone": logEvent = JsonConvert.DeserializeObject<LaunchDrone>(x); break;
                        case "LaunchFighter": logEvent = JsonConvert.DeserializeObject<LaunchFighter>(x); break;
                        case "LaunchSRV": logEvent = JsonConvert.DeserializeObject<LaunchSRV>(x); break;
                        case "ModuleInfo": logEvent = JsonConvert.DeserializeObject<ModuleInfo>(x); break;
                        case "Music": logEvent = JsonConvert.DeserializeObject<Music>(x); break;
                        //case "NpcCrewPaidWage": logEvent = JsonConvert.DeserializeObject<NpcCrewPaidWage>(x); break;
                        //case "NpcCrewRank": logEvent = JsonConvert.DeserializeObject<NpcCrewRank>(x); break;
                        case "Promotion": logEvent = JsonConvert.DeserializeObject<Promotion>(x); break;
                        case "ProspectedAsteroid": logEvent = JsonConvert.DeserializeObject<ProspectedAsteroid>(x); break;
                        //case "QuitACrew": logEvent = JsonConvert.DeserializeObject<QuitACrew>(x); break;
                        //case "RebootRepair": logEvent = JsonConvert.DeserializeObject<RebootRepair>(x); break;
                        case "ReceiveText": logEvent = JsonConvert.DeserializeObject<ReceiveText>(x); break;
                        //case "RepairDrone": logEvent = JsonConvert.DeserializeObject<RepairDrone>(x); break;
                        case "ReservoirReplenished": logEvent = JsonConvert.DeserializeObject<ReservoirReplenished>(x); break;
                        case "Resurrect": logEvent = JsonConvert.DeserializeObject<Resurrect>(x); break;
                        case "Scanned": logEvent = JsonConvert.DeserializeObject<Scanned>(x); break;
                        //case "SelfDestruct": logEvent = JsonConvert.DeserializeObject<SelfDestruct>(x); break;
                        case "SendText": logEvent = JsonConvert.DeserializeObject<SendText>(x); break;
                        case "Shutdown": logEvent = JsonConvert.DeserializeObject<Shutdown>(x); break;
                        case "Synthesis": logEvent = JsonConvert.DeserializeObject<Synthesis>(x); break;
                        //case "SystemsShutdown": logEvent = JsonConvert.DeserializeObject<SystemsShutdown>(x); break;
                        case "USSDrop": logEvent = JsonConvert.DeserializeObject<USSDrop>(x); break;
                        case "VehicleSwitch": logEvent = JsonConvert.DeserializeObject<VehicleSwitch>(x); break;
                        case "WingAdd": logEvent = JsonConvert.DeserializeObject<WingAdd>(x); break;
                        case "WingInvite": logEvent = JsonConvert.DeserializeObject<WingInvite>(x); break;
                        case "WingJoin": logEvent = JsonConvert.DeserializeObject<WingJoin>(x); break;
                        case "WingLeave": logEvent = JsonConvert.DeserializeObject<WingLeave>(x); break;
                        case "CargoTransfer": logEvent = JsonConvert.DeserializeObject<CargoTransfer>(x); break;
                        case "SupercruiseDestinationDrop": logEvent = JsonConvert.DeserializeObject<SupercruiseDestinationDrop>(x); break;

                        // File Header
                        case "Fileheader": logEvent = JsonConvert.DeserializeObject<Fileheader>(x); break;
                    }
                    //if (logEvent is NeedSpecialization)
                    //{
                    //    ToSpeech(logEvent);
                    //}
                    JournalEventsTMP.Add(logEvent);
                }
            });
        }

        public void ToSpeech(LogEvent logEvent)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.SpeakAsync("WARNING ! " + logEvent.EventType + " event needs to be specialized.");
        }

        private void BackgroundWorkerFile_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            FileInfo fileInfo = (FileInfo)e.Argument;
            long offset = 0;
            FileStream file = new FileStream(CurrentFile.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            while (true)
            {
                file.Seek(offset, SeekOrigin.Begin);
                StreamReader reader = new StreamReader(file);
                if (!reader.EndOfStream)
                {
                    while (!reader.EndOfStream)
                    {
                        string buffer = reader.ReadLine();
                        OLVEvents.BeginInvoke(new UpdateListBox(AppendTextInListBox), buffer);
                        Thread.Sleep(20);
                    }
                    offset = file.Position;
                }
            }
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorBackground = Color.FromArgb(0x40, 0x40, 0x40);
            ColorForeground = Color.LightGreen;
            SaveColorInConfig(ColorBackground, ColorForeground);
            ChangeColors();
        }

        private void OrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorBackground = Color.FromArgb(0x40, 0x40, 0x40);
            ColorForeground = Color.Orange;
            SaveColorInConfig(ColorBackground, ColorForeground);
            ChangeColors();
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorBackground = Color.FromArgb(0x30, 0x30, 0x30);
            ColorForeground = Color.FromArgb(0x05, 0x77, 0xd2);
            SaveColorInConfig(ColorBackground, ColorForeground);
            ChangeColors();
        }

        private void SaveColorInConfig(Color colorBackground, Color colorForeground)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            SaveSetting(configuration, "BackgroundR", colorBackground.R.ToString());
            SaveSetting(configuration, "BackgroundG", colorBackground.G.ToString());
            SaveSetting(configuration, "BackgroundB", colorBackground.B.ToString());
            SaveSetting(configuration, "ForegroundR", colorForeground.R.ToString());
            SaveSetting(configuration, "ForegroundG", colorForeground.G.ToString());
            SaveSetting(configuration, "ForegroundB", colorForeground.B.ToString());
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void LoadColorFromConfig()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            int backgroundR = LoadColorFromSetting(LoadSetting(configuration, "BackgroundR"), "BackgroundR");
            int backgroundG = LoadColorFromSetting(LoadSetting(configuration, "BackgroundG"), "BackgroundG");
            int backgroundB = LoadColorFromSetting(LoadSetting(configuration, "BackgroundB"), "BackgroundB");
            int foregroundR = LoadColorFromSetting(LoadSetting(configuration, "ForegroundR"), "ForegroundR");
            int foregroundG = LoadColorFromSetting(LoadSetting(configuration, "ForegroundG"), "ForegroundG");
            int foregroundB = LoadColorFromSetting(LoadSetting(configuration, "ForegroundB"), "ForegroundB");
            ColorBackground = Color.FromArgb(backgroundR, backgroundG, backgroundB);
            ColorForeground = Color.FromArgb(foregroundR, foregroundG, foregroundB);
            SaveSetting(configuration, "BackgroundR", ColorBackground.R.ToString());
            SaveSetting(configuration, "BackgroundG", ColorBackground.G.ToString());
            SaveSetting(configuration, "BackgroundB", ColorBackground.B.ToString());
            SaveSetting(configuration, "ForegroundR", ColorForeground.R.ToString());
            SaveSetting(configuration, "ForegroundG", ColorForeground.G.ToString());
            SaveSetting(configuration, "ForegroundB", ColorForeground.B.ToString());
            configuration.Save();
            ChangeColors();
        }

        private int LoadColorFromSetting(string value, string setting)
        {
            if (value != null)
            {
                return int.Parse(value);
            }
            else
            {
                switch (setting)
                {
                    case "BackgroundR":
                        return 48;

                    case "BackgroundG":
                        return 48;

                    case "BackgroundB":
                        return 48;

                    case "ForegroundR":
                        return 5;

                    case "ForegroundG":
                        return 119;

                    case "ForegroundB":
                        return 210;

                    default:
                        return 0;
                }
            }
        }

        private void SaveSetting(Configuration configuration, string setting, string value)
        {
            if (configuration.AppSettings.Settings[setting] != null)
            {
                configuration.AppSettings.Settings[setting].Value = value;
            }
            else
            {
                configuration.AppSettings.Settings.Add(setting, value);
            }
        }

        private string LoadSetting(Configuration configuration, string setting)
        {
            if (configuration.AppSettings.Settings[setting] != null)
            {
                return configuration.AppSettings.Settings[setting].Value;
            }
            else
            {
                return null;
            }
        }

        private void InitializeFontInControl()
        {
            OLVEvents.Font = FontLCD;
            OLVEvents.Columns[0].Width = 70;
            OLVEvents.Columns[1].Width = OLVEvents.Width - 20 - OLVEvents.Columns[0].Width - 2;
            TLVMaterials.Font = FontLCD;
            LabelCargo.Font = FontLCD;
            OLVCargo.Font = FontLCD;
            OLVMiningRefined.Font = FontLCD;
            LabelHistory.Font = FontLCD;
            LabelHistory.Text = "History:";
            LabelMaterials.Font = FontLCD;
            LabelMaterials.Text = "Materials:";
            LabelSystem.Font = FontLCD;
            LabelSystem.Text = "System:";
            GroupBoxRoute.Font = FontLCD;
            GroupBoxRoute.Text = "Route:";
            LabelMiningRefined.Font = FontLCD;
            LabelMiningRefined.Text = "Mining Refined:";
            LabelSystemName.Font = FontLCDBig;
            LabelSystemName.Text = "Unknown";
            PictureBoxStar.Image = Properties.Resources.unknown;
            LabelCurrentWealth.Font = FontLCDBig;
            LabelCurrentWealth.Text = "Current Wealth:";
            LabelCredits.Font = FontLCDBigBold;
            LabelMessages.Font = FontLCD;
            LabelMessages.Text = "Messages:";
            LabelWallet.Font = FontLCD;
            LabelWallet.Text = "Wallet:";
            OLVMessages.Font = FontLCD;
            OLVWallet.Font = FontLCD;

            OLVMessages.HideSelection = true;
            OLVMiningRefined.HideSelection = true;
            OLVEvents.HideSelection = true;
            OLVCargo.HideSelection = true;
            OLVMessages.HideSelection = true;
            OLVWallet.HideSelection = true;
            TLVMaterials.HideSelection = true;
        }

        private void ChangeColors()
        {
            BackColor = ColorBackground;
            LabelCargo.ForeColor = ColorForeground;
            OLVEvents.SelectedBackColor = ColorForeground;
            OLVEvents.SelectedForeColor = ColorBackground;
            OLVEvents.BackColor = ColorBackground;
            OLVEvents.ForeColor = ColorForeground;
            foreach (OLVColumn item in OLVEvents.Columns)
            {
                var headerstyle = new HeaderFormatStyle();
                headerstyle.SetBackColor(ColorForeground);
                headerstyle.SetForeColor(ColorBackground);
                headerstyle.SetFont(FontLCD);
                item.HeaderFormatStyle = headerstyle;
            }
            for (int i = 0; i < OLVEvents.Items.Count; i++)
            {
                OLVEvents.Items[i].BackColor = ColorBackground;
                OLVEvents.Items[i].ForeColor = ColorForeground;
            }
            OLVEvents.Invalidate();
            TLVMaterials.ForeColor = ColorForeground;
            TLVMaterials.BackColor = ColorBackground;
            TLVMaterials.SelectedBackColor = ColorForeground;
            TLVMaterials.SelectedForeColor = ColorBackground;
            foreach (OLVColumn item in TLVMaterials.Columns)
            {
                var headerstyle = new HeaderFormatStyle();
                headerstyle.SetBackColor(ColorForeground);
                headerstyle.SetForeColor(ColorBackground);
                headerstyle.SetFont(FontLCD);
                item.HeaderFormatStyle = headerstyle;
            }
            for (int i = 0; i < TLVMaterials.Items.Count; i++)
            {
                TLVMaterials.Items[i].BackColor = ColorBackground;
                TLVMaterials.Items[i].ForeColor = ColorForeground;
            }
            TLVMaterials.Invalidate();
            OLVCargo.SelectedBackColor = ColorForeground;
            OLVCargo.SelectedForeColor = ColorBackground;
            OLVCargo.BackColor = ColorBackground;
            OLVCargo.ForeColor = ColorForeground;
            foreach (OLVColumn item in OLVCargo.Columns)
            {
                var headerstyle = new HeaderFormatStyle();
                headerstyle.SetBackColor(ColorForeground);
                headerstyle.SetForeColor(ColorBackground);
                headerstyle.SetFont(FontLCD);
                item.HeaderFormatStyle = headerstyle;
            }
            for (int i = 0; i < OLVCargo.Items.Count; i++)
            {
                OLVCargo.Items[i].BackColor = ColorBackground;
                OLVCargo.Items[i].ForeColor = ColorForeground;
            }
            OLVCargo.Invalidate();
            LabelHistory.ForeColor = ColorForeground;
            LabelMaterials.ForeColor = ColorForeground;
            LabelSystem.ForeColor = ColorForeground;
            GroupBoxRoute.ForeColor = ColorForeground;
            LabelMiningRefined.ForeColor = ColorForeground;
            LabelSystemName.ForeColor = ColorForeground;
            LabelCurrentWealth.ForeColor = ColorForeground;
            LabelCredits.ForeColor = ColorForeground;
            foreach (Control control in FlowLayoutPanelRoute.Controls)
            {
                control.ForeColor = ColorForeground;
            }
            OLVMiningRefined.SelectedBackColor = ColorForeground;
            OLVMiningRefined.SelectedForeColor = ColorBackground;
            OLVMiningRefined.BackColor = ColorBackground;
            OLVMiningRefined.ForeColor = ColorForeground;
            foreach (OLVColumn item in OLVMiningRefined.Columns)
            {
                var headerstyle = new HeaderFormatStyle();
                headerstyle.SetBackColor(ColorForeground);
                headerstyle.SetForeColor(ColorBackground);
                headerstyle.SetFont(FontLCD);
                item.HeaderFormatStyle = headerstyle;
            }
            for (int i = 0; i < OLVMiningRefined.Items.Count; i++)
            {
                OLVMiningRefined.Items[i].BackColor = ColorBackground;
                OLVMiningRefined.Items[i].ForeColor = ColorForeground;
            }
            OLVMiningRefined.Invalidate();
            LabelMessages.ForeColor = ColorForeground;
            LabelWallet.ForeColor = ColorForeground;
            OLVWallet.SelectedBackColor = ColorForeground;
            OLVWallet.SelectedForeColor = ColorBackground;
            OLVWallet.BackColor = ColorBackground;
            OLVWallet.ForeColor = ColorForeground;
            foreach (OLVColumn item in OLVWallet.Columns)
            {
                var headerstyle = new HeaderFormatStyle();
                headerstyle.SetBackColor(ColorForeground);
                headerstyle.SetForeColor(ColorBackground);
                headerstyle.SetFont(FontLCD);
                item.HeaderFormatStyle = headerstyle;
            }
            for (int i = 0; i < OLVWallet.Items.Count; i++)
            {
                OLVWallet.Items[i].BackColor = ColorBackground;
                OLVWallet.Items[i].ForeColor = ColorForeground;
            }
            OLVWallet.Invalidate();
            OLVWallet.Refresh();
            OLVMessages.SelectedBackColor = ColorForeground;
            OLVMessages.SelectedForeColor = ColorBackground;
            OLVMessages.BackColor = ColorBackground;
            OLVMessages.ForeColor = ColorForeground;
            foreach (OLVColumn item in OLVMessages.Columns)
            {
                var headerstyle = new HeaderFormatStyle();
                headerstyle.SetBackColor(ColorForeground);
                headerstyle.SetForeColor(ColorBackground);
                headerstyle.SetFont(FontLCD);
                item.HeaderFormatStyle = headerstyle;
            }
            for (int i = 0; i < OLVMessages.Items.Count; i++)
            {
                OLVMessages.Items[i].BackColor = ColorBackground;
                OLVMessages.Items[i].ForeColor = ColorForeground;
            }
            OLVMessages.Invalidate();
            OLVMessages.Refresh();
        }
    }
}