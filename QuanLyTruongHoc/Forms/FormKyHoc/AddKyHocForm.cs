using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormKyHoc
{
    internal class AddKyHocForm : DetailInfoForm<KyHoc>
    {
        private DevExpress.XtraEditors.TextEdit hocPhiTextEdit;
        private DevExpress.XtraEditors.TextEdit kyHocTextEdit;
        private DevExpress.XtraEditors.TextEdit maKyHocTextEdit;
        private Button add_button;
        private DevExpress.XtraEditors.TextEdit namHocTextEdit;

        public AddKyHocForm() : base()
        {
            InitializeComponent();
            //Init();
            bindingSource.DataSource = new KyHoc();
        }
        public AddKyHocForm(KyHoc kyHoc) : base()
        {
            InitializeComponent();
        }
        protected override void Init()
        {
            this.maKyHocTextEdit.Enabled = false;
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.Label hocPhiLabel;
            System.Windows.Forms.Label kyHocLabel;
            System.Windows.Forms.Label maKyHocLabel;
            System.Windows.Forms.Label namHocLabel;
            this.hocPhiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.kyHocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maKyHocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.namHocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.add_button = new System.Windows.Forms.Button();
            hocPhiLabel = new System.Windows.Forms.Label();
            kyHocLabel = new System.Windows.Forms.Label();
            maKyHocLabel = new System.Windows.Forms.Label();
            namHocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(816, 572);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.add_button);
            this.panel2.Location = new System.Drawing.Point(0, 572);
            this.panel2.Size = new System.Drawing.Size(816, 149);
            this.panel2.Controls.SetChildIndex(this.add_button, 0);
            // 
            // hocPhiLabel
            // 
            hocPhiLabel.AutoSize = true;
            hocPhiLabel.Location = new System.Drawing.Point(59, 282);
            hocPhiLabel.Name = "hocPhiLabel";
            hocPhiLabel.Size = new System.Drawing.Size(68, 20);
            hocPhiLabel.TabIndex = 0;
            hocPhiLabel.Text = "Học Phí:";
            // 
            // kyHocLabel
            // 
            kyHocLabel.AutoSize = true;
            kyHocLabel.Location = new System.Drawing.Point(59, 248);
            kyHocLabel.Name = "kyHocLabel";
            kyHocLabel.Size = new System.Drawing.Size(63, 20);
            kyHocLabel.TabIndex = 2;
            kyHocLabel.Text = "Kỳ Học:";
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Location = new System.Drawing.Point(59, 180);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(89, 20);
            maKyHocLabel.TabIndex = 4;
            maKyHocLabel.Text = "Mã Kỳ Học:";
            // 
            // namHocLabel
            // 
            namHocLabel.AutoSize = true;
            namHocLabel.Location = new System.Drawing.Point(59, 214);
            namHocLabel.Name = "namHocLabel";
            namHocLabel.Size = new System.Drawing.Size(79, 20);
            namHocLabel.TabIndex = 6;
            namHocLabel.Text = "Năm Học:";
            // 
            // hocPhiTextEdit
            // 
            this.hocPhiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "HocPhi", true));
            this.hocPhiTextEdit.Location = new System.Drawing.Point(154, 279);
            this.hocPhiTextEdit.Name = "hocPhiTextEdit";
            this.hocPhiTextEdit.Size = new System.Drawing.Size(150, 28);
            this.hocPhiTextEdit.TabIndex = 1;
            // 
            // kyHocTextEdit
            // 
            this.kyHocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "kyHoc", true));
            this.kyHocTextEdit.Location = new System.Drawing.Point(154, 245);
            this.kyHocTextEdit.Name = "kyHocTextEdit";
            this.kyHocTextEdit.Size = new System.Drawing.Size(150, 28);
            this.kyHocTextEdit.TabIndex = 3;
            // 
            // maKyHocTextEdit
            // 
            this.maKyHocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "MaKyHoc", true));
            this.maKyHocTextEdit.Location = new System.Drawing.Point(154, 177);
            this.maKyHocTextEdit.Name = "maKyHocTextEdit";
            this.maKyHocTextEdit.Size = new System.Drawing.Size(150, 28);
            this.maKyHocTextEdit.TabIndex = 5;
            // 
            // namHocTextEdit
            // 
            this.namHocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "NamHoc", true));
            this.namHocTextEdit.Location = new System.Drawing.Point(154, 211);
            this.namHocTextEdit.Name = "namHocTextEdit";
            this.namHocTextEdit.Size = new System.Drawing.Size(150, 28);
            this.namHocTextEdit.TabIndex = 7;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(229, 20);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 29);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Thêm";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // AddKyHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(816, 721);
            this.Name = "AddKyHocForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hocPhiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyHocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKyHocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namHocTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            KyHoc kyHoc = bindingSource.Current as KyHoc;
            if (kyHoc == null) return;
            ValidationContext context = new ValidationContext(kyHoc, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(kyHoc, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.KyHoc.Add(kyHoc))
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
