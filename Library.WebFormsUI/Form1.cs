using Library.Business.Abstract;
using Library.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Business.DependencyResolver.Ninject;
using Library.DataAccess.Concrete.Sql;
using Library.Entities.Concrete;

namespace Library.WebFormsUI
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            _kitapService = InstanceFactory.GetInstance<IKitapService>();
            _kategoriService = InstanceFactory.GetInstance<IKategoriService>();
            _sqlKitapDal=new SqlKitapDal();


            

        }

        private IKitapService _kitapService;
        private IKategoriService _kategoriService;
        private SqlKitapDal _sqlKitapDal;
        private void Form1_Load(object sender, EventArgs e)
        {
           

            LoadKitaps();
            LoadCategories();
            
           
        }

        private void LoadKitaps()
        {

            //dgwKitaps.DataSource=_kitapService.GetAll();

            dgwKitaps.DataSource=_sqlKitapDal.KitapList();
            dgwKitaps.Columns["Id"].Visible = false;
            dgwKitaps.Columns["KategoriId"].Visible = false;
            dgwKitaps.Columns["YazarId"].Visible = false;



        }

        private void LoadCategories()
        {
            using (LibraryDBContext libraryDbContext = new LibraryDBContext())
            {

                cbxCategory.DataSource = libraryDbContext.Kategoris.ToList();
                cbxCategory.DisplayMember = "KategoriAdi";
                cbxCategory.ValueMember = "Id";

                
            }


            
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    dgwKitaps.DataSource = _kitapService.GetKitapByKategori(Convert.ToInt32(cbxCategory.SelectedValue));
            //}
            //catch 
            //{
               
            //}

            try
            {
                dgwKitaps.DataSource = _sqlKitapDal.ListKitapByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch 
            {
                
            }
        }

        private void btnAllCategory_Click(object sender, EventArgs e)
        {
            
            dgwKitaps.DataSource=_kitapService.GetAll();
        }

        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtKitapAdi.Text))
            {
                dgwKitaps.DataSource = _kitapService.GetKitapByKitapAdi(txtKitapAdi.Text);
            }
            else
            {
                LoadKitaps();
            }
            
        }

        private void btnKitapIslemler_Click(object sender, EventArgs e)
        {
            KategoriIslemler kategoriIslemler=new KategoriIslemler();
            kategoriIslemler.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapIslemleri kitapIslemleri=new KitapIslemleri();
            kitapIslemleri.Show();
        }
    }
}
