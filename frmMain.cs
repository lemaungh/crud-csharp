using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Student
{
    public partial class frmMain: Form
    {   
        DataTable dataTable = new DataTable();
        public frmMain()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string query = "select * from tblSubject";
            dataTable.Clear();
            dataTable = DataProvider.loadData(query);
            dtgvMonHoc.DataSource = dataTable;
        }
    }
}
