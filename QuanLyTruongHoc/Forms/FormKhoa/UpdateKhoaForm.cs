using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Convert;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormKhoa
{
    internal class UpdateKhoaForm : DetailInfoForm<Khoa>
    {
        private DevExpress.XtraEditors.CheckEdit daXoaCheckEdit;
        private DevExpress.XtraEditors.TextEdit maKhoaTextEdit;
        private Button update_button;
        private DevExpress.XtraEditors.TextEdit tenKhoaTextEdit;

        public UpdateKhoaForm(Khoa k) : base()
        {
            Khoa newkhoa = ConverterHelper.ConvertDataRow<Khoa>(MainForm.Manager.Khoa.Get(k).Rows[0]);
            InitializeComponent();
            this.LoadDataFromObject(newkhoa);
            //Init();
        }
        public UpdateKhoaForm() : base()
        {
            InitializeComponent();
        }
        protected override void Init()
        {
            this.daXoaCheckEdit.Enabled = false;
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.Label daXoaLabel;
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label tenKhoaLabel;
            this.daXoaCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.maKhoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenKhoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.update_button = new System.Windows.Forms.Button();
            daXoaLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            tenKhoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(816, 429);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.update_button);
            this.panel2.Location = new System.Drawing.Point(0, 429);
            this.panel2.Size = new System.Drawing.Size(816, 210);
            this.panel2.Controls.SetChildIndex(this.update_button, 0);
            // 
            // daXoaLabel
            // 
            daXoaLabel.AutoSize = true;
            daXoaLabel.Location = new System.Drawing.Point(108, 148);
            daXoaLabel.Name = "daXoaLabel";
            daXoaLabel.Size = new System.Drawing.Size(67, 20);
            daXoaLabel.TabIndex = 0;
            daXoaLabel.Text = "Đã Xóa:";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Location = new System.Drawing.Point(108, 198);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(76, 20);
            maKhoaLabel.TabIndex = 2;
            maKhoaLabel.Text = "Mã Khoa:";
            // 
            // tenKhoaLabel
            // 
            tenKhoaLabel.AutoSize = true;
            tenKhoaLabel.Location = new System.Drawing.Point(108, 249);
            tenKhoaLabel.Name = "tenKhoaLabel";
            tenKhoaLabel.Size = new System.Drawing.Size(81, 20);
            tenKhoaLabel.TabIndex = 4;
            tenKhoaLabel.Text = "Tên Khoa:";
            tenKhoaLabel.Click += new System.EventHandler(this.tenKhoaLabel_Click);
            // 
            // daXoaCheckEdit
            // 
            this.daXoaCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "DaXoa", true));
            this.daXoaCheckEdit.Location = new System.Drawing.Point(230, 143);
            this.daXoaCheckEdit.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.daXoaCheckEdit.Name = "daXoaCheckEdit";
            this.daXoaCheckEdit.Properties.Caption = "checkEdit1";
            this.daXoaCheckEdit.Size = new System.Drawing.Size(374, 29);
            this.daXoaCheckEdit.TabIndex = 1;
            // 
            // maKhoaTextEdit
            // 
            this.maKhoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "MaKhoa", true));
            this.maKhoaTextEdit.Location = new System.Drawing.Point(230, 200);
            this.maKhoaTextEdit.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.maKhoaTextEdit.Name = "maKhoaTextEdit";
            this.maKhoaTextEdit.Size = new System.Drawing.Size(374, 28);
            this.maKhoaTextEdit.TabIndex = 3;
            // 
            // tenKhoaTextEdit
            // 
            this.tenKhoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "TenKhoa", true));
            this.tenKhoaTextEdit.Location = new System.Drawing.Point(230, 245);
            this.tenKhoaTextEdit.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.tenKhoaTextEdit.Name = "tenKhoaTextEdit";
            this.tenKhoaTextEdit.Size = new System.Drawing.Size(374, 28);
            this.tenKhoaTextEdit.TabIndex = 5;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(230, 20);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(99, 29);
            this.update_button.TabIndex = 1;
            this.update_button.Text = "Cập nhật";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // UpdateKhoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(816, 639);
            this.Name = "UpdateKhoaForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.daXoaCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhoaTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        private void tenKhoaLabel_Click(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            Khoa khoa = bindingSource.Current as Khoa;
            if (khoa == null) return;

            ValidationContext context = new ValidationContext(khoa, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(khoa, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.Khoa.Update(khoa))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
