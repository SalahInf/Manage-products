namespace data_save.SousFormes
{
    partial class NewProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProductForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.BtClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.Produit = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ProduitBare = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LBnomeProduit = new System.Windows.Forms.Label();
            this.TxtNomProduct = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.DtProductDate = new System.Windows.Forms.DateTimePicker();
            this.CBProductEtat = new System.Windows.Forms.ComboBox();
            this.LBprixProduit = new System.Windows.Forms.Label();
            this.LBStock = new System.Windows.Forms.Label();
            this.BLetatProduit = new System.Windows.Forms.Label();
            this.LBDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BtSave,
            this.barButtonItem2,
            this.BtClose,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Produit});
            this.ribbonControl1.Size = new System.Drawing.Size(484, 141);
            // 
            // BtSave
            // 
            this.BtSave.Caption = "Sauvgarder";
            this.BtSave.Id = 1;
            this.BtSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtSave.ImageOptions.Image")));
            this.BtSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtSave.ImageOptions.LargeImage")));
            this.BtSave.Name = "BtSave";
            this.BtSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtSave_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // BtClose
            // 
            this.BtClose.Caption = "Fermer";
            this.BtClose.Id = 3;
            this.BtClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtClose.ImageOptions.Image")));
            this.BtClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtClose.ImageOptions.LargeImage")));
            this.BtClose.Name = "BtClose";
            this.BtClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtClose_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // Produit
            // 
            this.Produit.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ProduitBare});
            this.Produit.Name = "Produit";
            this.Produit.Text = "Produit";
            // 
            // ProduitBare
            // 
            this.ProduitBare.ItemLinks.Add(this.BtSave);
            this.ProduitBare.ItemLinks.Add(this.BtClose);
            this.ProduitBare.Name = "ProduitBare";
            this.ProduitBare.Text = "Produit";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(82, 159);
            this.TxtPrice.Multiline = true;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(128, 40);
            this.TxtPrice.TabIndex = 1;
            this.TxtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrice_KeyPress);
            // 
            // LBnomeProduit
            // 
            this.LBnomeProduit.AutoSize = true;
            this.LBnomeProduit.Location = new System.Drawing.Point(233, 162);
            this.LBnomeProduit.Name = "LBnomeProduit";
            this.LBnomeProduit.Size = new System.Drawing.Size(82, 13);
            this.LBnomeProduit.TabIndex = 2;
            this.LBnomeProduit.Text = "Nom De Produit";
            // 
            // TxtNomProduct
            // 
            this.TxtNomProduct.Location = new System.Drawing.Point(321, 159);
            this.TxtNomProduct.Multiline = true;
            this.TxtNomProduct.Name = "TxtNomProduct";
            this.TxtNomProduct.Size = new System.Drawing.Size(128, 40);
            this.TxtNomProduct.TabIndex = 3;
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(82, 259);
            this.TxtStock.Multiline = true;
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(128, 40);
            this.TxtStock.TabIndex = 4;
            this.TxtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStock_KeyPress);
            // 
            // DtProductDate
            // 
            this.DtProductDate.Location = new System.Drawing.Point(176, 343);
            this.DtProductDate.Name = "DtProductDate";
            this.DtProductDate.Size = new System.Drawing.Size(200, 20);
            this.DtProductDate.TabIndex = 6;
            // 
            // CBProductEtat
            // 
            this.CBProductEtat.FormattingEnabled = true;
            this.CBProductEtat.Items.AddRange(new object[] {
            "Solid",
            "Fragile"});
            this.CBProductEtat.Location = new System.Drawing.Point(309, 262);
            this.CBProductEtat.Name = "CBProductEtat";
            this.CBProductEtat.Size = new System.Drawing.Size(140, 21);
            this.CBProductEtat.TabIndex = 7;
            // 
            // LBprixProduit
            // 
            this.LBprixProduit.AutoSize = true;
            this.LBprixProduit.Location = new System.Drawing.Point(31, 159);
            this.LBprixProduit.Name = "LBprixProduit";
            this.LBprixProduit.Size = new System.Drawing.Size(30, 13);
            this.LBprixProduit.TabIndex = 8;
            this.LBprixProduit.Text = "Prix  ";
            // 
            // LBStock
            // 
            this.LBStock.AutoSize = true;
            this.LBStock.Location = new System.Drawing.Point(31, 262);
            this.LBStock.Name = "LBStock";
            this.LBStock.Size = new System.Drawing.Size(35, 13);
            this.LBStock.TabIndex = 9;
            this.LBStock.Text = "Stock";
            // 
            // BLetatProduit
            // 
            this.BLetatProduit.AutoSize = true;
            this.BLetatProduit.Location = new System.Drawing.Point(226, 265);
            this.BLetatProduit.Name = "BLetatProduit";
            this.BLetatProduit.Size = new System.Drawing.Size(77, 13);
            this.BLetatProduit.TabIndex = 10;
            this.BLetatProduit.Text = "Etat de Produit";
            // 
            // LBDate
            // 
            this.LBDate.AutoSize = true;
            this.LBDate.Location = new System.Drawing.Point(101, 343);
            this.LBDate.Name = "LBDate";
            this.LBDate.Size = new System.Drawing.Size(30, 13);
            this.LBDate.TabIndex = 11;
            this.LBDate.Text = "Date";
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 391);
            this.Controls.Add(this.LBDate);
            this.Controls.Add(this.BLetatProduit);
            this.Controls.Add(this.LBStock);
            this.Controls.Add(this.LBprixProduit);
            this.Controls.Add(this.CBProductEtat);
            this.Controls.Add(this.DtProductDate);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtNomProduct);
            this.Controls.Add(this.LBnomeProduit);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "NewProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem BtSave;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem BtClose;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage Produit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ProduitBare;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label LBnomeProduit;
        private System.Windows.Forms.TextBox TxtNomProduct;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.DateTimePicker DtProductDate;
        private System.Windows.Forms.ComboBox CBProductEtat;
        private System.Windows.Forms.Label LBprixProduit;
        private System.Windows.Forms.Label LBStock;
        private System.Windows.Forms.Label BLetatProduit;
        private System.Windows.Forms.Label LBDate;
    }
}