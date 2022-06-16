﻿namespace ExeCRUDWinForm
{
    partial class DataGridViewTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridViewTransaksi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orange_SupermarketDataSet2 = new ExeCRUDWinForm.Orange_SupermarketDataSet2();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiTableAdapter = new ExeCRUDWinForm.Orange_SupermarketDataSet2TableAdapters.TransaksiTableAdapter();
            this.idTransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKasirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglTransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyPerItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBiayaPerItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahBayarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahKembaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange_SupermarketDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(9, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 285);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransaksiDataGridViewTextBoxColumn,
            this.idKasirDataGridViewTextBoxColumn,
            this.idBarangDataGridViewTextBoxColumn,
            this.tglTransaksiDataGridViewTextBoxColumn,
            this.qtyPerItemDataGridViewTextBoxColumn,
            this.totalBiayaPerItemDataGridViewTextBoxColumn,
            this.totalHargaDataGridViewTextBoxColumn,
            this.jumlahBayarDataGridViewTextBoxColumn,
            this.jumlahKembaliDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transaksiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 227);
            this.dataGridView1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // orange_SupermarketDataSet2
            // 
            this.orange_SupermarketDataSet2.DataSetName = "Orange_SupermarketDataSet2";
            this.orange_SupermarketDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "Transaksi";
            this.transaksiBindingSource.DataSource = this.orange_SupermarketDataSet2;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // idTransaksiDataGridViewTextBoxColumn
            // 
            this.idTransaksiDataGridViewTextBoxColumn.DataPropertyName = "Id_Transaksi";
            this.idTransaksiDataGridViewTextBoxColumn.HeaderText = "Id_Transaksi";
            this.idTransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTransaksiDataGridViewTextBoxColumn.Name = "idTransaksiDataGridViewTextBoxColumn";
            this.idTransaksiDataGridViewTextBoxColumn.Width = 125;
            // 
            // idKasirDataGridViewTextBoxColumn
            // 
            this.idKasirDataGridViewTextBoxColumn.DataPropertyName = "Id_Kasir";
            this.idKasirDataGridViewTextBoxColumn.HeaderText = "Id_Kasir";
            this.idKasirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idKasirDataGridViewTextBoxColumn.Name = "idKasirDataGridViewTextBoxColumn";
            this.idKasirDataGridViewTextBoxColumn.Width = 125;
            // 
            // idBarangDataGridViewTextBoxColumn
            // 
            this.idBarangDataGridViewTextBoxColumn.DataPropertyName = "Id_Barang";
            this.idBarangDataGridViewTextBoxColumn.HeaderText = "Id_Barang";
            this.idBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idBarangDataGridViewTextBoxColumn.Name = "idBarangDataGridViewTextBoxColumn";
            this.idBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // tglTransaksiDataGridViewTextBoxColumn
            // 
            this.tglTransaksiDataGridViewTextBoxColumn.DataPropertyName = "Tgl_Transaksi";
            this.tglTransaksiDataGridViewTextBoxColumn.HeaderText = "Tgl_Transaksi";
            this.tglTransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tglTransaksiDataGridViewTextBoxColumn.Name = "tglTransaksiDataGridViewTextBoxColumn";
            this.tglTransaksiDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtyPerItemDataGridViewTextBoxColumn
            // 
            this.qtyPerItemDataGridViewTextBoxColumn.DataPropertyName = "Qty_PerItem";
            this.qtyPerItemDataGridViewTextBoxColumn.HeaderText = "Qty_PerItem";
            this.qtyPerItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyPerItemDataGridViewTextBoxColumn.Name = "qtyPerItemDataGridViewTextBoxColumn";
            this.qtyPerItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalBiayaPerItemDataGridViewTextBoxColumn
            // 
            this.totalBiayaPerItemDataGridViewTextBoxColumn.DataPropertyName = "Total_BiayaPerItem";
            this.totalBiayaPerItemDataGridViewTextBoxColumn.HeaderText = "Total_BiayaPerItem";
            this.totalBiayaPerItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalBiayaPerItemDataGridViewTextBoxColumn.Name = "totalBiayaPerItemDataGridViewTextBoxColumn";
            this.totalBiayaPerItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalHargaDataGridViewTextBoxColumn
            // 
            this.totalHargaDataGridViewTextBoxColumn.DataPropertyName = "Total_Harga";
            this.totalHargaDataGridViewTextBoxColumn.HeaderText = "Total_Harga";
            this.totalHargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalHargaDataGridViewTextBoxColumn.Name = "totalHargaDataGridViewTextBoxColumn";
            this.totalHargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahBayarDataGridViewTextBoxColumn
            // 
            this.jumlahBayarDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_Bayar";
            this.jumlahBayarDataGridViewTextBoxColumn.HeaderText = "Jumlah_Bayar";
            this.jumlahBayarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahBayarDataGridViewTextBoxColumn.Name = "jumlahBayarDataGridViewTextBoxColumn";
            this.jumlahBayarDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahKembaliDataGridViewTextBoxColumn
            // 
            this.jumlahKembaliDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_Kembali";
            this.jumlahKembaliDataGridViewTextBoxColumn.HeaderText = "Jumlah_Kembali";
            this.jumlahKembaliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahKembaliDataGridViewTextBoxColumn.Name = "jumlahKembaliDataGridViewTextBoxColumn";
            this.jumlahKembaliDataGridViewTextBoxColumn.Width = 125;
            // 
            // DataGridViewTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DataGridViewTransaksi";
            this.Text = "DataGridViewTransaksi";
            this.Load += new System.EventHandler(this.DataGridViewTransaksi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange_SupermarketDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Orange_SupermarketDataSet2 orange_SupermarketDataSet2;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private Orange_SupermarketDataSet2TableAdapters.TransaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKasirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglTransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyPerItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBiayaPerItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahBayarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahKembaliDataGridViewTextBoxColumn;
    }
}