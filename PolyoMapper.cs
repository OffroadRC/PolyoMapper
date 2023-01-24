using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();  // Create a list of the alphabet for the Column headers
        private void updateColumns()
        {
            // Re-name the columns
            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            {
                
                //TODO Automatically update the column lettering
                //dataGridView1.Columns[i].HeaderText = i.ToString();


                //Automatically resize the column widths to a uniform dimension
                DataGridViewColumn column = dataGridView1.Columns[j];
                column.Width = 30;
            }
        }

        private void updateRows()
        {
            // Re-number the rows
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                //Automatically update the row numbering
                dataGridView1.Rows[j].HeaderCell.Value = j.ToString();
                bx_debug.Text += j.ToString();

                //Resize the row heights to a uniform dimension
                DataGridViewRow rows = dataGridView1.Rows[j];
                rows.Height = 30;
            }
        }

        private void btn_addColumns_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(numBx_addColumns.Text); i++)
            {
                dataGridView1.Columns.Add("columnName", "Name");
                updateColumns(); updateRows();
            }
        }

        private void btn_addRows_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(numBx_addRows.Text); i++)
            {
                dataGridView1.Rows.Add();
                updateRows(); updateColumns();
            }
        }
        //TODO: Allow insertion of 
        //dataGridView1.Rows.Insert(0, "");
    }
}
