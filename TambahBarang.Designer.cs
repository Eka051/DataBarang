namespace DataBarang
{
    partial class TambahBarang
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
            simpanBarang = new Button();
            NamaBarang = new TextBox();
            HargaBarang = new TextBox();
            jenisBarang = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // simpanBarang
            // 
            simpanBarang.Location = new Point(315, 409);
            simpanBarang.Name = "simpanBarang";
            simpanBarang.Size = new Size(168, 53);
            simpanBarang.TabIndex = 0;
            simpanBarang.Text = "SIMPAN";
            simpanBarang.UseVisualStyleBackColor = true;
            simpanBarang.Click += simpanBarang_Click;
            // 
            // NamaBarang
            // 
            NamaBarang.Location = new Point(268, 134);
            NamaBarang.Name = "NamaBarang";
            NamaBarang.Size = new Size(276, 23);
            NamaBarang.TabIndex = 1;
            // 
            // HargaBarang
            // 
            HargaBarang.Location = new Point(268, 205);
            HargaBarang.Name = "HargaBarang";
            HargaBarang.Size = new Size(276, 23);
            HargaBarang.TabIndex = 2;
            // 
            // jenisBarang
            // 
            jenisBarang.Location = new Point(268, 288);
            jenisBarang.Multiline = true;
            jenisBarang.Name = "jenisBarang";
            jenisBarang.Size = new Size(276, 23);
            jenisBarang.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 134);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 4;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(193, 205);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 5;
            label2.Text = "Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(137, 288);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 6;
            label3.Text = "Jenis Barang";
            // 
            // TambahBarang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 569);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(jenisBarang);
            Controls.Add(HargaBarang);
            Controls.Add(NamaBarang);
            Controls.Add(simpanBarang);
            Name = "TambahBarang";
            Text = "TambahBarang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button simpanBarang;
        private TextBox NamaBarang;
        private TextBox HargaBarang;
        private TextBox jenisBarang;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}