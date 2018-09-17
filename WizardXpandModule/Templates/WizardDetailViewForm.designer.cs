
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;

namespace WizardXpandModule.Templates
{
    partial class WizardDetailViewForm
    {
        private PanelControl _ViewSitePanel;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraWizard.WizardControl wizardControl;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wizardControl = new DevExpress.XtraWizard.WizardControl();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this._ViewSitePanel = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.showRecordAfterCompletion = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).BeginInit();
            this.wizardControl.SuspendLayout();
            this.completionWizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ViewSitePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRecordAfterCompletion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // viewSiteManager
            // 
            this.viewSiteManager.ViewSiteControl = this._ViewSitePanel;
            // 
            // wizardControl
            // 
            this.wizardControl.Controls.Add(this.completionWizardPage1);
            this.wizardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl.Image = global::WizardXpandModule.Properties.Resources.wizard_image;
            this.wizardControl.Location = new System.Drawing.Point(0, 0);
            this.wizardControl.Name = "wizardControl";
            this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.completionWizardPage1});
            this.wizardControl.Size = new System.Drawing.Size(792, 566);
            this.wizardControl.UseAcceptButton = false;
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Controls.Add(this.label1);
            this.completionWizardPage1.Controls.Add(this.showRecordAfterCompletion);
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(575, 433);
            // 
            // _ViewSitePanel
            // 
            this._ViewSitePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._ViewSitePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ViewSitePanel.Location = new System.Drawing.Point(0, 0);
            this._ViewSitePanel.Name = "_ViewSitePanel";
            this._ViewSitePanel.Size = new System.Drawing.Size(200, 100);
            this._ViewSitePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Show record  after completing the wizard.";
            // 
            // showRecordAfterCompletion
            // 
            this.showRecordAfterCompletion.Location = new System.Drawing.Point(3, 95);
            this.showRecordAfterCompletion.Name = "showRecordAfterCompletion";
            this.showRecordAfterCompletion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.showRecordAfterCompletion.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.showRecordAfterCompletion.Properties.Appearance.Options.UseFont = true;
            this.showRecordAfterCompletion.Properties.Appearance.Options.UseForeColor = true;
            this.showRecordAfterCompletion.Properties.Caption = "";
            this.showRecordAfterCompletion.Size = new System.Drawing.Size(417, 19);
            this.showRecordAfterCompletion.TabIndex = 7;
            // 
            // WizardDetailViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.wizardControl);
            this.Name = "WizardDetailViewForm";
            this.Text = "SimpleForm";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).EndInit();
            this.wizardControl.ResumeLayout(false);
            this.completionWizardPage1.ResumeLayout(false);
            this.completionWizardPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ViewSitePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRecordAfterCompletion.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


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
        private Label label1;
        public CheckEdit showRecordAfterCompletion;
    }
}