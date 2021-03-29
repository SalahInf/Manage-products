namespace data_save.GvForms
{
    partial class FRMProductGV
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
            this.GCproduct = new DevExpress.XtraGrid.GridControl();
            this.GVprodcut = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GCproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVprodcut)).BeginInit();
            this.SuspendLayout();
            // 
            // GCproduct
            // 
            this.GCproduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GCproduct.Location = new System.Drawing.Point(12, 12);
            this.GCproduct.MainView = this.GVprodcut;
            //this.GCproduct.Name = "GCproduct";
            this.GCproduct.Size = new System.Drawing.Size(776, 426);
            this.GCproduct.TabIndex = 0;
            this.GCproduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVprodcut});
            // 
            // GVprodcut
            // 
            this.GVprodcut.GridControl = this.GCproduct;
            //this.GVprodcut.Name = "GVprodcut";
            this.GVprodcut.DoubleClick += new System.EventHandler(this.GVprodcut_DoubleClick);
            // 
            // FRMProductGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GCproduct);
            //this.Name = "FRMProductGV";
            this.Text = "FRMProductGV";
            ((System.ComponentModel.ISupportInitialize)(this.GCproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVprodcut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl GCproduct;
        public DevExpress.XtraGrid.Views.Grid.GridView GVprodcut;
    }
}