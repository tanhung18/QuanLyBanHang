using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Functions
{
    public partial class FrmDanhMucKhachHang : Form
    {
        public FrmDanhMucKhachHang()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyBanHangDataSet);

        }

        private void FrmDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyBanHangDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dBQuanLyBanHangDataSet.customers);

        }

        
    }
}
