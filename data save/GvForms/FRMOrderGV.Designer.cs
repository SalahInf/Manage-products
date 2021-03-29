namespace data_save.GvForms
{
    partial class FRMOrderGV
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
            this.GcOrder = new DevExpress.XtraGrid.GridControl();
            this.GvOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GcOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // GcOrder
            // 
            this.GcOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GcOrder.Location = new System.Drawing.Point(12, 12);
            this.GcOrder.MainView = this.GvOrder;
            this.GcOrder.Name = "GcOrder";
            this.GcOrder.Size = new System.Drawing.Size(776, 426);
            this.GcOrder.TabIndex = 0;
            this.GcOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvOrder});
            // 
            // GvOrder
            // 
            this.GvOrder.GridControl = this.GcOrder;
            this.GvOrder.Name = "GvOrder";
            this.GvOrder.DoubleClick += new System.EventHandler(this.GvOrder_DoubleClick);
            // 
            // FRMOrderGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            //this.Controls.Add(this.GcOrder);
            this.Name = "FRMOrderGV";
            this.Text = "FRMOrderGV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GcOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView GvOrder;
        public DevExpress.XtraGrid.GridControl GcOrder;
    }
}