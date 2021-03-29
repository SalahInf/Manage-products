namespace data_save.DevExpFormes
{
    partial class FrmMainMenuTest
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualiserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualiserToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichClientToolStripMenuItem,
            this.fichProduitToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichClientToolStripMenuItem
            // 
            this.fichClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauClientToolStripMenuItem,
            this.actualiserToolStripMenuItem1});
            this.fichClientToolStripMenuItem.Name = "fichClientToolStripMenuItem";
            this.fichClientToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.fichClientToolStripMenuItem.Text = "Fiche Client";
            this.fichClientToolStripMenuItem.Click += new System.EventHandler(this.fichClientToolStripMenuItem_Click);
            // 
            // fichProduitToolStripMenuItem
            // 
            this.fichProduitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauProduitToolStripMenuItem,
            this.actualiserToolStripMenuItem});
            this.fichProduitToolStripMenuItem.Name = "fichProduitToolStripMenuItem";
            this.fichProduitToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.fichProduitToolStripMenuItem.Text = "Fiche Produit";
            this.fichProduitToolStripMenuItem.Click += new System.EventHandler(this.fichProduitToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauOrderToolStripMenuItem,
            this.actualiserToolStripMenuItem2});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // nouveauClientToolStripMenuItem
            // 
            this.nouveauClientToolStripMenuItem.Name = "nouveauClientToolStripMenuItem";
            this.nouveauClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouveauClientToolStripMenuItem.Text = "Nouveau Client";
            this.nouveauClientToolStripMenuItem.Click += new System.EventHandler(this.nouveauClientToolStripMenuItem_Click);
            // 
            // nouveauProduitToolStripMenuItem
            // 
            this.nouveauProduitToolStripMenuItem.Name = "nouveauProduitToolStripMenuItem";
            this.nouveauProduitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouveauProduitToolStripMenuItem.Text = "Nouveau Produit";
            this.nouveauProduitToolStripMenuItem.Click += new System.EventHandler(this.nouveauProduitToolStripMenuItem_Click);
            // 
            // nouveauOrderToolStripMenuItem
            // 
            this.nouveauOrderToolStripMenuItem.Name = "nouveauOrderToolStripMenuItem";
            this.nouveauOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouveauOrderToolStripMenuItem.Text = "Nouveau Order";
            // 
            // actualiserToolStripMenuItem
            // 
            this.actualiserToolStripMenuItem.Name = "actualiserToolStripMenuItem";
            this.actualiserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualiserToolStripMenuItem.Text = "Actualiser";
            // 
            // actualiserToolStripMenuItem1
            // 
            this.actualiserToolStripMenuItem1.Name = "actualiserToolStripMenuItem1";
            this.actualiserToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.actualiserToolStripMenuItem1.Text = "Actualiser";
            // 
            // actualiserToolStripMenuItem2
            // 
            this.actualiserToolStripMenuItem2.Name = "actualiserToolStripMenuItem2";
            this.actualiserToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.actualiserToolStripMenuItem2.Text = "Actualiser";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMainMenu";
            this.Text = "FrmMainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem2;
    }
}