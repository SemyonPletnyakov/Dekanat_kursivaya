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
    public partial class UchebniyPlanTableForm : Form
    {
        public UchebniyPlanTableForm()
        {
            InitializeComponent();
        }

        private void UchebniyPlanTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.Perechen_predmetov". При необходимости она может быть перемещена или удалена.
            this.perechen_predmetovTableAdapter.Fill(this.dB_GroupsDataSet.Perechen_predmetov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.Specialnost". При необходимости она может быть перемещена или удалена.
            this.specialnostTableAdapter.Fill(this.dB_GroupsDataSet.Specialnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.Uchebniy_planView". При необходимости она может быть перемещена или удалена.
            this.uchebniy_planViewTableAdapter.Fill(this.dB_GroupsDataSet.Uchebniy_planView);

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

            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;

            label4.Visible = true;
            comboBox4.Visible = true;
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

            comboBox5.Visible = true;
            comboBox6.Visible = true;
            comboBox7.Visible = true;
            comboBox8.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;

            label4.Visible = false;
            comboBox4.Visible = false;
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

            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;

            label4.Visible = false;
            comboBox4.Visible = false;
        }

        private void insertActiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand1.CommandText= $"INSERT INTO Uchebniy_plan " +
                       $"VALUES " +
                       $"((SELECT cod_specialnosti FROM Specialnost " +
                             $" WHERE " +
                             $"nazvanie_specialnosti='{comboBox1.Text.ToString().Trim()}')," +
                       $"(SELECT cod_predmeta FROM Perechen_predmetov " +
                             $" WHERE " +
                             $"nazvanie_predmeta='{comboBox2.Text.ToString().Trim()}')," +
                       $"{comboBox3.Text.ToString().Trim()}," +
                       $"'{comboBox4.Text.ToString().Trim()}')";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                uchebniy_planViewTableAdapter.Fill(dB_GroupsDataSet.Uchebniy_planView);
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
                sqlCommand1.CommandText = $"UPDATE Uchebniy_plan SET " +
                       $"cod_specialnosti = (SELECT cod_specialnosti FROM Specialnost " +
                             $" WHERE " +
                             $"nazvanie_specialnosti='{comboBox8.Text.ToString().Trim()}')," +
                       $"cod_predmeta = (SELECT cod_predmeta FROM Perechen_predmetov " +
                             $" WHERE " +
                             $"nazvanie_predmeta='{comboBox7.Text.ToString().Trim()}')," +
                       $"semestr = {comboBox6.Text.ToString().Trim()}," +
                       $"froma_otchotnosti = '{comboBox5.Text.ToString().Trim()}'" +
                       $" WHERE " +
                       $"cod_specialnosti = (SELECT cod_specialnosti FROM Specialnost " +
                             $" WHERE " +
                             $"nazvanie_specialnosti='{comboBox1.Text.ToString().Trim()}') AND " +
                       $"cod_predmeta = (SELECT cod_predmeta FROM Perechen_predmetov " +
                             $" WHERE " +
                             $"nazvanie_predmeta='{comboBox2.Text.ToString().Trim()}') AND " +
                       $"semestr = {comboBox3.Text.ToString().Trim()}";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                uchebniy_planViewTableAdapter.Fill(dB_GroupsDataSet.Uchebniy_planView);
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
                sqlCommand1.CommandText = $"DELETE FROM Uchebniy_plan " +
                       $" WHERE " +
                       $"cod_specialnosti = (SELECT cod_specialnosti FROM Specialnost " +
                             $" WHERE " +
                             $"nazvanie_specialnosti='{comboBox1.Text.ToString().Trim()}') AND " +
                       $"cod_predmeta = (SELECT cod_predmeta FROM Perechen_predmetov " +
                             $" WHERE " +
                             $"nazvanie_predmeta='{comboBox2.Text.ToString().Trim()}') AND " +
                       $"semestr = {comboBox3.Text.ToString().Trim()}";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                uchebniy_planViewTableAdapter.Fill(dB_GroupsDataSet.Uchebniy_planView);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            uchebniyplanViewBindingSource.Filter = $"[Специальность] = '{dataGridView1[0, bb].Value.ToString().Trim()}'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            uchebniyplanViewBindingSource.Filter = $"[Семестр] = {dataGridView1[2, bb].Value.ToString().Trim()}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            uchebniyplanViewBindingSource.Filter = $"[Семестр] = {dataGridView1[2, bb].Value.ToString().Trim()} AND [Специальность] = '{dataGridView1[0, bb].Value.ToString().Trim()}'";
        }

        private void clearFiltrButton_Click(object sender, EventArgs e)
        {
            uchebniyplanViewBindingSource.Filter = "";
        }
    }
}
