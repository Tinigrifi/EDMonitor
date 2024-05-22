namespace EDMonitor.UserInterfaces
{
    partial class UCSystemRoute
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelStarSystem = new System.Windows.Forms.Label();
            this.PictureBoxStarClass = new System.Windows.Forms.PictureBox();
            this.PictureBoxCurrent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStarClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelStarSystem
            // 
            this.LabelStarSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelStarSystem.Location = new System.Drawing.Point(32, 0);
            this.LabelStarSystem.Name = "LabelStarSystem";
            this.LabelStarSystem.Size = new System.Drawing.Size(208, 16);
            this.LabelStarSystem.TabIndex = 2;
            this.LabelStarSystem.Text = "System";
            this.LabelStarSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureBoxStarClass
            // 
            this.PictureBoxStarClass.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBoxStarClass.Image = global::EDMonitor.Properties.Resources.bullet_green;
            this.PictureBoxStarClass.InitialImage = global::EDMonitor.Properties.Resources.bullet_green;
            this.PictureBoxStarClass.Location = new System.Drawing.Point(16, 0);
            this.PictureBoxStarClass.Name = "PictureBoxStarClass";
            this.PictureBoxStarClass.Size = new System.Drawing.Size(16, 16);
            this.PictureBoxStarClass.TabIndex = 1;
            this.PictureBoxStarClass.TabStop = false;
            // 
            // PictureBoxCurrent
            // 
            this.PictureBoxCurrent.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBoxCurrent.Image = global::EDMonitor.Properties.Resources.bullet_go;
            this.PictureBoxCurrent.InitialImage = global::EDMonitor.Properties.Resources.bullet_go;
            this.PictureBoxCurrent.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxCurrent.Name = "PictureBoxCurrent";
            this.PictureBoxCurrent.Size = new System.Drawing.Size(16, 16);
            this.PictureBoxCurrent.TabIndex = 0;
            this.PictureBoxCurrent.TabStop = false;
            // 
            // UCSystemRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelStarSystem);
            this.Controls.Add(this.PictureBoxStarClass);
            this.Controls.Add(this.PictureBoxCurrent);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCSystemRoute";
            this.Size = new System.Drawing.Size(240, 16);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStarClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCurrent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxCurrent;
        private System.Windows.Forms.PictureBox PictureBoxStarClass;
        private System.Windows.Forms.Label LabelStarSystem;
    }
}
