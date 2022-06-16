namespace ExeCRUDWinForm
{
    partial class DataGridViewKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridViewKasir));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orange_SupermarketDataSet1 = new ExeCRUDWinForm.Orange_SupermarketDataSet1();
            this.kasirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kasirTableAdapter = new ExeCRUDWinForm.Orange_SupermarketDataSet1TableAdapters.KasirTableAdapter();
            this.idKasirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKasirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange_SupermarketDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKasirDataGridViewTextBoxColumn,
            this.namaKasirDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kasirBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(306, 256);
            this.dataGridView1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // orange_SupermarketDataSet1
            // 
            this.orange_SupermarketDataSet1.DataSetName = "Orange_SupermarketDataSet1";
            this.orange_SupermarketDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasirBindingSource
            // 
            this.kasirBindingSource.DataMember = "Kasir";
            this.kasirBindingSource.DataSource = this.orange_SupermarketDataSet1;
            // 
            // kasirTableAdapter
            // 
            this.kasirTableAdapter.ClearBeforeFill = true;
            // 
            // idKasirDataGridViewTextBoxColumn
            // 
            this.idKasirDataGridViewTextBoxColumn.DataPropertyName = "Id_Kasir";
            this.idKasirDataGridViewTextBoxColumn.HeaderText = "Id_Kasir";
            this.idKasirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idKasirDataGridViewTextBoxColumn.Name = "idKasirDataGridViewTextBoxColumn";
            this.idKasirDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaKasirDataGridViewTextBoxColumn
            // 
            this.namaKasirDataGridViewTextBoxColumn.DataPropertyName = "Nama_Kasir";
            this.namaKasirDataGridViewTextBoxColumn.HeaderText = "Nama_Kasir";
            this.namaKasirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaKasirDataGridViewTextBoxColumn.Name = "namaKasirDataGridViewTextBoxColumn";
            this.namaKasirDataGridViewTextBoxColumn.Width = 125;
            // 
            // DataGridViewKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DataGridViewKasir";
            this.Text = "DataGridViewKasir";
            this.Load += new System.EventHandler(this.DataGridViewKasir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange_SupermarketDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasirBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Orange_SupermarketDataSet1 orange_SupermarketDataSet1;
        private System.Windows.Forms.BindingSource kasirBindingSource;
        private Orange_SupermarketDataSet1TableAdapters.KasirTableAdapter kasirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKasirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKasirDataGridViewTextBoxColumn;
    }
}