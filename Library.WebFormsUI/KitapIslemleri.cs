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
using Library.DataAccess.Concrete.EntityFramework;
using Library.Entities.Concrete;

namespace Library.WebFormsUI
{
    public partial class KitapIslemleri : Form
    {
        public KitapIslemleri()
        {
            InitializeComponent();
            _kitapService= InstanceFactory.GetInstance<IKitapService>();
        }

        private IKitapService _kitapService;
        private void KitapIslemleri_Load(object sender, EventArgs e)
        {
            LoadKitaps();
            LoadCategories();
            LoadYazars();
        }

        private void LoadYazars()
        {
            List<Example> list =new List<Example>();
            using (LibraryDBContext libraryDbContext = new LibraryDBContext())
            {
                var sorgu= libraryDbContext.Yazars.ToList();
                foreach (var item in sorgu)
                {
                    Example e=new Example();
                    e.Id = item.Id;
                    e.YazarFullName = item.Adi + " " + item.Soyadi;
                    list.Add(e);

                }


                cbxAddYazarAdi.DataSource = list; 
                cbxAddYazarAdi.DisplayMember = "YazarFullName";
                cbxAddYazarAdi.ValueMember = "Id";


            }
        }

        public class Example
        {
            public int Id { get; set; }
            public string YazarFullName { get; set; }
        }

        private void LoadCategories()
        {
            using (LibraryDBContext libraryDbContext = new LibraryDBContext())
            {

                cbxAddKitapCategory.DataSource = libraryDbContext.Kategoris.ToList();
                cbxAddKitapCategory.DisplayMember = "KategoriAdi";
                cbxAddKitapCategory.ValueMember = "Id";


            }
        }

        private void LoadKitaps()
        {
            dgwKitapIslemleri.DataSource = _kitapService.GetAll();
        }

        private void btnKitapAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _kitapService.Add(new Kitap
                {
                    KitapAdi = tbxKitapAdd.Text,
                    KategoriId = Convert.ToInt32(cbxAddKitapCategory.SelectedValue),
                    YazarId = Convert.ToInt32(cbxAddYazarAdi.SelectedValue),
                    RafNo = tbxKitapAddRafNo.Text
                });
                MessageBox.Show("Kitap Eklendi");
                LoadKitaps();
                tbxKitapAdd.Text = "";
                tbxKitapAddRafNo.Text = "";
            }
            catch 
            {
                
            }
           
        }

        private void dgwKitapIslemleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwKitapIslemleri.CurrentRow;
            tbxKitapUpdateId.Text = row.Cells[0].Value.ToString();
            tbxUpdateRafNo.Text = row.Cells[4].Value.ToString();
           
            
        }

        private void btnKitapUpdate_Click(object sender, EventArgs e)
        {
            var row = dgwKitapIslemleri.CurrentRow;
            _kitapService.Update(new Kitap
                {
                    Id = Convert.ToInt32(tbxKitapUpdateId.Text),
                    KitapAdi = row.Cells[3].Value.ToString(),
                    KategoriId = Convert.ToInt32(row.Cells[1].Value),
                    YazarId = Convert.ToInt32(row.Cells[2].Value),
                    RafNo = tbxUpdateRafNo.Text

                });
                MessageBox.Show("Kitap Raf numarası güncellendi");
                LoadKitaps();
                tbxUpdateRafNo.Text = "";
            
            
            
        }

        private void btnKitapDelete_Click(object sender, EventArgs e)
        {
            var row = dgwKitapIslemleri.CurrentRow;
            _kitapService.Delete(new Kitap
            {
                Id= Convert.ToInt32(tbxKitapUpdateId.Text)
            });
            MessageBox.Show("Kitap silindi");
            LoadKitaps();
            tbxUpdateRafNo.Text = "";
        }
    }
}
