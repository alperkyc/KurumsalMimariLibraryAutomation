namespace Library.WebFormsUI
{
    partial class KitapIslemleri
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxUpdateRafNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKitapDelete = new System.Windows.Forms.Button();
            this.tbxKitapUpdateId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKitapUpdate = new System.Windows.Forms.Button();
            this.KitapEkleme = new System.Windows.Forms.GroupBox();
            this.tbxKitapAddRafNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxAddKitapCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxAddYazarAdi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKitapAdd = new System.Windows.Forms.Button();
            this.tbxKitapAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwKitapIslemleri = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.KitapEkleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitapIslemleri)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxUpdateRafNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnKitapDelete);
            this.groupBox2.Controls.Add(this.tbxKitapUpdateId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnKitapUpdate);
            this.groupBox2.Location = new System.Drawing.Point(396, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 229);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Güncelleme - Silme";
            // 
            // tbxUpdateRafNo
            // 
            this.tbxUpdateRafNo.Location = new System.Drawing.Point(114, 60);
            this.tbxUpdateRafNo.Name = "tbxUpdateRafNo";
            this.tbxUpdateRafNo.Size = new System.Drawing.Size(156, 22);
            this.tbxUpdateRafNo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Raf No:";
            // 
            // btnKitapDelete
            // 
            this.btnKitapDelete.Location = new System.Drawing.Point(171, 113);
            this.btnKitapDelete.Name = "btnKitapDelete";
            this.btnKitapDelete.Size = new System.Drawing.Size(99, 34);
            this.btnKitapDelete.TabIndex = 5;
            this.btnKitapDelete.Text = "Delete";
            this.btnKitapDelete.UseVisualStyleBackColor = true;
            this.btnKitapDelete.Click += new System.EventHandler(this.btnKitapDelete_Click);
            // 
            // tbxKitapUpdateId
            // 
            this.tbxKitapUpdateId.Enabled = false;
            this.tbxKitapUpdateId.Location = new System.Drawing.Point(114, 27);
            this.tbxKitapUpdateId.Name = "tbxKitapUpdateId";
            this.tbxKitapUpdateId.Size = new System.Drawing.Size(156, 22);
            this.tbxKitapUpdateId.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kitap Id:";
            // 
            // btnKitapUpdate
            // 
            this.btnKitapUpdate.Location = new System.Drawing.Point(51, 113);
            this.btnKitapUpdate.Name = "btnKitapUpdate";
            this.btnKitapUpdate.Size = new System.Drawing.Size(99, 34);
            this.btnKitapUpdate.TabIndex = 2;
            this.btnKitapUpdate.Text = "Update";
            this.btnKitapUpdate.UseVisualStyleBackColor = true;
            this.btnKitapUpdate.Click += new System.EventHandler(this.btnKitapUpdate_Click);
            // 
            // KitapEkleme
            // 
            this.KitapEkleme.Controls.Add(this.tbxKitapAddRafNo);
            this.KitapEkleme.Controls.Add(this.label6);
            this.KitapEkleme.Controls.Add(this.cbxAddKitapCategory);
            this.KitapEkleme.Controls.Add(this.label5);
            this.KitapEkleme.Controls.Add(this.cbxAddYazarAdi);
            this.KitapEkleme.Controls.Add(this.label4);
            this.KitapEkleme.Controls.Add(this.btnKitapAdd);
            this.KitapEkleme.Controls.Add(this.tbxKitapAdd);
            this.KitapEkleme.Controls.Add(this.label1);
            this.KitapEkleme.Location = new System.Drawing.Point(30, 265);
            this.KitapEkleme.Name = "KitapEkleme";
            this.KitapEkleme.Size = new System.Drawing.Size(327, 229);
            this.KitapEkleme.TabIndex = 4;
            this.KitapEkleme.TabStop = false;
            this.KitapEkleme.Text = "Kitap Ekleme";
            // 
            // tbxKitapAddRafNo
            // 
            this.tbxKitapAddRafNo.Location = new System.Drawing.Point(114, 157);
            this.tbxKitapAddRafNo.Name = "tbxKitapAddRafNo";
            this.tbxKitapAddRafNo.Size = new System.Drawing.Size(167, 22);
            this.tbxKitapAddRafNo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Raf No:";
            // 
            // cbxAddKitapCategory
            // 
            this.cbxAddKitapCategory.FormattingEnabled = true;
            this.cbxAddKitapCategory.Location = new System.Drawing.Point(114, 94);
            this.cbxAddKitapCategory.Name = "cbxAddKitapCategory";
            this.cbxAddKitapCategory.Size = new System.Drawing.Size(167, 24);
            this.cbxAddKitapCategory.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kategori:";
            // 
            // cbxAddYazarAdi
            // 
            this.cbxAddYazarAdi.FormattingEnabled = true;
            this.cbxAddYazarAdi.Location = new System.Drawing.Point(114, 127);
            this.cbxAddYazarAdi.Name = "cbxAddYazarAdi";
            this.cbxAddYazarAdi.Size = new System.Drawing.Size(167, 24);
            this.cbxAddYazarAdi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yazar Adı:";
            // 
            // btnKitapAdd
            // 
            this.btnKitapAdd.Location = new System.Drawing.Point(182, 185);
            this.btnKitapAdd.Name = "btnKitapAdd";
            this.btnKitapAdd.Size = new System.Drawing.Size(99, 34);
            this.btnKitapAdd.TabIndex = 2;
            this.btnKitapAdd.Text = "Add";
            this.btnKitapAdd.UseVisualStyleBackColor = true;
            this.btnKitapAdd.Click += new System.EventHandler(this.btnKitapAdd_Click);
            // 
            // tbxKitapAdd
            // 
            this.tbxKitapAdd.Location = new System.Drawing.Point(114, 55);
            this.tbxKitapAdd.Name = "tbxKitapAdd";
            this.tbxKitapAdd.Size = new System.Drawing.Size(167, 22);
            this.tbxKitapAdd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // dgwKitapIslemleri
            // 
            this.dgwKitapIslemleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKitapIslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKitapIslemleri.Location = new System.Drawing.Point(30, 28);
            this.dgwKitapIslemleri.Name = "dgwKitapIslemleri";
            this.dgwKitapIslemleri.RowTemplate.Height = 24;
            this.dgwKitapIslemleri.Size = new System.Drawing.Size(756, 204);
            this.dgwKitapIslemleri.TabIndex = 3;
            this.dgwKitapIslemleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKitapIslemleri_CellClick);
            // 
            // KitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.KitapEkleme);
            this.Controls.Add(this.dgwKitapIslemleri);
            this.Name = "KitapIslemleri";
            this.Text = "KitapIslemleri";
            this.Load += new System.EventHandler(this.KitapIslemleri_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.KitapEkleme.ResumeLayout(false);
            this.KitapEkleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitapIslemleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKitapDelete;
        private System.Windows.Forms.TextBox tbxKitapUpdateId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKitapUpdate;
        private System.Windows.Forms.GroupBox KitapEkleme;
        private System.Windows.Forms.ComboBox cbxAddKitapCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxAddYazarAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKitapAdd;
        private System.Windows.Forms.TextBox tbxKitapAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwKitapIslemleri;
        private System.Windows.Forms.TextBox tbxUpdateRafNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxKitapAddRafNo;
        private System.Windows.Forms.Label label6;
    }
}