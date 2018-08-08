namespace PointOfSalesApp.Main
{
    partial class AddForm
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
            this.txtBoxQty = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxUnitPrice = new MetroFramework.Controls.MetroTextBox();
            this.cmboItemCategory = new MetroFramework.Controls.MetroComboBox();
            this.txtBoxItemDesc = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxProductID = new MetroFramework.Controls.MetroTextBox();
            this.btnCloseAddForm = new System.Windows.Forms.Button();
            this.btnSaveAddForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxQty
            // 
            this.txtBoxQty.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxQty.Location = new System.Drawing.Point(503, 347);
            this.txtBoxQty.Name = "txtBoxQty";
            this.txtBoxQty.Size = new System.Drawing.Size(252, 30);
            this.txtBoxQty.TabIndex = 5;
            this.txtBoxQty.Text = "Quantity in Hand";
            // 
            // txtBoxUnitPrice
            // 
            this.txtBoxUnitPrice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxUnitPrice.Location = new System.Drawing.Point(503, 296);
            this.txtBoxUnitPrice.Name = "txtBoxUnitPrice";
            this.txtBoxUnitPrice.Size = new System.Drawing.Size(252, 30);
            this.txtBoxUnitPrice.TabIndex = 4;
            this.txtBoxUnitPrice.Text = "Price per Unit";
            // 
            // cmboItemCategory
            // 
            this.cmboItemCategory.FormattingEnabled = true;
            this.cmboItemCategory.ItemHeight = 23;
            this.cmboItemCategory.Location = new System.Drawing.Point(503, 195);
            this.cmboItemCategory.Name = "cmboItemCategory";
            this.cmboItemCategory.Size = new System.Drawing.Size(252, 29);
            this.cmboItemCategory.TabIndex = 2;
            // 
            // txtBoxItemDesc
            // 
            this.txtBoxItemDesc.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxItemDesc.Location = new System.Drawing.Point(503, 245);
            this.txtBoxItemDesc.Name = "txtBoxItemDesc";
            this.txtBoxItemDesc.Size = new System.Drawing.Size(252, 30);
            this.txtBoxItemDesc.TabIndex = 3;
            this.txtBoxItemDesc.Text = "Item Description";
            // 
            // txtBoxProductID
            // 
            this.txtBoxProductID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxProductID.Location = new System.Drawing.Point(503, 144);
            this.txtBoxProductID.Name = "txtBoxProductID";
            this.txtBoxProductID.Size = new System.Drawing.Size(252, 30);
            this.txtBoxProductID.TabIndex = 1;
            this.txtBoxProductID.Text = "Product ID";
            // 
            // btnCloseAddForm
            // 
            this.btnCloseAddForm.BackgroundImage = global::PointOfSalesApp.Properties.Resources.CLOSE_ICON_THIN;
            this.btnCloseAddForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseAddForm.FlatAppearance.BorderSize = 0;
            this.btnCloseAddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAddForm.Location = new System.Drawing.Point(904, 21);
            this.btnCloseAddForm.Name = "btnCloseAddForm";
            this.btnCloseAddForm.Size = new System.Drawing.Size(28, 31);
            this.btnCloseAddForm.TabIndex = 7;
            this.btnCloseAddForm.UseVisualStyleBackColor = false;
            // 
            // btnSaveAddForm
            // 
            this.btnSaveAddForm.BackgroundImage = global::PointOfSalesApp.Properties.Resources.save_icon;
            this.btnSaveAddForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveAddForm.FlatAppearance.BorderSize = 0;
            this.btnSaveAddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAddForm.Location = new System.Drawing.Point(870, 21);
            this.btnSaveAddForm.Name = "btnSaveAddForm";
            this.btnSaveAddForm.Size = new System.Drawing.Size(28, 31);
            this.btnSaveAddForm.TabIndex = 6;
            this.btnSaveAddForm.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PointOfSalesApp.Properties.Resources.add_items;
            this.pictureBox1.Location = new System.Drawing.Point(172, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 206);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 515);
            this.Controls.Add(this.txtBoxQty);
            this.Controls.Add(this.txtBoxUnitPrice);
            this.Controls.Add(this.cmboItemCategory);
            this.Controls.Add(this.txtBoxItemDesc);
            this.Controls.Add(this.txtBoxProductID);
            this.Controls.Add(this.btnCloseAddForm);
            this.Controls.Add(this.btnSaveAddForm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtBoxQty;
        private MetroFramework.Controls.MetroTextBox txtBoxUnitPrice;
        private MetroFramework.Controls.MetroComboBox cmboItemCategory;
        private MetroFramework.Controls.MetroTextBox txtBoxItemDesc;
        private MetroFramework.Controls.MetroTextBox txtBoxProductID;
        private System.Windows.Forms.Button btnCloseAddForm;
        private System.Windows.Forms.Button btnSaveAddForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}