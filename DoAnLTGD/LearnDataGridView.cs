using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTGD
{
    public partial class LearnDataGridView : Form
    {
        DataTable table = new DataTable();
        int index;

        public LearnDataGridView()
        {
            InitializeComponent();
        }

        private void LearnDataGridView_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("First Nam", Type.GetType("System.String"));
            table.Columns.Add("Last Name", Type.GetType("System.String"));
            table.Columns.Add("Sum", Type.GetType("System.Double"));
            dgvDemo.DataSource = table;

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtID.Text, txtFirstName.Text, txtLastName.Text, txtSum.Text);
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            txtID.Text = String.Empty; txtFirstName.Text = String.Empty; txtLastName.Text = String.Empty; txtSum.Text = String.Empty;
        }

        private void dgvDemo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgvDemo.Rows[index];
            txtID.Text = row.Cells[0].Value.ToString();
            txtFirstName.Text = row.Cells[1].Value.ToString();
            txtLastName.Text = row.Cells[2].Value.ToString();
            txtSum.Text = row.Cells[3].Value.ToString();

        }

        private void btUppdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dgvDemo.Rows[index];
            newdata.Cells[0].Value = txtID.Text;
            newdata.Cells[1].Value = txtFirstName.Text;
            newdata.Cells[2].Value = txtLastName.Text;
            newdata.Cells[3].Value = txtSum.Text;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            index = dgvDemo.CurrentCell.RowIndex;
            dgvDemo.Rows.RemoveAt(index);
        }
    }
}
