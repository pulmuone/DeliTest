using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraPrinting.Control;
using System.Data;
using System.Collections.Generic;

namespace XtraPrintingDemos {
	/// <summary>
	/// Summary description for ModuleControl.
	/// </summary>
    public abstract class PreviewControl : TutorialModuleControl { 
		private DevExpress.XtraPrinting.Control.PrintControl printControl;
		protected DevExpress.XtraPrinting.PrintingSystem printingSystem;
		private System.ComponentModel.IContainer components;
		private Cursor saveCursor;
		protected DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		protected DevExpress.XtraBars.Bar fBarSettings;
		private DevExpress.XtraBars.BarButtonItem bbiPreviewForm;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		protected PrintBarManager fPrintBarManager;

		protected virtual ContainerControl PrintBarManagerForm { get { return printControl; }
		}
		protected virtual PrintPreviewFormEx PreviewForm { get { return printingSystem == null ? null : printingSystem.PreviewFormEx; }
		}

		public virtual PrintControl PrintControl { get { return printControl; }
		}

		public PreviewControl() {
			InitializeComponent();	
			printingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, CommandVisibility.None);

			if(fPrintBarManager != null) fPrintBarManager.Dispose();
			fPrintBarManager = CreatePrintBarManager(printControl);

			fPrintBarManager.PreviewBar.AddItem(bbiPreviewForm).BeginGroup = true;
		}

        public override void Activate() {
			base.Activate();
			ActivateCore();
		}

		protected virtual void ActivateCore() {
            CreateDocument();
		}
		protected void CreateDocument() {
			Cursor currentCursor = Cursor.Current;
			try {
				Cursor.Current = Cursors.WaitCursor;
				CreateDocumentCore();
			} finally {
				Cursor.Current = currentCursor;
			}
		}
		protected virtual void CreateDocumentCore() {
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		/// 
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.printControl = new DevExpress.XtraPrinting.Control.PrintControl();
            this.printingSystem = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.fBarSettings = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bbiPreviewForm = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printControl
            // 
            this.printControl.BackColor = System.Drawing.Color.Empty;
            this.printControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printControl.ForeColor = System.Drawing.Color.Empty;
            this.printControl.IsMetric = false;
            this.printControl.Location = new System.Drawing.Point(2, 31);
            this.printControl.Name = "printControl";
            this.printControl.PrintingSystem = this.printingSystem;
            this.printControl.Size = new System.Drawing.Size(696, 363);
            this.printControl.TabIndex = 1;
            this.printControl.TabStop = false;
            this.printControl.TooltipFont = new System.Drawing.Font("Tahoma", 9F);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.fBarSettings});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this.panelControl1;
            this.barManager1.MaxItemId = 2;
            // 
            // fBarSettings
            // 
            this.fBarSettings.BarName = "Custom 1";
            this.fBarSettings.DockCol = 0;
            this.fBarSettings.DockRow = 0;
            this.fBarSettings.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.fBarSettings.FloatLocation = new System.Drawing.Point(51, 129);
            this.fBarSettings.FloatSize = new System.Drawing.Size(46, 24);
            this.fBarSettings.Text = "Custom 1";
            this.fBarSettings.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(2, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(696, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(2, 394);
            this.barDockControlBottom.Size = new System.Drawing.Size(696, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(2, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 363);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(698, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 363);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.printControl);
            this.panelControl1.Controls.Add(this.barDockControlLeft);
            this.panelControl1.Controls.Add(this.barDockControlRight);
            this.panelControl1.Controls.Add(this.barDockControlBottom);
            this.panelControl1.Controls.Add(this.barDockControlTop);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(700, 396);
            this.panelControl1.TabIndex = 5;
            // 
            // bbiPreviewForm
            // 
            this.bbiPreviewForm.Caption = "Preview Form";
            this.bbiPreviewForm.Id = 0;
            this.bbiPreviewForm.Name = "bbiPreviewForm";
            this.bbiPreviewForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPreviewForm_ItemClick);
            // 
            // PreviewControl
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.panelControl1);
            this.Name = "PreviewControl";
            this.Size = new System.Drawing.Size(700, 396);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
		
		protected PrintBarManager CreatePrintBarManager(PrintControl pc) {
			PrintBarManager printBarManager = new PrintBarManager();
			printBarManager.Form = PrintBarManagerForm;
			printBarManager.Initialize(pc);
			printBarManager.MainMenu.Visible = false;
			printBarManager.AllowCustomization = false;
			return printBarManager;
		}

		private void RestoreProcess() {
			Cursor.Current = saveCursor;
		}	
		private void SetWaitProcess() {
			saveCursor = Cursor.Current;
			Cursor.Current = Cursors.AppStarting;
		}		
		private void bbiPreviewForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
			PreviewForm.SaveState = false;
			ShowPreviewForm(PreviewForm, FindForm());
		}
		private void ShowPreviewForm(PrintPreviewFormEx previewForm, Form parentForm) {
			previewForm.StartPosition = FormStartPosition.Manual;
            previewForm.MinimumSize = parentForm.MinimumSize;
            if(parentForm.WindowState == FormWindowState.Normal)
                previewForm.Bounds = parentForm.Bounds;
            previewForm.WindowState = parentForm.WindowState;
            parentForm.Visible = false;
            previewForm.ShowDialog();
            parentForm.Visible = true;
        }
        PrintingSystem GetPrintingSystem() {
            return printingSystem;
        }
	}
    public static class Helper {
		public static string demoPath = Directory.GetCurrentDirectory();

        public static string GetDocumentPath(Document document, string ext) {
            Assembly asm = Assembly.GetExecutingAssembly();
            string dirName = Path.GetDirectoryName(asm.Location);
            return Path.Combine(dirName, document.Name + "." + ext);
        }
		public static Process StartProcess(string path) {
			Process process = new Process();
            try {
                process.StartInfo.FileName = path;
                process.Start();
                process.WaitForInputIdle();
            } catch { }
			return process;
		}
		public static void CloseProcess(Process process) {
			if(process != null) {
                try {
                    if(!process.CloseMainWindow())
                        process.Kill();
                } catch { }
			}
		}
        static string GetRelativePathCore(string name) {
            return DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\" + name);
        }
        public static string GetRelativePath(string path) {
            if(Assembly.GetEntryAssembly() != Assembly.GetExecutingAssembly())
                return path;
            int index = path.LastIndexOf(@"\") + 1;
            return GetRelativePathCore(path.Substring(index));
        }
    }
}
