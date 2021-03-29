namespace data_save
{
    partial class Product_Form
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
            this.LabNam = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.ComPEtat = new System.Windows.Forms.ComboBox();
            this.GridViewProduits = new System.Windows.Forms.DataGridView();
            this.ordersDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectionDataSet2 = new data_save.connectionDataSet2();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Reresh = new System.Windows.Forms.Button();
            this.DateP = new System.Windows.Forms.DateTimePicker();
            this.connectionDataSet = new data_save.connectionDataSet();
            this.connectionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_1TableAdapter = new data_save.connectionDataSetTableAdapters.Table_1TableAdapter();
            this.table1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDBTableAdapter = new data_save.connectionDataSet2TableAdapters.OrdersDBTableAdapter();
            this.Selling = new System.Windows.Forms.Button();
            this.ClientForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabNam
            // 
            this.LabNam.AutoSize = true;
            this.LabNam.Location = new System.Drawing.Point(22, 107);
            this.LabNam.Name = "LabNam";
            this.LabNam.Size = new System.Drawing.Size(80, 13);
            this.LabNam.TabIndex = 0;
            this.LabNam.Text = "Nom de Produit";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(22, 24);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(74, 13);
            this.lab.TabIndex = 1;
            this.lab.Text = "Prix de produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Etat De produit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Produit stock";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(119, 99);
            this.txtPName.Multiline = true;
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(155, 35);
            this.txtPName.TabIndex = 4;
            // 
            // txtPPrice
            // 
            this.txtPPrice.Location = new System.Drawing.Point(119, 24);
            this.txtPPrice.Multiline = true;
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.Size = new System.Drawing.Size(155, 37);
            this.txtPPrice.TabIndex = 5;
            this.txtPPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPPrice_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(517, 28);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(66, 37);
            this.txtStock.TabIndex = 7;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // ComPEtat
            // 
            this.ComPEtat.FormattingEnabled = true;
            this.ComPEtat.Items.AddRange(new object[] {
            "Fragile",
            "Solide",
            "Can Be worste"});
            this.ComPEtat.Location = new System.Drawing.Point(462, 71);
            this.ComPEtat.Name = "ComPEtat";
            this.ComPEtat.Size = new System.Drawing.Size(121, 21);
            this.ComPEtat.TabIndex = 9;
            // 
            // GridViewProduits
            // 
            this.GridViewProduits.AllowDrop = true;
            this.GridViewProduits.AllowUserToOrderColumns = true;
            this.GridViewProduits.AllowUserToResizeColumns = false;
            this.GridViewProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewProduits.Location = new System.Drawing.Point(12, 185);
            this.GridViewProduits.Name = "GridViewProduits";
            this.GridViewProduits.Size = new System.Drawing.Size(688, 253);
            this.GridViewProduits.TabIndex = 11;
            this.GridViewProduits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewProduits_CellDoubleClick);
            // 
            // ordersDBBindingSource
            // 
            this.ordersDBBindingSource.DataMember = "OrdersDB";
            this.ordersDBBindingSource.DataSource = this.connectionDataSet2;
            // 
            // connectionDataSet2
            // 
            this.connectionDataSet2.DataSetName = "connectionDataSet2";
            this.connectionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(25, 140);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 39);
            this.Save.TabIndex = 12;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(142, 140);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(97, 39);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(278, 140);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(97, 39);
            this.Update.TabIndex = 14;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Reresh
            // 
            this.Reresh.Location = new System.Drawing.Point(724, 185);
            this.Reresh.Name = "Reresh";
            this.Reresh.Size = new System.Drawing.Size(64, 35);
            this.Reresh.TabIndex = 15;
            this.Reresh.Text = "Refresh";
            this.Reresh.UseVisualStyleBackColor = true;
            this.Reresh.Click += new System.EventHandler(this.Reresh_Click);
            // 
            // DateP
            // 
            this.DateP.Location = new System.Drawing.Point(426, 107);
            this.DateP.Name = "DateP";
            this.DateP.Size = new System.Drawing.Size(157, 20);
            this.DateP.TabIndex = 16;
            // 
            // connectionDataSet
            // 
            this.connectionDataSet.DataSetName = "connectionDataSet";
            this.connectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // connectionDataSetBindingSource
            // 
            this.connectionDataSetBindingSource.DataSource = this.connectionDataSet;
            this.connectionDataSetBindingSource.Position = 0;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.connectionDataSetBindingSource;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // table1BindingSource1
            // 
            this.table1BindingSource1.DataMember = "Table_1";
            this.table1BindingSource1.DataSource = this.connectionDataSetBindingSource;
            // 
            // ordersDBTableAdapter
            // 
            this.ordersDBTableAdapter.ClearBeforeFill = true;
            // 
            // Selling
            // 
            this.Selling.Location = new System.Drawing.Point(685, 38);
            this.Selling.Name = "Selling";
            this.Selling.Size = new System.Drawing.Size(89, 38);
            this.Selling.TabIndex = 17;
            this.Selling.Text = "Sell";
            this.Selling.UseVisualStyleBackColor = true;
            this.Selling.Click += new System.EventHandler(this.Selling_Click);
            // 
            // ClientForm
            // 
            this.ClientForm.Location = new System.Drawing.Point(685, 89);
            this.ClientForm.Name = "ClientForm";
            this.ClientForm.Size = new System.Drawing.Size(89, 38);
            this.ClientForm.TabIndex = 18;
            this.ClientForm.Text = "Client";
            this.ClientForm.UseVisualStyleBackColor = true;
            this.ClientForm.Click += new System.EventHandler(this.ClientForm_Click);
            // 
            // Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientForm);
            this.Controls.Add(this.Selling);
            this.Controls.Add(this.DateP);
            this.Controls.Add(this.Reresh);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.GridViewProduits);
            this.Controls.Add(this.ComPEtat);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPPrice);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.LabNam);
            this.Name = "Product_Form";
            this.Text = "Product_Form";
            this.Load += new System.EventHandler(this.Product_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabNam;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ComboBox ComPEtat;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Reresh;
        private System.Windows.Forms.DateTimePicker DateP;
        private System.Windows.Forms.BindingSource connectionDataSetBindingSource;
        private connectionDataSet connectionDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private connectionDataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.BindingSource table1BindingSource1;
        private connectionDataSet2 connectionDataSet2;
        private System.Windows.Forms.BindingSource ordersDBBindingSource;
        private connectionDataSet2TableAdapters.OrdersDBTableAdapter ordersDBTableAdapter;
        public System.Windows.Forms.DataGridView GridViewProduits;
        private System.Windows.Forms.Button Selling;
        private System.Windows.Forms.Button ClientForm;
    }
}