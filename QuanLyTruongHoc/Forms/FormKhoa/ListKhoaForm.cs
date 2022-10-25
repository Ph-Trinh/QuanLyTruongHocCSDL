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

namespace QuanLyTruongHoc.Forms.FormKhoa
{
    internal class ListKhoaForm : BaseListForm
    {
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private DevExpress.XtraEditors.CheckEdit daXoaCheckEdit;
        private DevExpress.XtraEditors.TextEdit maKhoaTextEdit;
        private DevExpress.XtraEditors.TextEdit tenKhoaTextEdit;
        private System.ComponentModel.IContainer components;

        public ListKhoaForm()
        {
            InitializeComponent();
            dataGridView.DataSource = MainForm.Manager.Khoa.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label daXoaLabel;
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label tenKhoaLabel;
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daXoaCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.maKhoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenKhoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            daXoaLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            tenKhoaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daXoaCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhoaTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(daXoaLabel);
            this.panel1.Controls.Add(this.daXoaCheckEdit);
            this.panel1.Controls.Add(maKhoaLabel);
            this.panel1.Controls.Add(this.maKhoaTextEdit);
            this.panel1.Controls.Add(tenKhoaLabel);
            this.panel1.Controls.Add(this.tenKhoaTextEdit);
            this.panel1.Size = new System.Drawing.Size(900, 348);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.tenKhoaTextEdit, 0);
            this.panel1.Controls.SetChildIndex(tenKhoaLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maKhoaTextEdit, 0);
            this.panel1.Controls.SetChildIndex(maKhoaLabel, 0);
            this.panel1.Controls.SetChildIndex(this.daXoaCheckEdit, 0);
            this.panel1.Controls.SetChildIndex(daXoaLabel, 0);
            // 
            // daXoaLabel
            // 
            daXoaLabel.AutoSize = true;
            daXoaLabel.Location = new System.Drawing.Point(153, 139);
            daXoaLabel.Name = "daXoaLabel";
            daXoaLabel.Size = new System.Drawing.Size(67, 20);
            daXoaLabel.TabIndex = 2;
            daXoaLabel.Text = "Đã Xóa:";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Location = new System.Drawing.Point(153, 178);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(76, 20);
            maKhoaLabel.TabIndex = 4;
            maKhoaLabel.Text = "Mã Khoa:";
            // 
            // tenKhoaLabel
            // 
            tenKhoaLabel.AutoSize = true;
            tenKhoaLabel.Location = new System.Drawing.Point(153, 219);
            tenKhoaLabel.Name = "tenKhoaLabel";
            tenKhoaLabel.Size = new System.Drawing.Size(81, 20);
            tenKhoaLabel.TabIndex = 6;
            tenKhoaLabel.Text = "Tên Khoa:";
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.Khoa);
            // 
            // daXoaCheckEdit
            // 
            this.daXoaCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoaBindingSource, "DaXoa", true));
            this.daXoaCheckEdit.Location = new System.Drawing.Point(266, 134);
            this.daXoaCheckEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.daXoaCheckEdit.Name = "daXoaCheckEdit";
            this.daXoaCheckEdit.Properties.Caption = "checkEdit1";
            this.daXoaCheckEdit.Size = new System.Drawing.Size(338, 29);
            this.daXoaCheckEdit.TabIndex = 3;
            // 
            // maKhoaTextEdit
            // 
            this.maKhoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoaBindingSource, "MaKhoa", true));
            this.maKhoaTextEdit.Location = new System.Drawing.Point(266, 175);
            this.maKhoaTextEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.maKhoaTextEdit.Name = "maKhoaTextEdit";
            this.maKhoaTextEdit.Size = new System.Drawing.Size(338, 28);
            this.maKhoaTextEdit.TabIndex = 5;
            // 
            // tenKhoaTextEdit
            // 
            this.tenKhoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoaBindingSource, "TenKhoa", true));
            this.tenKhoaTextEdit.Location = new System.Drawing.Point(266, 215);
            this.tenKhoaTextEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tenKhoaTextEdit.Name = "tenKhoaTextEdit";
            this.tenKhoaTextEdit.Size = new System.Drawing.Size(338, 28);
            this.tenKhoaTextEdit.TabIndex = 7;
            // 
            // ListKhoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Name = "ListKhoaForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daXoaCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhoaTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Khoa khoa = ConverterHelper.ConvertDataRow<Khoa>(row);
                ViewKhoaForm viewKhoaForm = new ViewKhoaForm(khoa);
                viewKhoaForm.Show();
            }
            else
            {
                MessageBox.Show("Không có khoa nào được chọn");
            }
        }
        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Khoa khoa = ConverterHelper.ConvertDataRow<Khoa>(row);
                UpdateKhoaForm updateKhoaForm = new UpdateKhoaForm(khoa);
                updateKhoaForm.Show();
            }
            else
            {
                MessageBox.Show("Không có khoa nào được chọn");
            }
        }
        protected override void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Khoa k = ConverterHelper.ConvertDataRow<Khoa>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này không?", "Xóa khoa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ADOKhoa khoa = MainForm.Manager.Khoa;
                    if (khoa.Delete(k))
                    {
                        MessageBox.Show("Xóa khoa thành công");
                        dataGridView.DataSource = khoa.Load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khoa thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có khoa nào được chọn");
            }
        }
        protected override void add_btn_Click(object sender, EventArgs e)
        {
            AddKhoaForm addKhoaForm = new AddKhoaForm();
            addKhoaForm.Show();
        }
        private void tenKhoaTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
