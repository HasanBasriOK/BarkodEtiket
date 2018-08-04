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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTasarla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTasarim frm = Application.OpenForms["frmTasarim"] as frmTasarim;
            if (frm==null)
            {
                frmTasarim frmtasarim = new frmTasarim();
                frmtasarim.MdiParent = this;
                frmtasarim.Show();
            }
            else
            {
                frm.MdiParent = this;
                frm.Activate();
            }
        }

        private void btnListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEtiket frm = Application.OpenForms["frmEtiket"] as frmEtiket;
            if (frm==null)
            {
                frmEtiket frmetiket = new frmEtiket();
                frmetiket.MdiParent = this;
                frmetiket.Show();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}