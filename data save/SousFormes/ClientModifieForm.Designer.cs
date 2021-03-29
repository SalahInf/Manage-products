namespace data_save.SousFormes
{
    partial class ClientModifieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientModifieForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BTsave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtNumPhone = new System.Windows.Forms.TextBox();
            this.TxtAddresse = new System.Windows.Forms.TextBox();
            this.TxtLasteName = new System.Windows.Forms.TextBox();
            this.LBName = new System.Windows.Forms.Label();
            this.LBadresse = new System.Windows.Forms.Label();
            this.LbNumberphone = new System.Windows.Forms.Label();
            this.LBPrenom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BTsave,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(544, 141);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // BTsave
            // 
            this.BTsave.Caption = "Sauvgarder";
            this.BTsave.Id = 1;
            this.BTsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTsave.ImageOptions.Image")));
            this.BTsave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTsave.ImageOptions.LargeImage")));
            this.BTsave.Name = "BTsave";
            this.BTsave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Fermer";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Aficher ";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BTsave);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // TxtName
            // 
            this.TxtName.AllowDrop = true;
            this.TxtName.Location = new System.Drawing.Point(83, 224);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(114, 38);
            this.TxtName.TabIndex = 1;
            // 
            // TxtNumPhone
            // 
            this.TxtNumPhone.Location = new System.Drawing.Point(333, 224);
            this.TxtNumPhone.Multiline = true;
            this.TxtNumPhone.Name = "TxtNumPhone";
            this.TxtNumPhone.Size = new System.Drawing.Size(114, 38);
            this.TxtNumPhone.TabIndex = 2;
            // 
            // TxtAddresse
            // 
            this.TxtAddresse.Location = new System.Drawing.Point(333, 311);
            this.TxtAddresse.Multiline = true;
            this.TxtAddresse.Name = "TxtAddresse";
            this.TxtAddresse.Size = new System.Drawing.Size(164, 61);
            this.TxtAddresse.TabIndex = 3;
            // 
            // TxtLasteName
            // 
            this.TxtLasteName.Location = new System.Drawing.Point(83, 308);
            this.TxtLasteName.Multiline = true;
            this.TxtLasteName.Name = "TxtLasteName";
            this.TxtLasteName.Size = new System.Drawing.Size(114, 38);
            this.TxtLasteName.TabIndex = 4;
            // 
            // LBName
            // 
            this.LBName.AutoSize = true;
            this.LBName.Location = new System.Drawing.Point(30, 227);
            this.LBName.Name = "LBName";
            this.LBName.Size = new System.Drawing.Size(35, 13);
            this.LBName.TabIndex = 7;
            this.LBName.Text = "Name";
            // 
            // LBadresse
            // 
            this.LBadresse.AutoSize = true;
            this.LBadresse.Location = new System.Drawing.Point(282, 311);
            this.LBadresse.Name = "LBadresse";
            this.LBadresse.Size = new System.Drawing.Size(45, 13);
            this.LBadresse.TabIndex = 8;
            this.LBadresse.Text = "Adresse";
            // 
            // LbNumberphone
            // 
            this.LbNumberphone.AutoSize = true;
            this.LbNumberphone.Location = new System.Drawing.Point(233, 227);
            this.LbNumberphone.Name = "LbNumberphone";
            this.LbNumberphone.Size = new System.Drawing.Size(94, 13);
            this.LbNumberphone.TabIndex = 9;
            this.LbNumberphone.Text = "Numero telephone";
            // 
            // LBPrenom
            // 
            this.LBPrenom.AutoSize = true;
            this.LBPrenom.Location = new System.Drawing.Point(30, 308);
            this.LBPrenom.Name = "LBPrenom";
            this.LBPrenom.Size = new System.Drawing.Size(43, 13);
            this.LBPrenom.TabIndex = 10;
            this.LBPrenom.Text = "Prenom";
            // 
            // ClientModifieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 402);
            this.Controls.Add(this.LBPrenom);
            this.Controls.Add(this.LbNumberphone);
            this.Controls.Add(this.LBadresse);
            this.Controls.Add(this.LBName);
            this.Controls.Add(this.TxtLasteName);
            this.Controls.Add(this.TxtAddresse);
            this.Controls.Add(this.TxtNumPhone);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ClientModifieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientModifieForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BTsave;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.Label LBName;
        private System.Windows.Forms.Label LBadresse;
        private System.Windows.Forms.Label LbNumberphone;
        private System.Windows.Forms.Label LBPrenom;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        public System.Windows.Forms.TextBox TxtName;
        public System.Windows.Forms.TextBox TxtNumPhone;
        public System.Windows.Forms.TextBox TxtAddresse;
        public System.Windows.Forms.TextBox TxtLasteName;
    }
}