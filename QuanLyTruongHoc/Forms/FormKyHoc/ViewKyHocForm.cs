using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Convert;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Forms.FormKyHoc
{
    internal class ViewKyHocForm : DetailInfoForm<KyHoc>
    {
        private DevExpress.XtraEditors.SpinEdit hocPhiSpinEdit;
        private DevExpress.XtraEditors.SpinEdit kyHocSpinEdit;
        private DevExpress.XtraEditors.SpinEdit maKyHocSpinEdit;
        private DevExpress.XtraEditors.SpinEdit namHocSpinEdit;

        public ViewKyHocForm() : base()
        {
            InitializeComponent();
        }
        public ViewKyHocForm(KyHoc kyhoc) :base()
        { 
            InitializeComponent();
            this.LoadDataFromObject(kyhoc);
            Init();
        }
        protected override void Init()
        {
            this.maKyHocSpinEdit.Enabled = false;
            this.namHocSpinEdit.Enabled = false;
            this.kyHocSpinEdit.Enabled = false;
            this.hocPhiSpinEdit.Enabled = false;
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.Label hocPhiLabel;
            System.Windows.Forms.Label kyHocLabel;
            System.Windows.Forms.Label maKyHocLabel;
            System.Windows.Forms.Label namHocLabel;
            this.hocPhiSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.kyHocSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.maKyHocSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.namHocSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            hocPhiLabel = new System.Windows.Forms.Label();
            kyHocLabel = new System.Windows.Forms.Label();
            maKyHocLabel = new System.Windows.Forms.Label();
            namHocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhiSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyHocSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKyHocSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namHocSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(hocPhiLabel);
            this.panel1.Controls.Add(this.hocPhiSpinEdit);
            this.panel1.Controls.Add(kyHocLabel);
            this.panel1.Controls.Add(this.kyHocSpinEdit);
            this.panel1.Controls.Add(maKyHocLabel);
            this.panel1.Controls.Add(this.maKyHocSpinEdit);
            this.panel1.Controls.Add(namHocLabel);
            this.panel1.Controls.Add(this.namHocSpinEdit);
            this.panel1.Size = new System.Drawing.Size(816, 533);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 533);
            this.panel2.Size = new System.Drawing.Size(816, 195);
            // 
            // hocPhiLabel
            // 
            hocPhiLabel.AutoSize = true;
            hocPhiLabel.Location = new System.Drawing.Point(38, 283);
            hocPhiLabel.Name = "hocPhiLabel";
            hocPhiLabel.Size = new System.Drawing.Size(68, 20);
            hocPhiLabel.TabIndex = 0;
            hocPhiLabel.Text = "Học Phí:";
            // 
            // kyHocLabel
            // 
            kyHocLabel.AutoSize = true;
            kyHocLabel.Location = new System.Drawing.Point(38, 239);
            kyHocLabel.Name = "kyHocLabel";
            kyHocLabel.Size = new System.Drawing.Size(63, 20);
            kyHocLabel.TabIndex = 2;
            kyHocLabel.Text = "Kỳ Học:";
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Location = new System.Drawing.Point(38, 141);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(89, 20);
            maKyHocLabel.TabIndex = 4;
            maKyHocLabel.Text = "Mã Kỳ Học:";
            // 
            // namHocLabel
            // 
            namHocLabel.AutoSize = true;
            namHocLabel.Location = new System.Drawing.Point(38, 189);
            namHocLabel.Name = "namHocLabel";
            namHocLabel.Size = new System.Drawing.Size(79, 20);
            namHocLabel.TabIndex = 6;
            namHocLabel.Text = "Năm Học:";
            // 
            // hocPhiSpinEdit
            // 
            this.hocPhiSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "HocPhi", true));
            this.hocPhiSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.hocPhiSpinEdit.Location = new System.Drawing.Point(133, 280);
            this.hocPhiSpinEdit.Name = "hocPhiSpinEdit";
            this.hocPhiSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hocPhiSpinEdit.Size = new System.Drawing.Size(150, 28);
            this.hocPhiSpinEdit.TabIndex = 1;
            // 
            // kyHocSpinEdit
            // 
            this.kyHocSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "kyHoc", true));
            this.kyHocSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.kyHocSpinEdit.Location = new System.Drawing.Point(133, 236);
            this.kyHocSpinEdit.Name = "kyHocSpinEdit";
            this.kyHocSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.kyHocSpinEdit.Size = new System.Drawing.Size(150, 28);
            this.kyHocSpinEdit.TabIndex = 3;
            // 
            // maKyHocSpinEdit
            // 
            this.maKyHocSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "MaKyHoc", true));
            this.maKyHocSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.maKyHocSpinEdit.Location = new System.Drawing.Point(133, 138);
            this.maKyHocSpinEdit.Name = "maKyHocSpinEdit";
            this.maKyHocSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.maKyHocSpinEdit.Size = new System.Drawing.Size(150, 28);
            this.maKyHocSpinEdit.TabIndex = 5;
            // 
            // namHocSpinEdit
            // 
            this.namHocSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "NamHoc", true));
            this.namHocSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.namHocSpinEdit.Location = new System.Drawing.Point(133, 186);
            this.namHocSpinEdit.Name = "namHocSpinEdit";
            this.namHocSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.namHocSpinEdit.Size = new System.Drawing.Size(150, 28);
            this.namHocSpinEdit.TabIndex = 7;
            // 
            // ViewKyHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(816, 728);
            this.Name = "ViewKyHocForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhiSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyHocSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKyHocSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namHocSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
