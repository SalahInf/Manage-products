namespace data_save.SousFormes
{
    partial class DeClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeClientForm));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LBnom = new System.Windows.Forms.Label();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtTele = new System.Windows.Forms.TextBox();
            this.TxtAdresse = new System.Windows.Forms.TextBox();
            this.LBprenom = new System.Windows.Forms.Label();
            this.LBtele = new System.Windows.Forms.Label();
            this.LBadresse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose,
            this.barButtonItem1});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 1;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(523, 143);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Sauvgarder";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Save And Close";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Save And New";
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            // 
            // bbiReset
            // 
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReset_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Fermer";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Aficher les donner";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(68, 159);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(147, 27);
            this.TxtName.TabIndex = 3;
            // 
            // LBnom
            // 
            this.LBnom.AutoSize = true;
            this.LBnom.Location = new System.Drawing.Point(27, 162);
            this.LBnom.Name = "LBnom";
            this.LBnom.Size = new System.Drawing.Size(28, 13);
            this.LBnom.TabIndex = 4;
            this.LBnom.Text = "Nom";
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(68, 221);
            this.TxtPrenom.Multiline = true;
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(147, 39);
            this.TxtPrenom.TabIndex = 5;
            // 
            // TxtTele
            // 
            this.TxtTele.Location = new System.Drawing.Point(68, 286);
            this.TxtTele.Multiline = true;
            this.TxtTele.Name = "TxtTele";
            this.TxtTele.Size = new System.Drawing.Size(147, 39);
            this.TxtTele.TabIndex = 6;
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.Location = new System.Drawing.Point(303, 198);
            this.TxtAdresse.Multiline = true;
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.Size = new System.Drawing.Size(194, 82);
            this.TxtAdresse.TabIndex = 7;
            // 
            // LBprenom
            // 
            this.LBprenom.AutoSize = true;
            this.LBprenom.Location = new System.Drawing.Point(19, 221);
            this.LBprenom.Name = "LBprenom";
            this.LBprenom.Size = new System.Drawing.Size(43, 13);
            this.LBprenom.TabIndex = 8;
            this.LBprenom.Text = "Prenom";
            // 
            // LBtele
            // 
            this.LBtele.AutoSize = true;
            this.LBtele.Location = new System.Drawing.Point(5, 289);
            this.LBtele.Name = "LBtele";
            this.LBtele.Size = new System.Drawing.Size(57, 13);
            this.LBtele.TabIndex = 9;
            this.LBtele.Text = "Telephone";
            // 
            // LBadresse
            // 
            this.LBadresse.AutoSize = true;
            this.LBadresse.Location = new System.Drawing.Point(251, 201);
            this.LBadresse.Name = "LBadresse";
            this.LBadresse.Size = new System.Drawing.Size(46, 13);
            this.LBadresse.TabIndex = 10;
            this.LBadresse.Text = "Adresse";
            // 
            // DeClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(523, 351);
            this.Controls.Add(this.LBadresse);
            this.Controls.Add(this.LBtele);
            this.Controls.Add(this.LBprenom);
            this.Controls.Add(this.TxtAdresse);
            this.Controls.Add(this.TxtTele);
            this.Controls.Add(this.TxtPrenom);
            this.Controls.Add(this.LBnom);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "DeClientForm";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private System.Windows.Forms.Label LBnom;
        private System.Windows.Forms.Label LBprenom;
        private System.Windows.Forms.Label LBtele;
        private System.Windows.Forms.Label LBadresse;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        public System.Windows.Forms.TextBox TxtName;
        public System.Windows.Forms.TextBox TxtPrenom;
        public System.Windows.Forms.TextBox TxtTele;
        public System.Windows.Forms.TextBox TxtAdresse;
    }
}