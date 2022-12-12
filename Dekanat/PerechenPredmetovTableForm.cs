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
    public partial class PerechenPredmetovTableForm : Form
    {
        public PerechenPredmetovTableForm()
        {
            InitializeComponent();
        }

        private void PerechenPredmetovTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.Perechen_predmetovView". При необходимости она может быть перемещена или удалена.
            this.perechen_predmetovViewTableAdapter.Fill(this.dB_GroupsDataSet.Perechen_predmetovView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.Perechen_predmetov". При необходимости она может быть перемещена или удалена.
            this.perechen_predmetovTableAdapter.Fill(this.dB_GroupsDataSet.Perechen_predmetov);

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            insertButton.BackColor = SystemColors.Window;
            updateButton.BackColor = SystemColors.ControlLight;
            deleteButton.BackColor = SystemColors.ControlLight;
            insertButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatAppearance.BorderSize = 1;
            deleteButton.FlatAppearance.BorderSize = 1;
            insertActiveButton.Visible = true;
            updateActiveButton.Visible = false;
            deleteActiveButton.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox2.Visible = false;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            insertButton.BackColor = SystemColors.ControlLight;
            updateButton.BackColor = SystemColors.Window;
            deleteButton.BackColor = SystemColors.ControlLight;
            insertButton.FlatAppearance.BorderSize = 1;
            updateButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatAppearance.BorderSize = 1;
            insertActiveButton.Visible = false;
            updateActiveButton.Visible = true;
            deleteActiveButton.Visible = false;
            
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            insertButton.BackColor = SystemColors.ControlLight;
            updateButton.BackColor = SystemColors.ControlLight;
            deleteButton.BackColor = SystemColors.Window;
            insertButton.FlatAppearance.BorderSize = 1;
            updateButton.FlatAppearance.BorderSize = 1;
            deleteButton.FlatAppearance.BorderSize = 0;
            insertActiveButton.Visible = false;
            updateActiveButton.Visible = false;
            deleteActiveButton.Visible = true;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox2.Visible = false;
        }

        private void insertActiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand1.CommandText = $"INSERT INTO Perechen_predmetov " +
                       $"VALUES " +
                       $"('{textBox1.Text.Trim()}')";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                perechen_predmetovViewTableAdapter.Fill(dB_GroupsDataSet.Perechen_predmetovView);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void updateActiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand1.CommandText = $"UPDATE Perechen_predmetov SET " +
                       $"nazvanie_predmeta='{textBox2.Text.Trim()}'" +
                       $" WHERE " +
                       $" nazvanie_predmeta='{textBox1.Text.Trim()}' ";
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            perechen_predmetovViewTableAdapter.Fill(dB_GroupsDataSet.Perechen_predmetovView);
            dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void deleteActiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand1.CommandText = $"DELETE FROM Perechen_predmetov" +
                       $" WHERE " +
                       $" nazvanie_predmeta='{textBox1.Text.Trim()}' ";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                perechen_predmetovViewTableAdapter.Fill(dB_GroupsDataSet.Perechen_predmetovView);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }
    }
}
