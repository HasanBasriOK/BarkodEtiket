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
    public partial class frmYeniKayit : DevExpress.XtraEditors.XtraForm
    {
        EtiketKayitlari editKayit = null;
        public frmYeniKayit()
        {
            InitializeComponent();
        }
        public frmYeniKayit(EtiketKayitlari etiket)
        {
            InitializeComponent();
            editKayit = etiket;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EtiketKayitlari etiket = new EtiketKayitlari();
            if (editKayit != null)
                etiket.DataID = editKayit.DataID;

            etiket.Alan1 = txtAlan1.Text;
            etiket.Alan2 = txtAlan2.Text;
            etiket.Alan3 = txtAlan3.Text;
            etiket.Alan4 = txtAlan4.Text;
            etiket.Alan5 = txtAlan5.Text;
            etiket.Alan6 = txtAlan6.Text;
            etiket.Alan7 = txtAlan7.Text;
            etiket.Alan8 = txtAlan8.Text;
            etiket.Alan9 = txtAlan9.Text;
            etiket.Alan10 = txtAlan10.Text;

            try
            {
                if (editKayit == null)
                    etiket.Insert(etiket);
                else
                    etiket.Update(etiket);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata : " + ex.Message);
            }
            frmEtiket frm = Application.OpenForms["frmEtiket"] as frmEtiket;
            frm.DataBind();
            this.Close();
        }

        private void frmYeniKayit_Load(object sender, EventArgs e)
        {
            if (editKayit != null)
            {
                txtAlan1.Text = editKayit.Alan1;
                txtAlan2.Text = editKayit.Alan2;
                txtAlan3.Text = editKayit.Alan3;
                txtAlan4.Text = editKayit.Alan4;
                txtAlan5.Text = editKayit.Alan5;
                txtAlan6.Text = editKayit.Alan6;
                txtAlan7.Text = editKayit.Alan7;
                txtAlan8.Text = editKayit.Alan8;
                txtAlan9.Text = editKayit.Alan9;
                txtAlan10.Text = editKayit.Alan10;
            }
        }
    }
}