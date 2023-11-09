namespace LoginApp
{
    partial class UpdateProductSeller
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
            this.laBelProductList = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.bTnUpdate = new System.Windows.Forms.Button();
            this.bTnClose = new System.Windows.Forms.Button();
            this.chkBoxName = new System.Windows.Forms.CheckBox();
            this.chckBoxPrice = new System.Windows.Forms.CheckBox();
            this.chckBoxStock = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // laBelProductList
            // 
            this.laBelProductList.AutoSize = true;
            this.laBelProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laBelProductList.Location = new System.Drawing.Point(90, 66);
            this.laBelProductList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laBelProductList.Name = "laBelProductList";
            this.laBelProductList.Size = new System.Drawing.Size(133, 25);
            this.laBelProductList.TabIndex = 0;
            this.laBelProductList.Text = "Product List:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(261, 65);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(213, 176);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(146, 26);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(213, 263);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(146, 26);
            this.textBoxPrice.TabIndex = 6;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(213, 343);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(146, 26);
            this.textBoxQuantity.TabIndex = 7;
            // 
            // bTnUpdate
            // 
            this.bTnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTnUpdate.Location = new System.Drawing.Point(94, 411);
            this.bTnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bTnUpdate.Name = "bTnUpdate";
            this.bTnUpdate.Size = new System.Drawing.Size(142, 57);
            this.bTnUpdate.TabIndex = 8;
            this.bTnUpdate.Text = "Update";
            this.bTnUpdate.UseVisualStyleBackColor = true;
            this.bTnUpdate.Click += new System.EventHandler(this.bTnUpdate_Click);
            // 
            // bTnClose
            // 
            this.bTnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTnClose.Location = new System.Drawing.Point(596, 411);
            this.bTnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bTnClose.Name = "bTnClose";
            this.bTnClose.Size = new System.Drawing.Size(153, 55);
            this.bTnClose.TabIndex = 9;
            this.bTnClose.Text = "Close";
            this.bTnClose.UseVisualStyleBackColor = true;
            this.bTnClose.Click += new System.EventHandler(this.bTnClose_Click);
            // 
            // chkBoxName
            // 
            this.chkBoxName.AutoSize = true;
            this.chkBoxName.Location = new System.Drawing.Point(75, 178);
            this.chkBoxName.Name = "chkBoxName";
            this.chkBoxName.Size = new System.Drawing.Size(77, 24);
            this.chkBoxName.TabIndex = 10;
            this.chkBoxName.Text = "Name";
            this.chkBoxName.UseVisualStyleBackColor = true;
            // 
            // chckBoxPrice
            // 
            this.chckBoxPrice.AutoSize = true;
            this.chckBoxPrice.Location = new System.Drawing.Point(75, 263);
            this.chckBoxPrice.Name = "chckBoxPrice";
            this.chckBoxPrice.Size = new System.Drawing.Size(70, 24);
            this.chckBoxPrice.TabIndex = 11;
            this.chckBoxPrice.Text = "Price";
            this.chckBoxPrice.UseVisualStyleBackColor = true;
            // 
            // chckBoxStock
            // 
            this.chckBoxStock.AutoSize = true;
            this.chckBoxStock.Location = new System.Drawing.Point(75, 345);
            this.chckBoxStock.Name = "chckBoxStock";
            this.chckBoxStock.Size = new System.Drawing.Size(76, 24);
            this.chckBoxStock.TabIndex = 12;
            this.chckBoxStock.Text = "Stock";
            this.chckBoxStock.UseVisualStyleBackColor = true;
            // 
            // UpdateProductSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 486);
            this.Controls.Add(this.chckBoxStock);
            this.Controls.Add(this.chckBoxPrice);
            this.Controls.Add(this.chkBoxName);
            this.Controls.Add(this.bTnClose);
            this.Controls.Add(this.bTnUpdate);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.laBelProductList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateProductSeller";
            this.Text = "Update Form";
            this.Load += new System.EventHandler(this.UpdateProductSeller_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateProductSeller_Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laBelProductList;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button bTnUpdate;
        private System.Windows.Forms.Button bTnClose;
        private System.Windows.Forms.CheckBox chkBoxName;
        private System.Windows.Forms.CheckBox chckBoxPrice;
        private System.Windows.Forms.CheckBox chckBoxStock;
    }
}