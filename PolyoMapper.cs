using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyoMapper
{
    public partial class PolyoMapper : Form
    {
        public PolyoMapper()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_addColumns_Click(object sender, EventArgs e)
        {
             for (int i = 0; i < int.Parse(numBx_addColumns.Text); i++)
            {
                dataGridView1.Columns.Add("columnName", "Display Name");
            }
        }

        private void btn_addRows_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(numBx_addRows.Text); i++)
            {
                dataGridView1.Rows.Add();
            }
        }
    }
}
