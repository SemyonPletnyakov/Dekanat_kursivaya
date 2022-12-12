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
    public partial class SpecialnostTableForm : Form
    {
        public SpecialnostTableForm()
        {
            InitializeComponent();
        }

        private void SpecialnostTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.SpecialnostView". При необходимости она может быть перемещена или удалена.
            this.specialnostViewTableAdapter.Fill(this.dB_GroupsDataSet.SpecialnostView);

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

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
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

            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
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

            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
        }

        private void insertActiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand1.CommandText = $"INSERT INTO Specialnost " +
                       $"VALUES " +
                       $"('{textBox1.Text.Trim()}', " +
                       $"'{textBox2.Text.Trim()}'," +
                       $"'{textBox3.Text.Trim()}'," +
                       $"{textBox4.Text.Trim()}," +
                       $"'{textBox5.Text.Trim()}')";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                specialnostViewTableAdapter.Fill(dB_GroupsDataSet.SpecialnostView);
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
                sqlCommand1.CommandText = $"UPDATE Specialnost SET " +
                       $"cod_specialnosti = '{textBox10.Text.Trim()}', " +
                       $"abbreviatura = '{textBox9.Text.Trim()}'," +
                       $"nazvanie_specialnosti = '{textBox8.Text.Trim()}'," +
                       $"let_obucheniya = {textBox7.Text.Trim()}," +
                       $"institut = '{textBox6.Text.Trim()}'" +
                       $" WHERE " +
                       $"cod_specialnosti ='{textBox1.Text.Trim()}'";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                specialnostViewTableAdapter.Fill(dB_GroupsDataSet.SpecialnostView);
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
                sqlCommand1.CommandText = $"DELETE FROM Specialnost " +
                       $" WHERE " +
                       $"cod_specialnosti ='{textBox1.Text.Trim()}'";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                specialnostViewTableAdapter.Fill(dB_GroupsDataSet.SpecialnostView);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }
    }
}
