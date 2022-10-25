using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Convert;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormKyHoc
{
    internal class ListKyHocForm : BaseListForm
    {
        private BindingSource kyHocBindingSource;
        private DevExpress.XtraEditors.TextEdit hocPhiTextEdit;
        private DevExpress.XtraEditors.TextEdit kyHocTextEdit;
        private DevExpress.XtraEditors.TextEdit maKyHocTextEdit;
        private DevExpress.XtraEditors.TextEdit namHocTextEdit;
        private System.ComponentModel.IContainer components;

        public ListKyHocForm()
        {
            InitializeComponent();
            dataGridView.DataSource = MainForm.Manager.KyHoc.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label hocPhiLabel;
            System.Windows.Forms.Label kyHocLabel;
            System.Windows.Forms.Label maKyHocLabel;
            System.Windows.Forms.Label namHocLabel;
            this.kyHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocPhiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.kyHocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maKyHocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.namHocTextEdit = new DevExpress.XtraEditors.TextEdit();
            hocPhiLabel = new System.Windows.Forms.Label();
            kyHocLabel = new System.Windows.Forms.Label();
            maKyHocLabel = new System.Windows.Forms.Label();
            namHocLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyHocTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKyHocTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namHocTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(hocPhiLabel);
            this.panel1.Controls.Add(this.hocPhiTextEdit);
            this.panel1.Controls.Add(kyHocLabel);
            this.panel1.Controls.Add(this.kyHocTextEdit);
            this.panel1.Controls.Add(maKyHocLabel);
            this.panel1.Controls.Add(this.maKyHocTextEdit);
            this.panel1.Controls.Add(namHocLabel);
            this.panel1.Controls.Add(this.namHocTextEdit);
            this.panel1.Size = new System.Drawing.Size(900, 274);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.namHocTextEdit, 0);
            this.panel1.Controls.SetChildIndex(namHocLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maKyHocTextEdit, 0);
            this.panel1.Controls.SetChildIndex(maKyHocLabel, 0);
            this.panel1.Controls.SetChildIndex(this.kyHocTextEdit, 0);
            this.panel1.Controls.SetChildIndex(kyHocLabel, 0);
            this.panel1.Controls.SetChildIndex(this.hocPhiTextEdit, 0);
            this.panel1.Controls.SetChildIndex(hocPhiLabel, 0);
            // 
            // kyHocBindingSource
            // 
            this.kyHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.KyHoc);
            // 
            // hocPhiLabel
            // 
            hocPhiLabel.AutoSize = true;
            hocPhiLabel.Location = new System.Drawing.Point(71, 175);
            hocPhiLabel.Name = "hocPhiLabel";
            hocPhiLabel.Size = new System.Drawing.Size(68, 20);
            hocPhiLabel.TabIndex = 2;
            hocPhiLabel.Text = "Học Phí:";
            // 
            // hocPhiTextEdit
            // 
            this.hocPhiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kyHocBindingSource, "HocPhi", true));
            this.hocPhiTextEdit.Location = new System.Drawing.Point(166, 172);
            this.hocPhiTextEdit.Name = "hocPhiTextEdit";
            this.hocPhiTextEdit.Size = new System.Drawing.Size(150, 28);
            this.hocPhiTextEdit.TabIndex = 3;
            // 
            // kyHocLabel
            // 
            kyHocLabel.AutoSize = true;
            kyHocLabel.Location = new System.Drawing.Point(71, 141);
            kyHocLabel.Name = "kyHocLabel";
            kyHocLabel.Size = new System.Drawing.Size(63, 20);
            kyHocLabel.TabIndex = 4;
            kyHocLabel.Text = "Kỳ Học:";
            // 
            // kyHocTextEdit
            // 
            this.kyHocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kyHocBindingSource, "kyHoc", true));
            this.kyHocTextEdit.Location = new System.Drawing.Point(166, 138);
            this.kyHocTextEdit.Name = "kyHocTextEdit";
            this.kyHocTextEdit.Size = new System.Drawing.Size(150, 28);
            this.kyHocTextEdit.TabIndex = 5;
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Location = new System.Drawing.Point(71, 73);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(89, 20);
            maKyHocLabel.TabIndex = 6;
            maKyHocLabel.Text = "Mã Kỳ Học:";
            // 
            // maKyHocTextEdit
            // 
            this.maKyHocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kyHocBindingSource, "MaKyHoc", true));
            this.maKyHocTextEdit.Location = new System.Drawing.Point(166, 70);
            this.maKyHocTextEdit.Name = "maKyHocTextEdit";
            this.maKyHocTextEdit.Size = new System.Drawing.Size(150, 28);
            this.maKyHocTextEdit.TabIndex = 7;
            // 
            // namHocLabel
            // 
            namHocLabel.AutoSize = true;
            namHocLabel.Location = new System.Drawing.Point(71, 107);
            namHocLabel.Name = "namHocLabel";
            namHocLabel.Size = new System.Drawing.Size(79, 20);
            namHocLabel.TabIndex = 8;
            namHocLabel.Text = "Năm Học:";
            // 
            // namHocTextEdit
            // 
            this.namHocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kyHocBindingSource, "NamHoc", true));
            this.namHocTextEdit.Location = new System.Drawing.Point(166, 104);
            this.namHocTextEdit.Name = "namHocTextEdit";
            this.namHocTextEdit.Size = new System.Drawing.Size(150, 28);
            this.namHocTextEdit.TabIndex = 9;
            // 
            // ListKyHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Name = "ListKyHocForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyHocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKyHocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namHocTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                KyHoc kyHoc = ConverterHelper.ConvertDataRow<KyHoc>(row);
                ViewKyHocForm viewKyHocForm = new ViewKyHocForm(kyHoc);
                viewKyHocForm.Show();
            }
            else
            {
                MessageBox.Show("Không có kỳ học nào được chọn");
            }
        }
        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                KyHoc kyHoc = ConverterHelper.ConvertDataRow<KyHoc>(row);
                UpdateKyHocForm updateKyHocForm = new UpdateKyHocForm(kyHoc);
                updateKyHocForm.Show();
            }
            else
            {
                MessageBox.Show("Không có kỳ học nào được chọn");
            }
        }
        protected override void add_btn_Click(object sender, EventArgs e)
        {
            AddKyHocForm addKyHocForm = new AddKyHocForm();
            addKyHocForm.Show();
        }
    }
}
