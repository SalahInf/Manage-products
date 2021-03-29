namespace data_save.DevExpFormes
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.Rib = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnNewClient = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRefreshC = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDeleteC = new DevExpress.XtraBars.BarButtonItem();
            this.BtnShowClientTb = new DevExpress.XtraBars.BarButtonItem();
            this.BtnShowProduitTb = new DevExpress.XtraBars.BarButtonItem();
            this.BtnNewProduct = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRefreshP = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDeleteP = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnShowOrdersTb = new DevExpress.XtraBars.BarButtonItem();
            this.RibClient = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RibbClient = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RibProduit = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RibbProduct = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RibCommande = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RibCommandes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rib)).BeginInit();
            this.SuspendLayout();
            // 
            // Rib
            // 
            this.Rib.ExpandCollapseItem.Id = 0;
            this.Rib.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Rib.ExpandCollapseItem,
            this.BtnNewClient,
            this.barButtonItem2,
            this.BtnRefreshC,
            this.BtnDeleteC,
            this.BtnShowClientTb,
            this.BtnShowProduitTb,
            this.BtnNewProduct,
            this.BtnRefreshP,
            this.BtnDeleteP,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.BtnShowOrdersTb});
            this.Rib.Location = new System.Drawing.Point(0, 0);
            this.Rib.MaxItemId = 14;
            this.Rib.Name = "Rib";
            this.Rib.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RibClient,
            this.RibProduit,
            this.RibCommande});
            this.Rib.Size = new System.Drawing.Size(790, 143);
            // 
            // BtnNewClient
            // 
            this.BtnNewClient.Caption = "Nouveau Client";
            this.BtnNewClient.Id = 1;
            this.BtnNewClient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewClient.ImageOptions.Image")));
            this.BtnNewClient.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnNewClient.ImageOptions.LargeImage")));
            this.BtnNewClient.Name = "BtnNewClient";
            this.BtnNewClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNewClient_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // BtnRefreshC
            // 
            this.BtnRefreshC.Caption = "Actualiser";
            this.BtnRefreshC.Id = 3;
            this.BtnRefreshC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefreshC.ImageOptions.Image")));
            this.BtnRefreshC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnRefreshC.ImageOptions.LargeImage")));
            this.BtnRefreshC.Name = "BtnRefreshC";
            this.BtnRefreshC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRefreshC_ItemClick);
            // 
            // BtnDeleteC
            // 
            this.BtnDeleteC.Caption = "Suprimer";
            this.BtnDeleteC.Id = 4;
            this.BtnDeleteC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteC.ImageOptions.Image")));
            this.BtnDeleteC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteC.ImageOptions.LargeImage")));
            this.BtnDeleteC.Name = "BtnDeleteC";
            // 
            // BtnShowClientTb
            // 
            this.BtnShowClientTb.Caption = "Client Table";
            this.BtnShowClientTb.Id = 5;
            this.BtnShowClientTb.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowClientTb.ImageOptions.Image")));
            this.BtnShowClientTb.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnShowClientTb.ImageOptions.LargeImage")));
            this.BtnShowClientTb.Name = "BtnShowClientTb";
            this.BtnShowClientTb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnShowClientTb_ItemClick);
            // 
            // BtnShowProduitTb
            // 
            this.BtnShowProduitTb.Caption = "Produit Table";
            this.BtnShowProduitTb.Id = 6;
            this.BtnShowProduitTb.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowProduitTb.ImageOptions.Image")));
            this.BtnShowProduitTb.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnShowProduitTb.ImageOptions.LargeImage")));
            this.BtnShowProduitTb.Name = "BtnShowProduitTb";
            this.BtnShowProduitTb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnShowProduitTb_ItemClick);
            // 
            // BtnNewProduct
            // 
            this.BtnNewProduct.Caption = "Nouveau produit";
            this.BtnNewProduct.Id = 7;
            this.BtnNewProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewProduct.ImageOptions.Image")));
            this.BtnNewProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnNewProduct.ImageOptions.LargeImage")));
            this.BtnNewProduct.Name = "BtnNewProduct";
            this.BtnNewProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNewProduct_ItemClick);
            // 
            // BtnRefreshP
            // 
            this.BtnRefreshP.Caption = "Actualiser";
            this.BtnRefreshP.Id = 8;
            this.BtnRefreshP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefreshP.ImageOptions.Image")));
            this.BtnRefreshP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnRefreshP.ImageOptions.LargeImage")));
            this.BtnRefreshP.Name = "BtnRefreshP";
            this.BtnRefreshP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRefreshP_ItemClick);
            // 
            // BtnDeleteP
            // 
            this.BtnDeleteP.Caption = "Suprimer";
            this.BtnDeleteP.Id = 9;
            this.BtnDeleteP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteP.ImageOptions.Image")));
            this.BtnDeleteP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteP.ImageOptions.LargeImage")));
            this.BtnDeleteP.Name = "BtnDeleteP";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Nouveau commande";
            this.barButtonItem10.Id = 10;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.LargeImage")));
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Actualiser";
            this.barButtonItem11.Id = 11;
            this.barButtonItem11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.Image")));
            this.barButtonItem11.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.LargeImage")));
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Suprimer";
            this.barButtonItem12.Id = 12;
            this.barButtonItem12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.ImageOptions.Image")));
            this.barButtonItem12.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.ImageOptions.LargeImage")));
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // BtnShowOrdersTb
            // 
            this.BtnShowOrdersTb.Caption = "Les Commendes";
            this.BtnShowOrdersTb.Id = 13;
            this.BtnShowOrdersTb.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowOrdersTb.ImageOptions.Image")));
            this.BtnShowOrdersTb.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnShowOrdersTb.ImageOptions.LargeImage")));
            this.BtnShowOrdersTb.Name = "BtnShowOrdersTb";
            this.BtnShowOrdersTb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnShowOrdersTb_ItemClick);
            // 
            // RibClient
            // 
            this.RibClient.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RibbClient});
            this.RibClient.Name = "RibClient";
            this.RibClient.Text = "Client";
            // 
            // RibbClient
            // 
            this.RibbClient.ItemLinks.Add(this.BtnShowClientTb);
            this.RibbClient.ItemLinks.Add(this.BtnNewClient);
            this.RibbClient.ItemLinks.Add(this.BtnRefreshC);
            this.RibbClient.ItemLinks.Add(this.BtnDeleteC);
            this.RibbClient.Name = "RibbClient";
            this.RibbClient.Text = "Client";
            // 
            // RibProduit
            // 
            this.RibProduit.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RibbProduct});
            this.RibProduit.Name = "RibProduit";
            this.RibProduit.Text = "Produit";
            // 
            // RibbProduct
            // 
            this.RibbProduct.ItemLinks.Add(this.BtnShowProduitTb);
            this.RibbProduct.ItemLinks.Add(this.BtnNewProduct);
            this.RibbProduct.ItemLinks.Add(this.BtnRefreshP);
            this.RibbProduct.ItemLinks.Add(this.BtnDeleteP);
            this.RibbProduct.Name = "RibbProduct";
            this.RibbProduct.Text = "Product";
            // 
            // RibCommande
            // 
            this.RibCommande.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RibCommandes});
            this.RibCommande.Name = "RibCommande";
            this.RibCommande.Text = "Commande";
            // 
            // RibCommandes
            // 
            this.RibCommandes.ItemLinks.Add(this.BtnShowOrdersTb);
            this.RibCommandes.ItemLinks.Add(this.barButtonItem10);
            this.RibCommandes.ItemLinks.Add(this.barButtonItem11);
            this.RibCommandes.ItemLinks.Add(this.barButtonItem12);
            this.RibCommandes.Name = "RibCommandes";
            this.RibCommandes.Text = "Commande";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 595);
            this.Controls.Add(this.Rib);
            this.IsMdiContainer = true;
            this.Name = "FrmMainMenu";
            this.Ribbon = this.Rib;
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rib)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Ribbon.RibbonControl Rib;
        private DevExpress.XtraBars.BarButtonItem BtnNewClient;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem BtnRefreshC;
        private DevExpress.XtraBars.BarButtonItem BtnDeleteC;
        private DevExpress.XtraBars.BarButtonItem BtnShowClientTb;
        private DevExpress.XtraBars.BarButtonItem BtnShowProduitTb;
        private DevExpress.XtraBars.BarButtonItem BtnNewProduct;
        private DevExpress.XtraBars.BarButtonItem BtnRefreshP;
        private DevExpress.XtraBars.BarButtonItem BtnDeleteP;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem BtnShowOrdersTb;
        private DevExpress.XtraBars.Ribbon.RibbonPage RibClient;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RibbClient;
        private DevExpress.XtraBars.Ribbon.RibbonPage RibProduit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RibbProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPage RibCommande;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RibCommandes;
    }
}