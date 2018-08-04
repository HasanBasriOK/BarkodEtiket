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
using DevExpress.XtraBars;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace BarkodEtiket
{
    public partial class frmTasarim : DevExpress.XtraEditors.XtraForm
    {
        XRDesignMdiController MdiController;
        public static string path = string.Empty;
        public static string selectedItemName = string.Empty;
        public frmTasarim()
        {
            InitializeComponent();
        }
        void MdiController_DesignPanelLoaded(object sender, DesignerLoadedEventArgs e)
        {
            XRDesignPanel panel = (XRDesignPanel)sender;
            panel.AddCommandHandler(new SaveCommandHandler(panel));

        }
        private void btnDesign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtEtiketIsim.EditValue.ToString() == string.Empty)
            {
                XtraMessageBox.Show("Etiket Adı Boş Olamaz", "Hata");
                return;
            }
            path = AppDomain.CurrentDomain.BaseDirectory + "\\Etiket Tasarımları\\" + txtEtiketIsim.EditValue.ToString() + ".repx";
            List<EtiketKayitlari> reportData = new List<EtiketKayitlari>();
            EtiketKayitlari kayit = new EtiketKayitlari();
            kayit.DataID = 1;
            kayit.Alan1 = "Alan1";
            kayit.Alan2 = "Alan2";
            kayit.Alan3 = "Alan3";
            kayit.Alan4 = "Alan4";
            kayit.Alan5 = "Alan5";
            kayit.Alan6 = "Alan6";
            kayit.Alan7 = "Alan7";
            kayit.Alan8 = "Alan8";
            kayit.Alan9 = "Alan9";
            kayit.Alan10 = "Alan10";
            reportData.Add(kayit);

            XRDesignForm form = new XRDesignForm();
            MdiController = form.DesignMdiController;
            MdiController.DesignPanelLoaded += new DesignerLoadedEventHandler(MdiController_DesignPanelLoaded);


            if (File.Exists(string.Format("{0}\\Etiket Tasarımları\\{1}.repx ", AppDomain.CurrentDomain.BaseDirectory, txtEtiketIsim.EditValue.ToString())))
            {
                XtraReport report = XtraReport.FromFile(string.Format("{0}\\Etiket Tasarımları\\{1}.repx ", AppDomain.CurrentDomain.BaseDirectory, txtEtiketIsim.EditValue.ToString()), true);
                //report.DataSource = dt;
                report.DataSource = reportData;
                MdiController.OpenReport(report);
                //ReportPrintTool tl = new ReportPrintTool(report);

                //tl.ShowPreview();
            }
            else
            {
                XtraReport report = new XtraReport();
                //report.SaveLayout(string.Format("{0}\\Etiket Tasarımları\\{1}.repx", AppDomain.CurrentDomain.BaseDirectory, txtEtiketIsim.EditValue.ToString()));
                report.DataSource = reportData;
                MdiController.OpenReport(report);

                //ReportPrintTool tl = new ReportPrintTool(report);
                // tl.ShowPreview();

            }
            form.ShowDialog();
            if (MdiController.ActiveDesignPanel != null)
            {
                MdiController.ActiveDesignPanel.CloseReport();
            }
        }
        private void frmTasarim_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(string.Format("{0}\\Etiket Tasarımları", AppDomain.CurrentDomain.BaseDirectory));
            FileInfo[] files = di.GetFiles();


            foreach (var item in files)
            {
                TileItem tileItem = new TileItem();
                tileItem.Text = item.Name;
                tileItem.Name = item.Name;
                tileItem.ImageToTextAlignment = TileControlImageToTextAlignment.Default;
                tileItem.Image = Image.FromFile(string.Format("{0}\\images.jpg", AppDomain.CurrentDomain.BaseDirectory));
                tileItem.ItemSize = TileItemSize.Wide;
                tileItem.TextAlignment = TileItemContentAlignment.TopLeft;
                tileItem.TextShowMode = TileItemContentShowMode.Always;
                tileGroup2.Items.Add(tileItem);
            }

            //tileControl1.Groups.Add(new TileGroup());
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

        public void EditReport()
        {
            if (tileControl1.SelectedItem == null)
            {
                XtraMessageBox.Show("Düzenlemek istediğiniz etiketi seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string editReportName = tileControl1.SelectedItem.Name;
            List<EtiketKayitlari> reportData = new List<EtiketKayitlari>();
            EtiketKayitlari kayit = new EtiketKayitlari();
            kayit.DataID = 1;
            kayit.Alan1 = "Alan1";
            kayit.Alan2 = "Alan2";
            kayit.Alan3 = "Alan3";
            kayit.Alan4 = "Alan4";
            kayit.Alan5 = "Alan5";
            kayit.Alan6 = "Alan6";
            kayit.Alan7 = "Alan7";
            kayit.Alan8 = "Alan8";
            kayit.Alan9 = "Alan9";
            kayit.Alan10 = "Alan10";
            reportData.Add(kayit);

            XRDesignForm form = new XRDesignForm();
            MdiController = form.DesignMdiController;
            MdiController.DesignPanelLoaded += new DesignerLoadedEventHandler(MdiController_DesignPanelLoaded);

            XtraReport report = XtraReport.FromFile(string.Format("{0}\\Etiket Tasarımları\\{1} ", AppDomain.CurrentDomain.BaseDirectory, selectedItemName), true);
            path = string.Format("{0}\\Etiket Tasarımları\\{1} ", AppDomain.CurrentDomain.BaseDirectory, selectedItemName);
            report.DataSource = reportData;
            MdiController.OpenReport(report);

            form.ShowDialog();
            if (MdiController.ActiveDesignPanel != null)
            {
                MdiController.ActiveDesignPanel.CloseReport();
            }
        }
        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditReport();
        }

        private void tileControl1_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            selectedItemName = e.Item.Name;
        }


    }
}