using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Forms.FormKhoa
{
    internal class ViewKhoaForm : DetailInfoForm<Khoa>
    {
        private DevExpress.XtraEditors.CheckEdit daXoaCheckEdit;
        private DevExpress.XtraEditors.TextEdit maKhoaTextEdit;
        private DevExpress.XtraEditors.TextEdit tenKhoaTextEdit;

        public ViewKhoaForm(Khoa k) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(k);
            Init();
        }
        public ViewKhoaForm() : base()
        {
            InitializeComponent();
        }
        protected override void Init()
        {
            this.daXoaCheckEdit.Enabled = false;
            this.maKhoaTextEdit.Enabled = false;
            this.tenKhoaTextEdit.Enabled = false;
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.Label daXoaLabel;
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label tenKhoaLabel;
            this.daXoaCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.maKhoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenKhoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            daXoaLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            tenKhoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(791, 445);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 445);
            this.panel2.Size = new System.Drawing.Size(791, 166);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // daXoaLabel
            // 
            daXoaLabel.AutoSize = true;
            daXoaLabel.Location = new System.Drawing.Point(111, 178);
            daXoaLabel.Name = "daXoaLabel";
            daXoaLabel.Size = new System.Drawing.Size(67, 20);
            daXoaLabel.TabIndex = 0;
            daXoaLabel.Text = "Đã Xóa:";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Location = new System.Drawing.Point(111, 213);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(76, 20);
            maKhoaLabel.TabIndex = 2;
            maKhoaLabel.Text = "Mã Khoa:";
            // 
            // tenKhoaLabel
            // 
            tenKhoaLabel.AutoSize = true;
            tenKhoaLabel.Location = new System.Drawing.Point(111, 247);
            tenKhoaLabel.Name = "tenKhoaLabel";
            tenKhoaLabel.Size = new System.Drawing.Size(81, 20);
            tenKhoaLabel.TabIndex = 4;
            tenKhoaLabel.Text = "Tên Khoa:";
            // 
            // daXoaCheckEdit
            // 
            this.daXoaCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "DaXoa", true));
            this.daXoaCheckEdit.Location = new System.Drawing.Point(198, 175);
            this.daXoaCheckEdit.Name = "daXoaCheckEdit";
            this.daXoaCheckEdit.Properties.Caption = "checkEdit1";
            this.daXoaCheckEdit.Size = new System.Drawing.Size(150, 29);
            this.daXoaCheckEdit.TabIndex = 1;
            // 
            // maKhoaTextEdit
            // 
            this.maKhoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "MaKhoa", true));
            this.maKhoaTextEdit.Location = new System.Drawing.Point(198, 210);
            this.maKhoaTextEdit.Name = "maKhoaTextEdit";
            this.maKhoaTextEdit.Size = new System.Drawing.Size(150, 28);
            this.maKhoaTextEdit.TabIndex = 3;
            // 
            // tenKhoaTextEdit
            // 
            this.tenKhoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "TenKhoa", true));
            this.tenKhoaTextEdit.Location = new System.Drawing.Point(198, 244);
            this.tenKhoaTextEdit.Name = "tenKhoaTextEdit";
            this.tenKhoaTextEdit.Size = new System.Drawing.Size(150, 28);
            this.tenKhoaTextEdit.TabIndex = 5;
            // 
            // ViewKhoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(791, 611);
            this.Name = "ViewKhoaForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daXoaCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhoaTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
