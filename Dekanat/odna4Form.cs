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
    public partial class odna4Form : Form
    {
        public odna4Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                sqlCommand1.Parameters["@nazvanie_gruppi"].Value = $"{comboBox1.Text.Trim()}";
                sqlCommand1.Parameters["@semestr"].Value = Convert.ToInt32(comboBox2.Text.Trim());
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

        private void odna4Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.Gruppi". При необходимости она может быть перемещена или удалена.
            this.gruppiTableAdapter.Fill(this.dB_GroupsDataSet.Gruppi);

        }
    }
}
