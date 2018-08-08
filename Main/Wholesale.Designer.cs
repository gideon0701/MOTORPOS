namespace PointOfSalesApp.Main
{
    partial class Wholesale
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wholesale));
            this.txtBoxUnitPriceWh = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxItemDescWh = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxProductIDWh = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxQtyUpdWh = new MetroFramework.Controls.MetroTextBox();
            this.lblWhlTotal = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxWhTotal = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxReceievedWh = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxChangeWh = new MetroFramework.Controls.MetroTextBox();
            this.tileCompute = new MetroFramework.Controls.MetroTile();
            this.btnCloseAddFormUpd = new System.Windows.Forms.Button();
            this.tileScan = new MetroFramework.Controls.MetroTile();
            this.tileTransactWh = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxUnitPriceWh
            // 
            this.txtBoxUnitPriceWh.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxUnitPriceWh.Location = new System.Drawing.Point(410, 180);
            this.txtBoxUnitPriceWh.Name = "txtBoxUnitPriceWh";
            this.txtBoxUnitPriceWh.Size = new System.Drawing.Size(252, 30);
            this.txtBoxUnitPriceWh.TabIndex = 3;
            this.txtBoxUnitPriceWh.Text = "Price per Unit";
            // 
            // txtBoxItemDescWh
            // 
            this.txtBoxItemDescWh.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxItemDescWh.Location = new System.Drawing.Point(410, 130);
            this.txtBoxItemDescWh.Name = "txtBoxItemDescWh";
            this.txtBoxItemDescWh.Size = new System.Drawing.Size(252, 30);
            this.txtBoxItemDescWh.TabIndex = 2;
            this.txtBoxItemDescWh.TabStop = false;
            this.txtBoxItemDescWh.Text = "Particular";
            // 
            // txtBoxProductIDWh
            // 
            this.txtBoxProductIDWh.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxProductIDWh.Location = new System.Drawing.Point(410, 80);
            this.txtBoxProductIDWh.Name = "txtBoxProductIDWh";
            this.txtBoxProductIDWh.Size = new System.Drawing.Size(252, 30);
            this.txtBoxProductIDWh.TabIndex = 1;
            this.txtBoxProductIDWh.TabStop = false;
            this.txtBoxProductIDWh.Text = "Product ID";
            // 
            // txtBoxQtyUpdWh
            // 
            this.txtBoxQtyUpdWh.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxQtyUpdWh.Location = new System.Drawing.Point(410, 231);
            this.txtBoxQtyUpdWh.Name = "txtBoxQtyUpdWh";
            this.txtBoxQtyUpdWh.Size = new System.Drawing.Size(252, 30);
            this.txtBoxQtyUpdWh.TabIndex = 4;
            this.txtBoxQtyUpdWh.Text = "Enter Quantity";
            // 
            // lblWhlTotal
            // 
            this.lblWhlTotal.AutoSize = true;
            this.lblWhlTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblWhlTotal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhlTotal.Location = new System.Drawing.Point(257, 294);
            this.lblWhlTotal.Name = "lblWhlTotal";
            this.lblWhlTotal.Size = new System.Drawing.Size(102, 37);
            this.lblWhlTotal.TabIndex = 14;
            this.lblWhlTotal.Text = "TOTAL";
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "dasboard 2.png");
            this.imgList.Images.SetKeyName(1, "cart2.png");
            this.imgList.Images.SetKeyName(2, "inventory.png");
            this.imgList.Images.SetKeyName(3, "Group 135.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(269, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Received";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(231, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "CHANGE";
            // 
            // txtBoxWhTotal
            // 
            this.txtBoxWhTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxWhTotal.Location = new System.Drawing.Point(410, 301);
            this.txtBoxWhTotal.Name = "txtBoxWhTotal";
            this.txtBoxWhTotal.Size = new System.Drawing.Size(252, 30);
            this.txtBoxWhTotal.TabIndex = 6;
            this.txtBoxWhTotal.TabStop = false;
            this.txtBoxWhTotal.Text = "total";
            // 
            // txtBoxReceievedWh
            // 
            this.txtBoxReceievedWh.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxReceievedWh.Location = new System.Drawing.Point(410, 347);
            this.txtBoxReceievedWh.Name = "txtBoxReceievedWh";
            this.txtBoxReceievedWh.Size = new System.Drawing.Size(252, 30);
            this.txtBoxReceievedWh.TabIndex = 7;
            this.txtBoxReceievedWh.Text = "received";
            // 
            // txtBoxChangeWh
            // 
            this.txtBoxChangeWh.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxChangeWh.Location = new System.Drawing.Point(410, 394);
            this.txtBoxChangeWh.Name = "txtBoxChangeWh";
            this.txtBoxChangeWh.Size = new System.Drawing.Size(252, 30);
            this.txtBoxChangeWh.TabIndex = 9;
            this.txtBoxChangeWh.TabStop = false;
            this.txtBoxChangeWh.Text = "change";
            // 
            // tileCompute
            // 
            this.tileCompute.CustomBackground = true;
            this.tileCompute.Location = new System.Drawing.Point(715, 204);
            this.tileCompute.Name = "tileCompute";
            this.tileCompute.PaintTileCount = false;
            this.tileCompute.Size = new System.Drawing.Size(100, 96);
            this.tileCompute.TabIndex = 5;
            this.tileCompute.TileImage = global::PointOfSalesApp.Properties.Resources.btnCompute;
            this.tileCompute.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileCompute.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileCompute.UseTileImage = true;
            // 
            // btnCloseAddFormUpd
            // 
            this.btnCloseAddFormUpd.BackgroundImage = global::PointOfSalesApp.Properties.Resources.CLOSE_ICON_THIN;
            this.btnCloseAddFormUpd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseAddFormUpd.FlatAppearance.BorderSize = 0;
            this.btnCloseAddFormUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAddFormUpd.Location = new System.Drawing.Point(888, 20);
            this.btnCloseAddFormUpd.Name = "btnCloseAddFormUpd";
            this.btnCloseAddFormUpd.Size = new System.Drawing.Size(28, 31);
            this.btnCloseAddFormUpd.TabIndex = 13;
            this.btnCloseAddFormUpd.UseVisualStyleBackColor = false;
            // 
            // tileScan
            // 
            this.tileScan.CustomBackground = true;
            this.tileScan.Location = new System.Drawing.Point(715, 102);
            this.tileScan.Name = "tileScan";
            this.tileScan.PaintTileCount = false;
            this.tileScan.Size = new System.Drawing.Size(100, 96);
            this.tileScan.TabIndex = 0;
            this.tileScan.TileImage = global::PointOfSalesApp.Properties.Resources.btnScan;
            this.tileScan.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileScan.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileScan.UseTileImage = true;
            // 
            // tileTransactWh
            // 
            this.tileTransactWh.CustomBackground = true;
            this.tileTransactWh.Location = new System.Drawing.Point(715, 306);
            this.tileTransactWh.Name = "tileTransactWh";
            this.tileTransactWh.PaintTileCount = false;
            this.tileTransactWh.Size = new System.Drawing.Size(100, 96);
            this.tileTransactWh.TabIndex = 8;
            this.tileTransactWh.TileImage = global::PointOfSalesApp.Properties.Resources.Group_71;
            this.tileTransactWh.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileTransactWh.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileTransactWh.UseTileImage = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PointOfSalesApp.Properties.Resources.wholesale_side;
            this.pictureBox1.Location = new System.Drawing.Point(157, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 195);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Wholesale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 477);
            this.Controls.Add(this.tileCompute);
            this.Controls.Add(this.txtBoxChangeWh);
            this.Controls.Add(this.txtBoxReceievedWh);
            this.Controls.Add(this.txtBoxWhTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWhlTotal);
            this.Controls.Add(this.btnCloseAddFormUpd);
            this.Controls.Add(this.tileScan);
            this.Controls.Add(this.tileTransactWh);
            this.Controls.Add(this.txtBoxQtyUpdWh);
            this.Controls.Add(this.txtBoxUnitPriceWh);
            this.Controls.Add(this.txtBoxItemDescWh);
            this.Controls.Add(this.txtBoxProductIDWh);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Wholesale";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Wholesale";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtBoxUnitPriceWh;
        private MetroFramework.Controls.MetroTextBox txtBoxItemDescWh;
        private MetroFramework.Controls.MetroTextBox txtBoxProductIDWh;
        private MetroFramework.Controls.MetroTextBox txtBoxQtyUpdWh;
        private MetroFramework.Controls.MetroTile tileTransactWh;
        private MetroFramework.Controls.MetroTile tileScan;
        private System.Windows.Forms.Button btnCloseAddFormUpd;
        private System.Windows.Forms.Label lblWhlTotal;
        public System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtBoxWhTotal;
        private MetroFramework.Controls.MetroTextBox txtBoxReceievedWh;
        private MetroFramework.Controls.MetroTextBox txtBoxChangeWh;
        private MetroFramework.Controls.MetroTile tileCompute;
    }
}