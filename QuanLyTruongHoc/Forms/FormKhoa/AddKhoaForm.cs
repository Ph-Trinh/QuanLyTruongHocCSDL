using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormKhoa
{
    internal class AddKhoaForm : DetailInfoForm<Khoa>
    {
        private DevExpress.XtraEditors.CheckEdit daXoaCheckEdit;
        private DevExpress.XtraEditors.TextEdit maKhoaTextEdit;
        private Button add_button;
        private DevExpress.XtraEditors.TextEdit tenKhoaTextEdit;

        public AddKhoaForm() : base()
        {
            InitializeComponent();
            bindingSource.DataSource = new Khoa();
        }
        public AddKhoaForm(Khoa k) : base()
        {
            InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label daXoaLabel;
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label tenKhoaLabel;
            this.daXoaCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.maKhoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenKhoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.add_button = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(816, 494);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.add_button);
            this.panel2.Location = new System.Drawing.Point(0, 494);
            this.panel2.Size = new System.Drawing.Size(816, 191);
            this.panel2.Controls.SetChildIndex(this.add_button, 0);
            // 
            // daXoaLabel
            // 
            daXoaLabel.AutoSize = true;
            daXoaLabel.Location = new System.Drawing.Point(127, 141);
            daXoaLabel.Name = "daXoaLabel";
            daXoaLabel.Size = new System.Drawing.Size(67, 20);
            daXoaLabel.TabIndex = 0;
            daXoaLabel.Text = "Đã Xóa:";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Location = new System.Drawing.Point(127, 187);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(76, 20);
            maKhoaLabel.TabIndex = 2;
            maKhoaLabel.Text = "Mã Khoa:";
            // 
            // tenKhoaLabel
            // 
            tenKhoaLabel.AutoSize = true;
            tenKhoaLabel.Location = new System.Drawing.Point(127, 244);
            tenKhoaLabel.Name = "tenKhoaLabel";
            tenKhoaLabel.Size = new System.Drawing.Size(81, 20);
            tenKhoaLabel.TabIndex = 4;
            tenKhoaLabel.Text = "Tên Khoa:";
            // 
            // daXoaCheckEdit
            // 
            this.daXoaCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "DaXoa", true));
            this.daXoaCheckEdit.Location = new System.Drawing.Point(255, 132);
            this.daXoaCheckEdit.Margin = new System.Windows.Forms.Padding(9);
            this.daXoaCheckEdit.Name = "daXoaCheckEdit";
            this.daXoaCheckEdit.Properties.Caption = "checkEdit1";
            this.daXoaCheckEdit.Size = new System.Drawing.Size(507, 29);
            this.daXoaCheckEdit.TabIndex = 1;
            // 
            // maKhoaTextEdit
            // 
            this.maKhoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "MaKhoa", true));
            this.maKhoaTextEdit.Location = new System.Drawing.Point(255, 179);
            this.maKhoaTextEdit.Margin = new System.Windows.Forms.Padding(9);
            this.maKhoaTextEdit.Name = "maKhoaTextEdit";
            this.maKhoaTextEdit.Size = new System.Drawing.Size(311, 28);
            this.maKhoaTextEdit.TabIndex = 3;
            this.maKhoaTextEdit.EditValueChanged += new System.EventHandler(this.maKhoaTextEdit_EditValueChanged);
            // 
            // tenKhoaTextEdit
            // 
            this.tenKhoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "TenKhoa", true));
            this.tenKhoaTextEdit.Location = new System.Drawing.Point(255, 236);
            this.tenKhoaTextEdit.Margin = new System.Windows.Forms.Padding(9);
            this.tenKhoaTextEdit.Name = "tenKhoaTextEdit";
            this.tenKhoaTextEdit.Size = new System.Drawing.Size(311, 28);
            this.tenKhoaTextEdit.TabIndex = 5;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(239, 23);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(81, 36);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Thêm";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // AddKhoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(816, 685);
            this.Name = "AddKhoaForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.daXoaCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhoaTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        private void add_button_Click(object sender, EventArgs e)
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

            if (MainForm.Manager.Khoa.Add(khoa))
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void maKhoaTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
