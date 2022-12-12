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
    public partial class GruppiTableForm : Form
    {
        public GruppiTableForm()
        {
            InitializeComponent();
        }

        private void GruppiTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.Kursi". При необходимости она может быть перемещена или удалена.
            this.kursiTableAdapter.Fill(this.dB_GroupsDataSet.Kursi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.Specialnost". При необходимости она может быть перемещена или удалена.
            this.specialnostTableAdapter.Fill(this.dB_GroupsDataSet.Specialnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.GruppiView". При необходимости она может быть перемещена или удалена.
            this.gruppiViewTableAdapter.Fill(this.dB_GroupsDataSet.GruppiView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.Gruppi". При необходимости она может быть перемещена или удалена.
            this.gruppiTableAdapter.Fill(this.dB_GroupsDataSet.Gruppi);

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

            label2.Visible = true;
            label3.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
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

            label2.Visible = false;
            label3.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
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
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            textBox2.Visible = false;
        }

        private void insertActiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand1.CommandText = $"INSERT INTO Gruppi " +
                       $"VALUES " +
                       $"('{textBox1.Text.Trim()}', " +
                       $"{comboBox2.SelectedValue}, " +
                       $"(SELECT cod_specialnosti FROM Specialnost " +
                       $" WHERE " +
                       $"nazvanie_specialnosti='{comboBox1.SelectedValue.ToString().Trim()}'))";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                gruppiViewTableAdapter.Fill(dB_GroupsDataSet.GruppiView);
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
                sqlCommand1.CommandText = $"UPDATE Gruppi SET " +
                       $"nazvanie_gruppi='{textBox2.Text.Trim()}', " +
                       $"god_nachala={comboBox4.SelectedValue}, " +
                       $"cod_specialnosti=(SELECT cod_specialnosti FROM Specialnost " +
                             $" WHERE " +
                             $"nazvanie_specialnosti='{comboBox3.SelectedValue.ToString().Trim()}')" +
                       $" WHERE " +
                       $"nazvanie_gruppi='{textBox1.Text.Trim()}'";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                gruppiViewTableAdapter.Fill(dB_GroupsDataSet.GruppiView);
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
                sqlCommand1.CommandText = $"DELETE FROM Gruppi " +
                       $" WHERE " +
                       $"nazvanie_gruppi='{textBox1.Text.Trim()}'";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                gruppiViewTableAdapter.Fill(dB_GroupsDataSet.GruppiView);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void specialnostFilterButton_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            gruppiViewBindingSource.Filter = $"[Специальность]= '{dataGridView1[1, bb].Value.ToString().Trim()}'";
        }

        private void kursFilterButton_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            gruppiViewBindingSource.Filter = $"[Курс] = {dataGridView1[2, bb].Value.ToString().Trim()}";
        }

        private void clearFiltrButton_Click(object sender, EventArgs e)
        {
            gruppiViewBindingSource.Filter = "";
        }
    }
}
