namespace Library.WebFormsUI
{
    partial class Form1
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
            this.dgwKitaps = new System.Windows.Forms.DataGridView();
            this.gbxSearchByCategory = new System.Windows.Forms.GroupBox();
            this.btnAllCategory = new System.Windows.Forms.Button();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKitapIslemler = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitaps)).BeginInit();
            this.gbxSearchByCategory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwKitaps
            // 
            this.dgwKitaps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKitaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKitaps.Location = new System.Drawing.Point(12, 179);
            this.dgwKitaps.Name = "dgwKitaps";
            this.dgwKitaps.RowTemplate.Height = 24;
            this.dgwKitaps.Size = new System.Drawing.Size(957, 358);
            this.dgwKitaps.TabIndex = 0;
            // 
            // gbxSearchByCategory
            // 
            this.gbxSearchByCategory.Controls.Add(this.btnAllCategory);
            this.gbxSearchByCategory.Controls.Add(this.cbxCategory);
            this.gbxSearchByCategory.Controls.Add(this.label1);
            this.gbxSearchByCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxSearchByCategory.Name = "gbxSearchByCategory";
            this.gbxSearchByCategory.Size = new System.Drawing.Size(258, 130);
            this.gbxSearchByCategory.TabIndex = 1;
            this.gbxSearchByCategory.TabStop = false;
            this.gbxSearchByCategory.Text = "Kitap Türüne Göre Ara";
            // 
            // btnAllCategory
            // 
            this.btnAllCategory.Location = new System.Drawing.Point(96, 83);
            this.btnAllCategory.Name = "btnAllCategory";
            this.btnAllCategory.Size = new System.Drawing.Size(126, 32);
            this.btnAllCategory.TabIndex = 3;
            this.btnAllCategory.Text = "Tüm Kategoriler";
            this.btnAllCategory.UseVisualStyleBackColor = true;
            this.btnAllCategory.Click += new System.EventHandler(this.btnAllCategory_Click);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(86, 35);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(166, 24);
            this.cbxCategory.TabIndex = 2;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(326, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Adına Göre Ara";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(89, 35);
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(163, 24);
            this.txtKitapAdi.TabIndex = 3;
            this.txtKitapAdi.TextChanged += new System.EventHandler(this.txtKitapAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKitapIslemler);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(657, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 142);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btnKitapIslemler
            // 
            this.btnKitapIslemler.Location = new System.Drawing.Point(49, 97);
            this.btnKitapIslemler.Name = "btnKitapIslemler";
            this.btnKitapIslemler.Size = new System.Drawing.Size(152, 33);
            this.btnKitapIslemler.TabIndex = 2;
            this.btnKitapIslemler.Text = "Kategori İşlemleri";
            this.btnKitapIslemler.UseVisualStyleBackColor = true;
            this.btnKitapIslemler.Click += new System.EventHandler(this.btnKitapIslemler_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Yazar İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kitap İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(981, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxSearchByCategory);
            this.Controls.Add(this.dgwKitaps);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitaps)).EndInit();
            this.gbxSearchByCategory.ResumeLayout(false);
            this.gbxSearchByCategory.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKitaps;
        private System.Windows.Forms.GroupBox gbxSearchByCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKitapIslemler;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAllCategory;
    }
}

