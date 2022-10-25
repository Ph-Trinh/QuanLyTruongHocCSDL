using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Forms.FormSinhVien;
using QuanLyTruongHoc.Helpers.Convert;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms
{
    public partial class BaseListForm : Form
    {
        public BaseListForm()
        {
            InitializeComponent();
        }

        private void BaseListForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Show context menu on selected row
                dataGridView.ClearSelection();
                dataGridView.Rows[e.RowIndex].Selected = true;
                contextMenuStrip1.Show(dataGridView, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        protected virtual void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        protected virtual void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        protected virtual void search_btn_Click(object sender, EventArgs e)
        {

        }

        protected virtual void add_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
