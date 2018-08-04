using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BarkodEtiket
{
    public partial class frmEtiket : DevExpress.XtraEditors.XtraForm
    {
        public frmEtiket()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmYeniKayit frm = new frmYeniKayit();
            frm.ShowDialog();
        }

        public void DataBind()
        {
            gridControl1.DataSource = new EtiketKayitlari().GetObjects();
            gridControl1.RefreshDataSource();
            gridControl1.Refresh();
        }
        private void frmEtiket_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int[] rows = gridView1.GetSelectedRows();

            EtiketKayitlari kayit = null;
            foreach (var item in rows)
            {
                kayit = gridView1.GetRow(item) as EtiketKayitlari;
            }

            frmYeniKayit frm = new frmYeniKayit(kayit);
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int[] rows = gridView1.GetSelectedRows();

            EtiketKayitlari kayit = null;
            foreach (var item in rows)
            {
                kayit = gridView1.GetRow(item) as EtiketKayitlari;
            }
            new EtiketKayitlari().Delete(kayit.DataID);
            DataBind();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int[] rows = gridView1.GetSelectedRows();

            EtiketKayitlari kayit = null;
            foreach (var item in rows)
            {
                kayit = gridView1.GetRow(item) as EtiketKayitlari;
            }
            if (kayit==null)
            {
                XtraMessageBox.Show("Etiket Yazdırmak İçin Lütfen Kayıt Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmEtiketYazdir frm = new frmEtiketYazdir(kayit);
            frm.ShowDialog();
        }
    }
}