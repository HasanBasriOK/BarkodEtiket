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
using System.IO;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraReports.UI;

namespace BarkodEtiket
{

    public partial class frmEtiketYazdir : DevExpress.XtraEditors.XtraForm
    {
        XRDesignMdiController MdiController;
        EtiketKayitlari yazdirilacakKayit = null;
        public frmEtiketYazdir(EtiketKayitlari kayit)
        {
            InitializeComponent();
            yazdirilacakKayit = kayit;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<EtiketKayitlari> reportData = new List<EtiketKayitlari>();

            string baslangicBarkod = txtBaslangicBarkod.Text;
            int adet = Convert.ToInt32(txtAdet.Text);
            string bitisBarkod = (Convert.ToInt32(baslangicBarkod) + adet).ToString() ;

            for (int i = 1; i <= adet; i++)
            {
                EtiketKayitlari etiket = new EtiketKayitlari();
                etiket.Alan1 = yazdirilacakKayit.Alan1;
                etiket.Alan2 = yazdirilacakKayit.Alan2;
                etiket.Alan3 = yazdirilacakKayit.Alan3;
                etiket.Alan4 = yazdirilacakKayit.Alan4;
                etiket.Alan5 = yazdirilacakKayit.Alan5;
                etiket.Alan6 = yazdirilacakKayit.Alan6;
                etiket.Alan7 = yazdirilacakKayit.Alan7;
                etiket.Alan8 = yazdirilacakKayit.Alan8;
                etiket.Alan9 = yazdirilacakKayit.Alan9;
                etiket.Alan10 = yazdirilacakKayit.Alan10;
                etiket.Barkod = (Convert.ToInt32(baslangicBarkod)+i).ToString();
                etiket.SonBarkod = bitisBarkod;
                reportData.Add(etiket);
            }

            XtraReport report = XtraReport.FromFile(string.Format("{0}\\Etiket Tasarımları\\{1}.repx ", AppDomain.CurrentDomain.BaseDirectory, cmbEtiket.Text), true);
            report.DataSource = reportData;
            //MdiController.OpenReport(report);
            ReportPrintTool tl = new ReportPrintTool(report);

            tl.ShowRibbonPreviewDialog();
        }

        private void frmEtiketYazdir_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(string.Format("{0}\\Etiket Tasarımları", AppDomain.CurrentDomain.BaseDirectory));
            FileInfo[] files = di.GetFiles();
            foreach (var item in files)
            {
                cmbEtiket.Items.Add(item.Name.Substring(0,item.Name.Length-5));
            }
        }
    }
    public class SaveCommandHandler : DevExpress.XtraReports.UserDesigner.ICommandHandler
    {
        XRDesignPanel panel;

        public SaveCommandHandler(XRDesignPanel panel)
        {
            this.panel = panel;
        }

        public void HandleCommand(DevExpress.XtraReports.UserDesigner.ReportCommand command,
        object[] args)
        {
            // Save the report.
            Save();
        }

        public bool CanHandleCommand(DevExpress.XtraReports.UserDesigner.ReportCommand command,
        ref bool useNextHandler)
        {
            useNextHandler = !(command == ReportCommand.SaveFile ||
                command == ReportCommand.SaveFileAs);
            return !useNextHandler;
        }

        void Save()
        {
            // Write your custom saving here.
            // ...

            // For instance:
            string path = string.Format(frmTasarim.path);


            panel.Report.SaveLayout(path);

            // Prevent the "Report has been changed" dialog from being shown.
            panel.ReportState = ReportState.Saved;
        }
    }
}