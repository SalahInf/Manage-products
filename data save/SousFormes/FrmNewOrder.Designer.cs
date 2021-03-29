namespace data_save.SousFormes
{
    partial class FrmNewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewOrder));
            this.LbClien = new System.Windows.Forms.Label();
            this.LbProduit = new System.Windows.Forms.Label();
            this.LbStockProduit = new System.Windows.Forms.Label();
            this.CbClient = new System.Windows.Forms.ComboBox();
            this.CbProduit = new System.Windows.Forms.ComboBox();
            this.TxtClientName = new System.Windows.Forms.TextBox();
            this.TxtProduitName = new System.Windows.Forms.TextBox();
            this.TxtStockPeoduit = new System.Windows.Forms.TextBox();
            this.CbStatueProduit = new System.Windows.Forms.ComboBox();
            this.TxtEtatProduit = new System.Windows.Forms.TextBox();
            this.TxtPrixProduit = new System.Windows.Forms.TextBox();
            this.LbPrixProduit = new System.Windows.Forms.Label();
            this.TxtNumCommande = new System.Windows.Forms.TextBox();
            this.LbNumCommand = new System.Windows.Forms.Label();
            this.LbEtatProduit = new System.Windows.Forms.Label();
            this.DtpCommande = new System.Windows.Forms.DateTimePicker();
            this.RibCommand = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtSave = new DevExpress.XtraBars.BarButtonItem();
            this.BTClose = new DevExpress.XtraBars.BarButtonItem();
            this.RibNewCommand = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Commande = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Orders = new DevExpress.XtraGrid.GridControl();
            this.GvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductGroup = new System.Windows.Forms.GroupBox();
            this.ClientGroup = new System.Windows.Forms.GroupBox();
            this.LbClientNum = new System.Windows.Forms.Label();
            this.LbPrenomClient = new System.Windows.Forms.Label();
            this.LbClientNom = new System.Windows.Forms.Label();
            this.TxtClientPrenom = new System.Windows.Forms.TextBox();
            this.TxtClientNumber = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.TxtQuantiter = new System.Windows.Forms.TextBox();
            this.NomProduct = new System.Windows.Forms.Label();
            this.StatueProduct = new System.Windows.Forms.Label();
            this.LbQuantiter = new System.Windows.Forms.Label();
            this.Nam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RibCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvOrders)).BeginInit();
            this.ProductGroup.SuspendLayout();
            this.ClientGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbClien
            // 
            this.LbClien.AutoSize = true;
            this.LbClien.Location = new System.Drawing.Point(563, 204);
            this.LbClien.Name = "LbClien";
            this.LbClien.Size = new System.Drawing.Size(78, 13);
            this.LbClien.TabIndex = 0;
            this.LbClien.Text = "Choisir le client";
            // 
            // LbProduit
            // 
            this.LbProduit.AutoSize = true;
            this.LbProduit.Location = new System.Drawing.Point(166, 199);
            this.LbProduit.Name = "LbProduit";
            this.LbProduit.Size = new System.Drawing.Size(87, 13);
            this.LbProduit.TabIndex = 1;
            this.LbProduit.Text = "Choisir le produit";
            // 
            // LbStockProduit
            // 
            this.LbStockProduit.AutoSize = true;
            this.LbStockProduit.Location = new System.Drawing.Point(214, 79);
            this.LbStockProduit.Name = "LbStockProduit";
            this.LbStockProduit.Size = new System.Drawing.Size(85, 13);
            this.LbStockProduit.TabIndex = 1;
            this.LbStockProduit.Text = "Stock de produit";
            // 
            // CbClient
            // 
            this.CbClient.FormattingEnabled = true;
            this.CbClient.Location = new System.Drawing.Point(647, 196);
            this.CbClient.Name = "CbClient";
            this.CbClient.Size = new System.Drawing.Size(175, 21);
            this.CbClient.TabIndex = 2;
            this.CbClient.SelectedIndexChanged += new System.EventHandler(this.CbClient_SelectedIndexChanged);
            // 
            // CbProduit
            // 
            this.CbProduit.FormattingEnabled = true;
            this.CbProduit.Location = new System.Drawing.Point(262, 196);
            this.CbProduit.Name = "CbProduit";
            this.CbProduit.Size = new System.Drawing.Size(175, 21);
            this.CbProduit.TabIndex = 2;
            this.CbProduit.SelectedIndexChanged += new System.EventHandler(this.CbProduit_SelectedIndexChanged);
            // 
            // TxtClientName
            // 
            this.TxtClientName.AllowDrop = true;
            this.TxtClientName.Location = new System.Drawing.Point(118, 33);
            this.TxtClientName.Multiline = true;
            this.TxtClientName.Name = "TxtClientName";
            this.TxtClientName.ReadOnly = true;
            this.TxtClientName.Size = new System.Drawing.Size(168, 30);
            this.TxtClientName.TabIndex = 3;
            // 
            // TxtProduitName
            // 
            this.TxtProduitName.AllowDrop = true;
            this.TxtProduitName.Location = new System.Drawing.Point(56, 39);
            this.TxtProduitName.Multiline = true;
            this.TxtProduitName.Name = "TxtProduitName";
            this.TxtProduitName.ReadOnly = true;
            this.TxtProduitName.Size = new System.Drawing.Size(155, 30);
            this.TxtProduitName.TabIndex = 4;
            // 
            // TxtStockPeoduit
            // 
            this.TxtStockPeoduit.Location = new System.Drawing.Point(305, 76);
            this.TxtStockPeoduit.Multiline = true;
            this.TxtStockPeoduit.Name = "TxtStockPeoduit";
            this.TxtStockPeoduit.ReadOnly = true;
            this.TxtStockPeoduit.Size = new System.Drawing.Size(72, 22);
            this.TxtStockPeoduit.TabIndex = 5;
            // 
            // CbStatueProduit
            // 
            this.CbStatueProduit.FormattingEnabled = true;
            this.CbStatueProduit.Items.AddRange(new object[] {
            "Cach on delivery",
            "Normal achat"});
            this.CbStatueProduit.Location = new System.Drawing.Point(69, 76);
            this.CbStatueProduit.Name = "CbStatueProduit";
            this.CbStatueProduit.Size = new System.Drawing.Size(139, 21);
            this.CbStatueProduit.TabIndex = 7;
            // 
            // TxtEtatProduit
            // 
            this.TxtEtatProduit.Location = new System.Drawing.Point(269, 20);
            this.TxtEtatProduit.Multiline = true;
            this.TxtEtatProduit.Name = "TxtEtatProduit";
            this.TxtEtatProduit.ReadOnly = true;
            this.TxtEtatProduit.Size = new System.Drawing.Size(108, 22);
            this.TxtEtatProduit.TabIndex = 5;
            // 
            // TxtPrixProduit
            // 
            this.TxtPrixProduit.Location = new System.Drawing.Point(305, 48);
            this.TxtPrixProduit.Multiline = true;
            this.TxtPrixProduit.Name = "TxtPrixProduit";
            this.TxtPrixProduit.ReadOnly = true;
            this.TxtPrixProduit.Size = new System.Drawing.Size(72, 22);
            this.TxtPrixProduit.TabIndex = 5;
            // 
            // LbPrixProduit
            // 
            this.LbPrixProduit.AutoSize = true;
            this.LbPrixProduit.Location = new System.Drawing.Point(217, 51);
            this.LbPrixProduit.Name = "LbPrixProduit";
            this.LbPrixProduit.Size = new System.Drawing.Size(73, 13);
            this.LbPrixProduit.TabIndex = 1;
            this.LbPrixProduit.Text = "Prix le produit";
            // 
            // TxtNumCommande
            // 
            this.TxtNumCommande.Location = new System.Drawing.Point(18, 167);
            this.TxtNumCommande.Multiline = true;
            this.TxtNumCommande.Name = "TxtNumCommande";
            this.TxtNumCommande.ReadOnly = true;
            this.TxtNumCommande.Size = new System.Drawing.Size(98, 33);
            this.TxtNumCommande.TabIndex = 3;
            // 
            // LbNumCommand
            // 
            this.LbNumCommand.AutoSize = true;
            this.LbNumCommand.Location = new System.Drawing.Point(15, 151);
            this.LbNumCommand.Name = "LbNumCommand";
            this.LbNumCommand.Size = new System.Drawing.Size(113, 13);
            this.LbNumCommand.TabIndex = 1;
            this.LbNumCommand.Text = "Numero de commande";
            // 
            // LbEtatProduit
            // 
            this.LbEtatProduit.AutoSize = true;
            this.LbEtatProduit.Location = new System.Drawing.Point(184, 23);
            this.LbEtatProduit.Name = "LbEtatProduit";
            this.LbEtatProduit.Size = new System.Drawing.Size(79, 13);
            this.LbEtatProduit.TabIndex = 1;
            this.LbEtatProduit.Text = "Etat de produit";
            // 
            // DtpCommande
            // 
            this.DtpCommande.Location = new System.Drawing.Point(215, 116);
            this.DtpCommande.Name = "DtpCommande";
            this.DtpCommande.Size = new System.Drawing.Size(204, 21);
            this.DtpCommande.TabIndex = 8;
            // 
            // RibCommand
            // 
            this.RibCommand.ExpandCollapseItem.Id = 0;
            this.RibCommand.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RibCommand.ExpandCollapseItem,
            this.BtSave,
            this.BTClose});
            this.RibCommand.Location = new System.Drawing.Point(0, 0);
            this.RibCommand.MaxItemId = 3;
            this.RibCommand.Name = "RibCommand";
            this.RibCommand.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RibNewCommand});
            this.RibCommand.Size = new System.Drawing.Size(852, 143);
            // 
            // BtSave
            // 
            this.BtSave.Caption = "Sauvgarder";
            this.BtSave.Id = 1;
            this.BtSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtSave.ImageOptions.Image")));
            this.BtSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtSave.ImageOptions.LargeImage")));
            this.BtSave.ImageOptions.SvgImageSize = new System.Drawing.Size(80, 0);
            this.BtSave.Name = "BtSave";
            this.BtSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtSave_ItemClick);
            // 
            // BTClose
            // 
            this.BTClose.Caption = "Fermer";
            this.BTClose.Id = 2;
            this.BTClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTClose.ImageOptions.Image")));
            this.BTClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTClose.ImageOptions.LargeImage")));
            this.BTClose.LargeWidth = 80;
            this.BTClose.Name = "BTClose";
            this.BTClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // RibNewCommand
            // 
            this.RibNewCommand.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Commande});
            this.RibNewCommand.Name = "RibNewCommand";
            this.RibNewCommand.Text = "Commande";
            // 
            // Commande
            // 
            this.Commande.ItemLinks.Add(this.BtSave);
            this.Commande.ItemLinks.Add(this.BTClose);
            this.Commande.Name = "Commande";
            this.Commande.Text = "Commande";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // Orders
            // 
            this.Orders.AccessibleDescription = "GcOrders";
            this.Orders.Location = new System.Drawing.Point(12, 374);
            this.Orders.MainView = this.GvOrders;
            this.Orders.MenuManager = this.RibCommand;
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(833, 214);
            this.Orders.TabIndex = 12;
            this.Orders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvOrders});
            // 
            // GvOrders
            // 
            this.GvOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nam,
            this.ProductState,
            this.ProductPrice,
            this.gridColumn4,
            this.gridColumn5,
            this.Quantity,
            this.OrderDate});
            this.GvOrders.GridControl = this.Orders;
            this.GvOrders.Name = "GvOrders";
            // 
            // ProductGroup
            // 
            this.ProductGroup.Controls.Add(this.LbQuantiter);
            this.ProductGroup.Controls.Add(this.StatueProduct);
            this.ProductGroup.Controls.Add(this.NomProduct);
            this.ProductGroup.Controls.Add(this.TxtQuantiter);
            this.ProductGroup.Controls.Add(this.simpleButton1);
            this.ProductGroup.Controls.Add(this.TxtProduitName);
            this.ProductGroup.Controls.Add(this.DtpCommande);
            this.ProductGroup.Controls.Add(this.TxtPrixProduit);
            this.ProductGroup.Controls.Add(this.TxtStockPeoduit);
            this.ProductGroup.Controls.Add(this.TxtEtatProduit);
            this.ProductGroup.Controls.Add(this.CbStatueProduit);
            this.ProductGroup.Controls.Add(this.LbStockProduit);
            this.ProductGroup.Controls.Add(this.LbPrixProduit);
            this.ProductGroup.Controls.Add(this.LbEtatProduit);
            this.ProductGroup.Location = new System.Drawing.Point(18, 215);
            this.ProductGroup.Name = "ProductGroup";
            this.ProductGroup.Size = new System.Drawing.Size(435, 153);
            this.ProductGroup.TabIndex = 13;
            this.ProductGroup.TabStop = false;
            this.ProductGroup.Text = "Produit";
            // 
            // ClientGroup
            // 
            this.ClientGroup.Controls.Add(this.LbClientNum);
            this.ClientGroup.Controls.Add(this.LbPrenomClient);
            this.ClientGroup.Controls.Add(this.LbClientNom);
            this.ClientGroup.Controls.Add(this.TxtClientPrenom);
            this.ClientGroup.Controls.Add(this.TxtClientNumber);
            this.ClientGroup.Controls.Add(this.TxtClientName);
            this.ClientGroup.Location = new System.Drawing.Point(459, 216);
            this.ClientGroup.Name = "ClientGroup";
            this.ClientGroup.Size = new System.Drawing.Size(369, 152);
            this.ClientGroup.TabIndex = 14;
            this.ClientGroup.TabStop = false;
            this.ClientGroup.Text = "Client";
            // 
            // LbClientNum
            // 
            this.LbClientNum.AutoSize = true;
            this.LbClientNum.Location = new System.Drawing.Point(25, 115);
            this.LbClientNum.Name = "LbClientNum";
            this.LbClientNum.Size = new System.Drawing.Size(87, 13);
            this.LbClientNum.TabIndex = 7;
            this.LbClientNum.Text = "Numero de client";
            // 
            // LbPrenomClient
            // 
            this.LbPrenomClient.AutoSize = true;
            this.LbPrenomClient.Location = new System.Drawing.Point(25, 78);
            this.LbPrenomClient.Name = "LbPrenomClient";
            this.LbPrenomClient.Size = new System.Drawing.Size(86, 13);
            this.LbPrenomClient.TabIndex = 7;
            this.LbPrenomClient.Text = "Prenom de client";
            // 
            // LbClientNom
            // 
            this.LbClientNom.AutoSize = true;
            this.LbClientNom.Location = new System.Drawing.Point(25, 47);
            this.LbClientNom.Name = "LbClientNom";
            this.LbClientNom.Size = new System.Drawing.Size(71, 13);
            this.LbClientNom.TabIndex = 6;
            this.LbClientNom.Text = "Nom de client";
            // 
            // TxtClientPrenom
            // 
            this.TxtClientPrenom.AllowDrop = true;
            this.TxtClientPrenom.Location = new System.Drawing.Point(118, 69);
            this.TxtClientPrenom.Multiline = true;
            this.TxtClientPrenom.Name = "TxtClientPrenom";
            this.TxtClientPrenom.ReadOnly = true;
            this.TxtClientPrenom.Size = new System.Drawing.Size(168, 30);
            this.TxtClientPrenom.TabIndex = 5;
            // 
            // TxtClientNumber
            // 
            this.TxtClientNumber.AllowDrop = true;
            this.TxtClientNumber.Location = new System.Drawing.Point(118, 106);
            this.TxtClientNumber.Multiline = true;
            this.TxtClientNumber.Name = "TxtClientNumber";
            this.TxtClientNumber.ReadOnly = true;
            this.TxtClientNumber.Size = new System.Drawing.Size(168, 30);
            this.TxtClientNumber.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(6, 116);
            this.simpleButton1.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(77, 31);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Ajouter";
            // 
            // TxtQuantiter
            // 
            this.TxtQuantiter.Location = new System.Drawing.Point(151, 107);
            this.TxtQuantiter.Multiline = true;
            this.TxtQuantiter.Name = "TxtQuantiter";
            this.TxtQuantiter.Size = new System.Drawing.Size(58, 26);
            this.TxtQuantiter.TabIndex = 11;
            // 
            // NomProduct
            // 
            this.NomProduct.AutoSize = true;
            this.NomProduct.Location = new System.Drawing.Point(18, 23);
            this.NomProduct.Name = "NomProduct";
            this.NomProduct.Size = new System.Drawing.Size(80, 13);
            this.NomProduct.TabIndex = 12;
            this.NomProduct.Text = "Nom de Produit";
            // 
            // StatueProduct
            // 
            this.StatueProduct.AutoSize = true;
            this.StatueProduct.Location = new System.Drawing.Point(24, 79);
            this.StatueProduct.Name = "StatueProduct";
            this.StatueProduct.Size = new System.Drawing.Size(39, 13);
            this.StatueProduct.TabIndex = 13;
            this.StatueProduct.Text = "Statue";
            // 
            // LbQuantiter
            // 
            this.LbQuantiter.AutoSize = true;
            this.LbQuantiter.Location = new System.Drawing.Point(92, 116);
            this.LbQuantiter.Name = "LbQuantiter";
            this.LbQuantiter.Size = new System.Drawing.Size(53, 13);
            this.LbQuantiter.TabIndex = 13;
            this.LbQuantiter.Text = "Quantiter";
            // 
            // Nam
            // 
            this.Nam.FieldName = "Nom De produit";
            this.Nam.Name = "Nam";
            this.Nam.Visible = true;
            this.Nam.VisibleIndex = 0;
            // 
            // ProductState
            // 
            this.ProductState.FieldName = "Etat de produit";
            this.ProductState.Name = "ProductState";
            this.ProductState.Visible = true;
            this.ProductState.VisibleIndex = 1;
            // 
            // ProductPrice
            // 
            this.ProductPrice.FieldName = "Prix de produit";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Visible = true;
            this.ProductPrice.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Statue de produit";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "Prix de produit";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // Quantity
            // 
            this.Quantity.FieldName = "Quantité de produit";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 5;
            // 
            // OrderDate
            // 
            this.OrderDate.FieldName = "Date de Commande";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Visible = true;
            this.OrderDate.VisibleIndex = 6;
            // 
            // FrmNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 600);
            this.Controls.Add(this.ClientGroup);
            this.Controls.Add(this.TxtNumCommande);
            this.Controls.Add(this.CbProduit);
            this.Controls.Add(this.LbNumCommand);
            this.Controls.Add(this.ProductGroup);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.CbClient);
            this.Controls.Add(this.LbProduit);
            this.Controls.Add(this.LbClien);
            this.Controls.Add(this.RibCommand);
            this.Name = "FrmNewOrder";
            this.Ribbon = this.RibCommand;
            ((System.ComponentModel.ISupportInitialize)(this.RibCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvOrders)).EndInit();
            this.ProductGroup.ResumeLayout(false);
            this.ProductGroup.PerformLayout();
            this.ClientGroup.ResumeLayout(false);
            this.ClientGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbClien;
        private System.Windows.Forms.Label LbProduit;
        private System.Windows.Forms.Label LbStockProduit;
        private System.Windows.Forms.ComboBox CbClient;
        private System.Windows.Forms.ComboBox CbProduit;
        private System.Windows.Forms.TextBox TxtClientName;
        private System.Windows.Forms.TextBox TxtProduitName;
        private System.Windows.Forms.TextBox TxtStockPeoduit;
        private System.Windows.Forms.ComboBox CbStatueProduit;
        private System.Windows.Forms.TextBox TxtEtatProduit;
        private System.Windows.Forms.TextBox TxtPrixProduit;
        private System.Windows.Forms.Label LbPrixProduit;
        private System.Windows.Forms.TextBox TxtNumCommande;
        private System.Windows.Forms.Label LbNumCommand;
        private System.Windows.Forms.Label LbEtatProduit;
        private System.Windows.Forms.DateTimePicker DtpCommande;
        private DevExpress.XtraBars.Ribbon.RibbonControl RibCommand;
        private DevExpress.XtraBars.Ribbon.RibbonPage RibNewCommand;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Commande;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraGrid.GridControl Orders;
        private DevExpress.XtraGrid.Views.Grid.GridView GvOrders;
        private System.Windows.Forms.GroupBox ProductGroup;
        private System.Windows.Forms.GroupBox ClientGroup;
        private System.Windows.Forms.Label LbClientNum;
        private System.Windows.Forms.Label LbPrenomClient;
        private System.Windows.Forms.Label LbClientNom;
        private System.Windows.Forms.TextBox TxtClientPrenom;
        private System.Windows.Forms.TextBox TxtClientNumber;
        private DevExpress.XtraBars.BarButtonItem BtSave;
        private DevExpress.XtraBars.BarButtonItem BTClose;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn Nam;
        private DevExpress.XtraGrid.Columns.GridColumn ProductState;
        private DevExpress.XtraGrid.Columns.GridColumn ProductPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn OrderDate;
        private System.Windows.Forms.Label LbQuantiter;
        private System.Windows.Forms.Label StatueProduct;
        private System.Windows.Forms.Label NomProduct;
        private System.Windows.Forms.TextBox TxtQuantiter;
    }
}