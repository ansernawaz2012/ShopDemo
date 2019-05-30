namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.itemsListboxLabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingCartListboxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListboxLabel = new System.Windows.Forms.Label();
            this.vendorListbox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(228, 62);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(597, 55);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop Demo";
            // 
            // itemsListbox
            // 
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 29;
            this.itemsListbox.Location = new System.Drawing.Point(60, 220);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(350, 207);
            this.itemsListbox.TabIndex = 1;
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListboxLabel.Location = new System.Drawing.Point(55, 175);
            this.itemsListboxLabel.Name = "itemsListboxLabel";
            this.itemsListboxLabel.Size = new System.Drawing.Size(146, 29);
            this.itemsListboxLabel.TabIndex = 2;
            this.itemsListboxLabel.Text = "Store Items";
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(524, 282);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(195, 57);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add To Cart =>";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // shoppingCartListboxLabel
            // 
            this.shoppingCartListboxLabel.AutoSize = true;
            this.shoppingCartListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListboxLabel.Location = new System.Drawing.Point(851, 175);
            this.shoppingCartListboxLabel.Name = "shoppingCartListboxLabel";
            this.shoppingCartListboxLabel.Size = new System.Drawing.Size(180, 29);
            this.shoppingCartListboxLabel.TabIndex = 5;
            this.shoppingCartListboxLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 29;
            this.shoppingCartListbox.Location = new System.Drawing.Point(856, 220);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(350, 207);
            this.shoppingCartListbox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(1011, 455);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(195, 57);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListboxLabel
            // 
            this.vendorListboxLabel.AutoSize = true;
            this.vendorListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListboxLabel.Location = new System.Drawing.Point(55, 540);
            this.vendorListboxLabel.Name = "vendorListboxLabel";
            this.vendorListboxLabel.Size = new System.Drawing.Size(110, 29);
            this.vendorListboxLabel.TabIndex = 8;
            this.vendorListboxLabel.Text = "Vendors";
            this.vendorListboxLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // vendorListbox
            // 
            this.vendorListbox.FormattingEnabled = true;
            this.vendorListbox.ItemHeight = 29;
            this.vendorListbox.Location = new System.Drawing.Point(60, 585);
            this.vendorListbox.Name = "vendorListbox";
            this.vendorListbox.Size = new System.Drawing.Size(350, 207);
            this.vendorListbox.TabIndex = 7;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitLabel.Location = new System.Drawing.Point(851, 550);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(152, 29);
            this.storeProfitLabel.TabIndex = 9;
            this.storeProfitLabel.Text = "Store Profit:";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(1017, 550);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(76, 29);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "£0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 1092);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListboxLabel);
            this.Controls.Add(this.vendorListbox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListboxLabel);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListboxLabel);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label itemsListboxLabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label shoppingCartListboxLabel;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label vendorListboxLabel;
        private System.Windows.Forms.ListBox vendorListbox;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

