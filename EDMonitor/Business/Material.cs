namespace EDMonitor.Business
{
    public class Material
    {
        public string Name { get; set; }

        public long Count { get; set; }

        public override string ToString() => Count.ToString() + " " + Name;
    }
}