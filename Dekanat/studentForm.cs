using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dekanat
{
    public partial class studentForm : Form
    {
        public studentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand1.Parameters["@nom_zachotki"].Value = $"{textBox1.Text.Trim()}";
                sqlConnection1.Open();
                DataTable dt = new DataTable();
                dt.Load(sqlCommand1.ExecuteReader());
                dataGridView1.DataSource = dt.DefaultView;
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }
    }
}
