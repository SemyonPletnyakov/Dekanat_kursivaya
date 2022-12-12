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
    public partial class ResultatiSessiyTableForm : Form
    {
        public ResultatiSessiyTableForm()
        {
            InitializeComponent();
        }

        private void ResultatiSessiyTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.Perechen_predmetov". При необходимости она может быть перемещена или удалена.
            this.perechen_predmetovTableAdapter.Fill(this.dB_GroupsDataSet.Perechen_predmetov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.Resultati_sessiyView". При необходимости она может быть перемещена или удалена.
            this.resultati_sessiyViewTableAdapter.Fill(this.dB_GroupsDataSet.Resultati_sessiyView);

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

            textBox3.Visible = false;
            textBox4.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
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

            textBox3.Visible = true;
            textBox4.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            comboBox6.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
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

            textBox3.Visible = false;
            textBox4.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
        }

        private void insertActiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand1.CommandText = $"INSERT INTO Resultati_sessiy " +
                       $"VALUES " +
                       $"('{textBox1.Text.Trim()}'," +
                       $"(SELECT cod_zachota FROM Uchebniy_plan WHERE " +
                            $"cod_specialnosti = (SELECT cod_specialnosti FROM Studenti JOIN Gruppi " +
                                $" ON Studenti.nazvanie_gruppi = Gruppi.nazvanie_gruppi " +
                                $" WHERE nom_zachotki = '{textBox1.Text.Trim()}')" +
                            $" AND " +
                            $"cod_predmeta = (SELECT cod_predmeta FROM Perechen_predmetov " +
                                 $" WHERE " +
                                 $"nazvanie_predmeta='{comboBox1.Text.ToString().Trim()}')" +
                            $" AND " +
                            $"semestr = {comboBox2.Text.Trim()}),"+
                       $"'{comboBox3.Text.Trim()}'," +
                       $"{textBox2.Text.Trim()})";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                resultati_sessiyViewTableAdapter.Fill(dB_GroupsDataSet.Resultati_sessiyView);
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
                sqlCommand1.CommandText = $"UPDATE Resultati_sessiy " +
                       $" SET " +
                       $"nom_zachotki = '{textBox4.Text.Trim()}'," +
                       $"cod_zachota = (SELECT cod_zachota FROM Uchebniy_plan WHERE " +
                            $"cod_specialnosti = (SELECT cod_specialnosti FROM Studenti JOIN Gruppi " +
                                $" ON Studenti.nazvanie_gruppi = Gruppi.nazvanie_gruppi " +
                                $" WHERE nom_zachotki = '{textBox4.Text.Trim()}')" +
                            $" AND " +
                            $"cod_predmeta = (SELECT cod_predmeta FROM Perechen_predmetov " +
                                 $" WHERE " +
                                 $"nazvanie_predmeta='{comboBox6.Text.ToString().Trim()}')" +
                            $" AND " +
                            $"semestr = {comboBox5.Text.Trim()})," +
                       $"ocenka = '{comboBox4.Text.Trim()}'," +
                       $"nomer_popitki = {textBox3.Text.Trim()}" +
                       $" WHERE " +
                       $"nom_zachotki = '{textBox1.Text.Trim()}'" +
                       $" AND cod_zachota = (SELECT cod_zachota FROM Uchebniy_plan WHERE " +
                            $"cod_specialnosti = (SELECT cod_specialnosti FROM Studenti JOIN Gruppi " +
                                $" ON Studenti.nazvanie_gruppi = Gruppi.nazvanie_gruppi " +
                                $" WHERE nom_zachotki = '{textBox1.Text.Trim()}')" +
                            $" AND " +
                            $"cod_predmeta = (SELECT cod_predmeta FROM Perechen_predmetov " +
                                 $" WHERE " +
                                 $"nazvanie_predmeta='{comboBox1.Text.ToString().Trim()}')" +
                            $" AND " +
                            $"semestr = {comboBox2.Text.Trim()})" +
                       $" AND ocenka = '{comboBox3.Text.Trim()}'" +
                       $" AND nomer_popitki = {textBox2.Text.Trim()}";
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            resultati_sessiyViewTableAdapter.Fill(dB_GroupsDataSet.Resultati_sessiyView);
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
                sqlCommand1.CommandText = $"DELETE FROM Resultati_sessiy " +
                       $" WHERE " +
                       $"nom_zachotki = '{textBox1.Text.Trim()}'" +
                       $" AND cod_zachota = (SELECT cod_zachota FROM Uchebniy_plan WHERE " +
                            $"cod_specialnosti = (SELECT cod_specialnosti FROM Studenti JOIN Gruppi " +
                                $" ON Studenti.nazvanie_gruppi = Gruppi.nazvanie_gruppi " +
                                $" WHERE nom_zachotki = '{textBox1.Text.Trim()}')" +
                            $" AND " +
                            $"cod_predmeta = (SELECT cod_predmeta FROM Perechen_predmetov " +
                                 $" WHERE " +
                                 $"nazvanie_predmeta='{comboBox1.Text.ToString().Trim()}')" +
                            $" AND " +
                            $"semestr = {comboBox2.Text.Trim()})" +
                       $" AND ocenka = '{comboBox3.Text.Trim()}'" +
                       $" AND nomer_popitki = {textBox2.Text.Trim()}";
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                resultati_sessiyViewTableAdapter.Fill(dB_GroupsDataSet.Resultati_sessiyView);
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
            resultatisessiyViewBindingSource.Filter = $"[Семестр] = {dataGridView1[4, bb].Value.ToString().Trim()} AND [Группа] = '{dataGridView1[2, bb].Value.ToString().Trim()}'";
        }

        private void clearFiltrButton_Click(object sender, EventArgs e)
        {
            resultatisessiyViewBindingSource.Filter = "";
        }
    }
}
