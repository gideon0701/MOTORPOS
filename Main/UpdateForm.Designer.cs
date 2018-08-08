namespace PointOfSalesApp.Main
{
    partial class UpdateForm
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
            this.txtBoxQtyUpd = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxUnitPriceUpd = new MetroFramework.Controls.MetroTextBox();
            this.cmboCategoryUpd = new MetroFramework.Controls.MetroComboBox();
            this.txtBoxItemDescUpd = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxProductID = new MetroFramework.Controls.MetroTextBox();
            this.btnCloseAddFormUpd = new System.Windows.Forms.Button();
            this.btnSaveAddFormUpd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxQtyUpd
            // 
            this.txtBoxQtyUpd.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxQtyUpd.Location = new System.Drawing.Point(473, 340);
            this.txtBoxQtyUpd.Name = "txtBoxQtyUpd";
            this.txtBoxQtyUpd.Size = new System.Drawing.Size(252, 30);
            this.txtBoxQtyUpd.TabIndex = 5;
            this.txtBoxQtyUpd.Text = "Quantity in Hand";
            // 
            // txtBoxUnitPriceUpd
            // 
            this.txtBoxUnitPriceUpd.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxUnitPriceUpd.Location = new System.Drawing.Point(473, 289);
            this.txtBoxUnitPriceUpd.Name = "txtBoxUnitPriceUpd";
            this.txtBoxUnitPriceUpd.Size = new System.Drawing.Size(252, 30);
            this.txtBoxUnitPriceUpd.TabIndex = 4;
            this.txtBoxUnitPriceUpd.Text = "Price per Unit";
            // 
            // cmboCategoryUpd
            // 
            this.cmboCategoryUpd.FormattingEnabled = true;
            this.cmboCategoryUpd.ItemHeight = 23;
            this.cmboCategoryUpd.Location = new System.Drawing.Point(473, 188);
            this.cmboCategoryUpd.Name = "cmboCategoryUpd";
            this.cmboCategoryUpd.Size = new System.Drawing.Size(252, 29);
            this.cmboCategoryUpd.TabIndex = 2;
            // 
            // txtBoxItemDescUpd
            // 
            this.txtBoxItemDescUpd.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxItemDescUpd.Location = new System.Drawing.Point(473, 238);
            this.txtBoxItemDescUpd.Name = "txtBoxItemDescUpd";
            this.txtBoxItemDescUpd.Size = new System.Drawing.Size(252, 30);
            this.txtBoxItemDescUpd.TabIndex = 3;
            this.txtBoxItemDescUpd.Text = "Item Description";
            // 
            // txtBoxProductID
            // 
            this.txtBoxProductID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxProductID.Location = new System.Drawing.Point(473, 137);
            this.txtBoxProductID.Name = "txtBoxProductID";
            this.txtBoxProductID.Size = new System.Drawing.Size(252, 30);
            this.txtBoxProductID.TabIndex = 1;
            this.txtBoxProductID.Text = "Product ID";
            // 
            // btnCloseAddFormUpd
            // 
            this.btnCloseAddFormUpd.BackgroundImage = global::PointOfSalesApp.Properties.Resources.CLOSE_ICON_THIN;
            this.btnCloseAddFormUpd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseAddFormUpd.FlatAppearance.BorderSize = 0;
            this.btnCloseAddFormUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAddFormUpd.Location = new System.Drawing.Point(895, 12);
            this.btnCloseAddFormUpd.Name = "btnCloseAddFormUpd";
            this.btnCloseAddFormUpd.Size = new System.Drawing.Size(28, 31);
            this.btnCloseAddFormUpd.TabIndex = 7;
            this.btnCloseAddFormUpd.UseVisualStyleBackColor = false;
            // 
            // btnSaveAddFormUpd
            // 
            this.btnSaveAddFormUpd.BackgroundImage = global::PointOfSalesApp.Properties.Resources.save_icon;
            this.btnSaveAddFormUpd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveAddFormUpd.FlatAppearance.BorderSize = 0;
            this.btnSaveAddFormUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAddFormUpd.Location = new System.Drawing.Point(861, 12);
            this.btnSaveAddFormUpd.Name = "btnSaveAddFormUpd";
            this.btnSaveAddFormUpd.Size = new System.Drawing.Size(28, 31);
            this.btnSaveAddFormUpd.TabIndex = 6;
            this.btnSaveAddFormUpd.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PointOfSalesApp.Properties.Resources.update_icon;
            this.pictureBox1.Location = new System.Drawing.Point(246, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 135);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 477);
            this.Controls.Add(this.txtBoxQtyUpd);
            this.Controls.Add(this.txtBoxUnitPriceUpd);
            this.Controls.Add(this.cmboCategoryUpd);
            this.Controls.Add(this.txtBoxItemDescUpd);
            this.Controls.Add(this.txtBoxProductID);
            this.Controls.Add(this.btnCloseAddFormUpd);
            this.Controls.Add(this.btnSaveAddFormUpd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UpdateForm";
            this.Text = "Update Item";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtBoxQtyUpd;
        private MetroFramework.Controls.MetroTextBox txtBoxUnitPriceUpd;
        private MetroFramework.Controls.MetroComboBox cmboCategoryUpd;
        private MetroFramework.Controls.MetroTextBox txtBoxItemDescUpd;
        private MetroFramework.Controls.MetroTextBox txtBoxProductID;
        private System.Windows.Forms.Button btnCloseAddFormUpd;
        private System.Windows.Forms.Button btnSaveAddFormUpd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}