namespace data_save
{
    partial class Selling_Form
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
            this.ProductGridview = new System.Windows.Forms.DataGridView();
            this.Ordergridvew = new System.Windows.Forms.DataGridView();
            this.Productes_lab = new System.Windows.Forms.Label();
            this.Orders_lab = new System.Windows.Forms.Label();
            this.clients_lab = new System.Windows.Forms.Label();
            this.ClientInf_Box = new System.Windows.Forms.TextBox();
            this.ProductInf_Box = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SelectedClnt = new System.Windows.Forms.Label();
            this.Produitsel = new System.Windows.Forms.Label();
            this.Sell = new System.Windows.Forms.Button();
            this.productinf_Grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientinf_Grid = new System.Windows.Forms.DataGridView();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.connectionDataSet3 = new data_save.connectionDataSet3();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_1TableAdapter = new data_save.connectionDataSet3TableAdapters.Table_1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ordergridvew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productinf_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientinf_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductGridview
            // 
            this.ProductGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridview.Location = new System.Drawing.Point(27, 233);
            this.ProductGridview.Name = "ProductGridview";
            this.ProductGridview.Size = new System.Drawing.Size(308, 205);
            this.ProductGridview.TabIndex = 1;
            this.ProductGridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridview_CellDoubleClick);
            // 
            // Ordergridvew
            // 
            this.Ordergridvew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ordergridvew.Location = new System.Drawing.Point(448, 233);
            this.Ordergridvew.Name = "Ordergridvew";
            this.Ordergridvew.Size = new System.Drawing.Size(320, 205);
            this.Ordergridvew.TabIndex = 2;
            this.Ordergridvew.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ordergridvew_CellDoubleClick);
            // 
            // Productes_lab
            // 
            this.Productes_lab.AutoSize = true;
            this.Productes_lab.Location = new System.Drawing.Point(24, 217);
            this.Productes_lab.Name = "Productes_lab";
            this.Productes_lab.Size = new System.Drawing.Size(55, 13);
            this.Productes_lab.TabIndex = 6;
            this.Productes_lab.Text = "Productes";
            // 
            // Orders_lab
            // 
            this.Orders_lab.AutoSize = true;
            this.Orders_lab.Location = new System.Drawing.Point(454, 217);
            this.Orders_lab.Name = "Orders_lab";
            this.Orders_lab.Size = new System.Drawing.Size(38, 13);
            this.Orders_lab.TabIndex = 7;
            this.Orders_lab.Text = "Orders";
            // 
            // clients_lab
            // 
            this.clients_lab.AutoSize = true;
            this.clients_lab.Location = new System.Drawing.Point(32, 105);
            this.clients_lab.Name = "clients_lab";
            this.clients_lab.Size = new System.Drawing.Size(38, 13);
            this.clients_lab.TabIndex = 8;
            this.clients_lab.Text = "Clients";
            // 
            // ClientInf_Box
            // 
            this.ClientInf_Box.Location = new System.Drawing.Point(93, 30);
            this.ClientInf_Box.Multiline = true;
            this.ClientInf_Box.Name = "ClientInf_Box";
            this.ClientInf_Box.ReadOnly = true;
            this.ClientInf_Box.Size = new System.Drawing.Size(178, 38);
            this.ClientInf_Box.TabIndex = 9;
            // 
            // ProductInf_Box
            // 
            this.ProductInf_Box.Location = new System.Drawing.Point(293, 30);
            this.ProductInf_Box.Multiline = true;
            this.ProductInf_Box.Name = "ProductInf_Box";
            this.ProductInf_Box.ReadOnly = true;
            this.ProductInf_Box.Size = new System.Drawing.Size(178, 38);
            this.ProductInf_Box.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(513, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // SelectedClnt
            // 
            this.SelectedClnt.AutoSize = true;
            this.SelectedClnt.Location = new System.Drawing.Point(90, 9);
            this.SelectedClnt.Name = "SelectedClnt";
            this.SelectedClnt.Size = new System.Drawing.Size(87, 13);
            this.SelectedClnt.TabIndex = 12;
            this.SelectedClnt.Text = "Client selectioner";
            // 
            // Produitsel
            // 
            this.Produitsel.AutoSize = true;
            this.Produitsel.Location = new System.Drawing.Point(293, 9);
            this.Produitsel.Name = "Produitsel";
            this.Produitsel.Size = new System.Drawing.Size(98, 17);
            this.Produitsel.TabIndex = 13;
            this.Produitsel.Text = "Produit selectioner";
            this.Produitsel.UseCompatibleTextRendering = true;
            // 
            // Sell
            // 
            this.Sell.Location = new System.Drawing.Point(341, 322);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(88, 40);
            this.Sell.TabIndex = 14;
            this.Sell.Text = "Confirme";
            this.Sell.UseVisualStyleBackColor = true;
            this.Sell.Click += new System.EventHandler(this.Sell_Click);
            // 
            // productinf_Grid
            // 
            this.productinf_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productinf_Grid.Location = new System.Drawing.Point(426, 148);
            this.productinf_Grid.Name = "productinf_Grid";
            this.productinf_Grid.Size = new System.Drawing.Size(362, 66);
            this.productinf_Grid.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ClientInfo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "ProductInfo";
            // 
            // clientinf_Grid
            // 
            this.clientinf_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientinf_Grid.Location = new System.Drawing.Point(426, 79);
            this.clientinf_Grid.Name = "clientinf_Grid";
            this.clientinf_Grid.Size = new System.Drawing.Size(362, 63);
            this.clientinf_Grid.TabIndex = 16;
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(35, 121);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(182, 21);
            this.cbClient.TabIndex = 22;
            this.cbClient.SelectedIndexChanged += new System.EventHandler(this.cbClient_SelectedIndexChanged);
            // 
            // connectionDataSet3
            // 
            this.connectionDataSet3.DataSetName = "connectionDataSet3";
            this.connectionDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.connectionDataSet3;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // Selling_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientinf_Grid);
            this.Controls.Add(this.productinf_Grid);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.Produitsel);
            this.Controls.Add(this.SelectedClnt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ProductInf_Box);
            this.Controls.Add(this.ClientInf_Box);
            this.Controls.Add(this.clients_lab);
            this.Controls.Add(this.Orders_lab);
            this.Controls.Add(this.Productes_lab);
            this.Controls.Add(this.Ordergridvew);
            this.Controls.Add(this.ProductGridview);
            this.Name = "Selling_Form";
            this.Text = "SellingRoom";
            this.Load += new System.EventHandler(this.SellingRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ordergridvew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productinf_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientinf_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ProductGridview;
        private System.Windows.Forms.DataGridView Ordergridvew;
        private connectionDataSet3 connectionDataSet3;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private connectionDataSet3TableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.Label Productes_lab;
        private System.Windows.Forms.Label Orders_lab;
        private System.Windows.Forms.Label clients_lab;
        private System.Windows.Forms.TextBox ClientInf_Box;
        private System.Windows.Forms.TextBox ProductInf_Box;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label SelectedClnt;
        private System.Windows.Forms.Label Produitsel;
        private System.Windows.Forms.Button Sell;
        private System.Windows.Forms.DataGridView productinf_Grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView clientinf_Grid;
        private System.Windows.Forms.ComboBox cbClient;
    }
}