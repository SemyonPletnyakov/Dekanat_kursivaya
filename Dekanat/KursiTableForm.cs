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
    public partial class KursiTableForm : Form
    {
        public KursiTableForm()
        {
            InitializeComponent();
        }

        private void KursiTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.KursiView". При необходимости она может быть перемещена или удалена.
            this.kursiViewTableAdapter.Fill(this.dB_GroupsDataSet.KursiView);

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

            ulabel4.Visible = false;
            ulabel5.Visible = false;
            ulabel6.Visible = false;
            ulabel7.Visible = false;
            ulabel8.Visible = false;
            ucheckBox2.Visible = false;
            ucomboBox2.Visible = false;
            utextBox2.Visible = false;

            comboBox1.Visible = true;
            checkBox1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
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

            ulabel4.Visible = true;
            ulabel5.Visible = true;
            ulabel6.Visible = true;
            ulabel7.Visible = true;
            ulabel8.Visible = true;
            ucheckBox2.Visible = true;
            ucomboBox2.Visible = true;
            utextBox2.Visible = true;
            comboBox1.Visible = false;
            checkBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
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

            ulabel4.Visible = false;
            ulabel5.Visible = false;
            ulabel6.Visible = false;
            ulabel7.Visible = false;
            ulabel8.Visible = false;
            ucheckBox2.Visible = false;
            ucomboBox2.Visible = false;
            utextBox2.Visible = false;
            comboBox1.Visible = false;
            checkBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            comboBox1.Visible = false;
            checkBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kursiViewBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void insertActiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int sostoyanie = 0;
                if (checkBox1.Checked)
                    sostoyanie = 1;
                sqlCommand1.CommandText = $"INSERT INTO Kursi VALUES " +
                       $"({textBox1.Text.Trim()}," +
                       $"{comboBox1.Text.Trim()},{sostoyanie})";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                kursiViewTableAdapter.Fill(dB_GroupsDataSet.KursiView);
                dataGridView1.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void updateActiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int sostoyanie = 0;
                if (ucheckBox2.Checked)
                    sostoyanie = 1;
                sqlCommand1.CommandText = $"UPDATE Kursi SET " +
                       $"god_nachala={utextBox2.Text.Trim()}," +
                       $"nomer_kursa={ucomboBox2.Text.Trim()}," +
                       $"sostoyanie={sostoyanie} " +
                       $" WHERE " +
                       $" god_nachala={textBox1.Text.Trim()} ";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                kursiViewTableAdapter.Fill(dB_GroupsDataSet.KursiView);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            /*int numberRow = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1[0, numberRow].Value.ToString().Trim();
            comboBox1.Text = dataGridView1[1, numberRow].Value.ToString().Trim();
            if(dataGridView1[2, numberRow].Value.ToString().Trim()=="True")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }*/
        }

        private void deleteActiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand1.CommandText = $"DELETE FROM Kursi" +
                       $" WHERE " +
                       $" god_nachala={textBox1.Text.Trim()} ";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                kursiViewTableAdapter.Fill(dB_GroupsDataSet.KursiView);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }
    }
}
