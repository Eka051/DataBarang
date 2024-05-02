namespace DataBarang
{
    partial class DataBarang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataProdukView = new DataGridView();
            tmbBarang = new Button();
            ((System.ComponentModel.ISupportInitialize)dataProdukView).BeginInit();
            SuspendLayout();
            // 
            // dataProdukView
            // 
            dataProdukView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProdukView.Location = new Point(6, 164);
            dataProdukView.Name = "dataProdukView";
            dataProdukView.Size = new Size(1280, 539);
            dataProdukView.TabIndex = 0;
            // 
            // tmbBarang
            // 
            tmbBarang.BackColor = Color.Coral;
            tmbBarang.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tmbBarang.Location = new Point(1041, 70);
            tmbBarang.Name = "tmbBarang";
            tmbBarang.Size = new Size(223, 62);
            tmbBarang.TabIndex = 1;
            tmbBarang.Text = "Tambah Barang";
            tmbBarang.UseVisualStyleBackColor = false;
            tmbBarang.Click += tmbBarang_Click;
            // 
            // DataBarang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 715);
            Controls.Add(tmbBarang);
            Controls.Add(dataProdukView);
            Name = "DataBarang";
            Text = "List Data Barang";
            ((System.ComponentModel.ISupportInitialize)dataProdukView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataProdukView;
        private Button tmbBarang;
    }
}
