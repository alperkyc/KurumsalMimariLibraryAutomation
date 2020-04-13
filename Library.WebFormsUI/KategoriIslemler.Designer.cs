namespace Library.WebFormsUI
{
    partial class KategoriIslemler
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
            this.dgwCategory = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.tbxCategoryAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxCategoryDelete = new System.Windows.Forms.Button();
            this.tbxCategory2Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.tbxCategory2Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCategory
            // 
            this.dgwCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCategory.Location = new System.Drawing.Point(12, 12);
            this.dgwCategory.Name = "dgwCategory";
            this.dgwCategory.RowTemplate.Height = 24;
            this.dgwCategory.Size = new System.Drawing.Size(761, 204);
            this.dgwCategory.TabIndex = 0;
            this.dgwCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCategory_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCategoryAdd);
            this.groupBox1.Controls.Add(this.tbxCategoryAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Ekleme";
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(137, 97);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(99, 34);
            this.btnCategoryAdd.TabIndex = 2;
            this.btnCategoryAdd.Text = "Add";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // tbxCategoryAdd
            // 
            this.tbxCategoryAdd.Location = new System.Drawing.Point(114, 55);
            this.tbxCategoryAdd.Name = "tbxCategoryAdd";
            this.tbxCategoryAdd.Size = new System.Drawing.Size(145, 22);
            this.tbxCategoryAdd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxCategoryDelete);
            this.groupBox2.Controls.Add(this.tbxCategory2Id);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCategoryUpdate);
            this.groupBox2.Controls.Add(this.tbxCategory2Name);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(378, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategori Güncelleme - Silme";
            // 
            // tbxCategoryDelete
            // 
            this.tbxCategoryDelete.Location = new System.Drawing.Point(160, 97);
            this.tbxCategoryDelete.Name = "tbxCategoryDelete";
            this.tbxCategoryDelete.Size = new System.Drawing.Size(99, 34);
            this.tbxCategoryDelete.TabIndex = 5;
            this.tbxCategoryDelete.Text = "Delete";
            this.tbxCategoryDelete.UseVisualStyleBackColor = true;
            this.tbxCategoryDelete.Click += new System.EventHandler(this.tbxCategoryDelete_Click);
            // 
            // tbxCategory2Id
            // 
            this.tbxCategory2Id.Enabled = false;
            this.tbxCategory2Id.Location = new System.Drawing.Point(114, 27);
            this.tbxCategory2Id.Name = "tbxCategory2Id";
            this.tbxCategory2Id.Size = new System.Drawing.Size(145, 22);
            this.tbxCategory2Id.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategori Id:";
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(41, 97);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(99, 34);
            this.btnCategoryUpdate.TabIndex = 2;
            this.btnCategoryUpdate.Text = "Update";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // tbxCategory2Name
            // 
            this.tbxCategory2Name.Location = new System.Drawing.Point(114, 55);
            this.tbxCategory2Name.Name = "tbxCategory2Name";
            this.tbxCategory2Name.Size = new System.Drawing.Size(145, 22);
            this.tbxCategory2Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori Adi:";
            // 
            // KategoriIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwCategory);
            this.Name = "KategoriIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KategoriIslemler";
            this.Load += new System.EventHandler(this.KategoriIslemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.TextBox tbxCategoryAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button tbxCategoryDelete;
        private System.Windows.Forms.TextBox tbxCategory2Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.TextBox tbxCategory2Name;
        private System.Windows.Forms.Label label2;
    }
}