namespace SEPMetro
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroDiskTile = new MetroFramework.Controls.MetroTile();
            this.CPU = new MetroFramework.Controls.MetroTile();
            this.RAM = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTile2);
            this.metroPanel1.Controls.Add(this.metroDiskTile);
            this.metroPanel1.Controls.Add(this.CPU);
            this.metroPanel1.Controls.Add(this.RAM);
            this.metroPanel1.CustomBackground = false;
            this.metroPanel1.HorizontalScrollbar = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, -1);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(864, 565);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.VerticalScrollbar = false;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.CustomBackground = false;
            this.metroTile2.CustomForeColor = false;
            this.metroTile2.Location = new System.Drawing.Point(406, 238);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.PaintTileCount = true;
            this.metroTile2.Size = new System.Drawing.Size(444, 314);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.StyleManager = null;
            this.metroTile2.TabIndex = 5;
            this.metroTile2.Text = "NETWORK";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile2.TileCount = 0;
            // 
            // metroDiskTile
            // 
            this.metroDiskTile.ActiveControl = null;
            this.metroDiskTile.CustomBackground = false;
            this.metroDiskTile.CustomForeColor = false;
            this.metroDiskTile.Location = new System.Drawing.Point(12, 179);
            this.metroDiskTile.Name = "metroDiskTile";
            this.metroDiskTile.PaintTileCount = true;
            this.metroDiskTile.Size = new System.Drawing.Size(388, 373);
            this.metroDiskTile.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroDiskTile.StyleManager = null;
            this.metroDiskTile.TabIndex = 4;
            this.metroDiskTile.Text = "DISK";
            this.metroDiskTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroDiskTile.TileCount = 0;
            this.metroDiskTile.Click += new System.EventHandler(this.metroDiskTile_Click);
            // 
            // CPU
            // 
            this.CPU.ActiveControl = null;
            this.CPU.CustomBackground = false;
            this.CPU.CustomForeColor = false;
            this.CPU.Location = new System.Drawing.Point(406, 13);
            this.CPU.Name = "CPU";
            this.CPU.PaintTileCount = true;
            this.CPU.Size = new System.Drawing.Size(444, 219);
            this.CPU.Style = MetroFramework.MetroColorStyle.Red;
            this.CPU.StyleManager = null;
            this.CPU.TabIndex = 3;
            this.CPU.Text = "CPU";
            this.CPU.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CPU.TileCount = 0;
            this.CPU.Click += new System.EventHandler(this.CPU_Click);
            // 
            // RAM
            // 
            this.RAM.ActiveControl = null;
            this.RAM.CustomBackground = false;
            this.RAM.CustomForeColor = false;
            this.RAM.Location = new System.Drawing.Point(12, 13);
            this.RAM.Name = "RAM";
            this.RAM.PaintTileCount = true;
            this.RAM.Size = new System.Drawing.Size(388, 160);
            this.RAM.Style = MetroFramework.MetroColorStyle.Yellow;
            this.RAM.StyleManager = null;
            this.RAM.TabIndex = 2;
            this.RAM.Text = "RAM";
            this.RAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RAM.TileCount = 0;
            this.RAM.Click += new System.EventHandler(this.RAM_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.OwnerForm = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 563);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroDiskTile;
        private MetroFramework.Controls.MetroTile CPU;
        private MetroFramework.Controls.MetroTile RAM;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;


    }
}

