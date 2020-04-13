using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Business.Abstract;
using Library.Business.DependencyResolver.Ninject;
using Library.DataAccess.Concrete.Sql;
using Library.Entities.Concrete;

namespace Library.WebFormsUI
{
    public partial class KategoriIslemler : Form
    {
        public KategoriIslemler()
        {
            InitializeComponent();
            _kategoriService = InstanceFactory.GetInstance<IKategoriService>();
            _sqlKitapDal=new SqlKitapDal();
        }

        private IKategoriService _kategoriService;
        private SqlKitapDal _sqlKitapDal;
        private void KategoriIslemler_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            dgwCategory.DataSource = _kategoriService.GetAll();
        }

        private void dgwCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwCategory.CurrentRow;
            tbxCategory2Id.Text = row.Cells[0].Value.ToString();
            tbxCategory2Name.Text = row.Cells[1].Value.ToString();
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            _kategoriService.Update(new Kategori
            {
                 Id = Convert.ToInt32(tbxCategory2Id.Text),
                 KategoriAdi = tbxCategory2Name.Text
            });
            MessageBox.Show("Kategori güncellendi");
            tbxCategory2Id.Text = "";
            tbxCategory2Name.Text = "";
            LoadCategories();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            //_kategoriService.Add(new Kategori
            //{
            //    KategoriAdi = tbxCategoryAdd.Text
            //});
            _sqlKitapDal.AddCategory(tbxCategoryAdd.Text);
            MessageBox.Show("Kategori Eklendi");
            
            tbxCategoryAdd.Text = "";
            LoadCategories();
        }

        private void tbxCategoryDelete_Click(object sender, EventArgs e)
        {
            _kategoriService.Delete(new Kategori
            {
                Id = Convert.ToInt32(tbxCategory2Id.Text)
            });
            MessageBox.Show("Kategori Silindi");
            tbxCategory2Id.Text = "";
            tbxCategory2Name.Text = "";
            LoadCategories();
        }
    }
}
