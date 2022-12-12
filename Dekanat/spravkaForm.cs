using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace Dekanat
{
    public partial class spravkaForm : Form
    {
        public spravkaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand1.CommandText = $"SELECT fio AS 'ФИО', data_rozhdenia AS 'Дата рождения', " +
                    $"nazvanie_specialnosti AS 'Специальность',nomer_kursa AS 'Курс', Kursi.god_nachala AS 'Год начала обучения', " +
                    $"Kursi.god_nachala + let_obucheniya AS 'Дата завершения обучения',institut AS 'Институт' FROM Studenti " +
                    $"JOIN Gruppi ON Studenti.nazvanie_gruppi = Gruppi.nazvanie_gruppi " +
                    $"JOIN Kursi ON Gruppi.god_nachala = Kursi.god_nachala " +
                    $"JOIN Specialnost ON Gruppi.cod_specialnosti = Specialnost.cod_specialnosti WHERE fio = '{comboBox1.Text.Trim()}'";
                sqlConnection1.Open();
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(sqlCommand1.ExecuteReader());
                dataGridView1.DataSource = dt.DefaultView;
                sqlConnection1.Close();
                if(dataGridView1.RowCount != 0)
                {
                    string fio = dataGridView1.Rows[0].Cells[0].Value.ToString().Trim();
                    string dataRozhdeniya = dataGridView1.Rows[0].Cells[1].Value.ToString().Trim();
                    string specialnost = dataGridView1.Rows[0].Cells[2].Value.ToString().Trim();
                    string kurs = dataGridView1.Rows[0].Cells[3].Value.ToString().Trim();
                    string godNachala = dataGridView1.Rows[0].Cells[4].Value.ToString().Trim();
                    string godKonca = dataGridView1.Rows[0].Cells[5].Value.ToString().Trim();
                    string institut = dataGridView1.Rows[0].Cells[6].Value.ToString().Trim();

                    string pathShablona = "C:\\Проекты\\Dekanat\\spravkaShablon.docx";

                    var wordAplication = new Microsoft.Office.Interop.Word.Application();
                    wordAplication.Visible = false;
                    var wordDocument = wordAplication.Documents.Open(pathShablona);
                    wordDocument.Content.Find.ClearFormatting();
                    wordDocument.Content.Find.Execute(FindText: "<FIO>", ReplaceWith: fio);
                    wordDocument.Content.Find.ClearFormatting();
                    wordDocument.Content.Find.Execute(FindText: "<dataRozhdenia>", ReplaceWith: dataRozhdeniya);
                    wordDocument.Content.Find.ClearFormatting();
                    wordDocument.Content.Find.Execute(FindText: "<Specialnost>", ReplaceWith: specialnost);
                    wordDocument.Content.Find.ClearFormatting();
                    wordDocument.Content.Find.Execute(FindText: "<kurs>", ReplaceWith: kurs);
                    wordDocument.Content.Find.ClearFormatting();
                    wordDocument.Content.Find.Execute(FindText: "<godNachala>", ReplaceWith: godNachala);
                    wordDocument.Content.Find.ClearFormatting();
                    wordDocument.Content.Find.Execute(FindText: "<godKonca>", ReplaceWith: godKonca);
                    wordDocument.Content.Find.ClearFormatting();
                    wordDocument.Content.Find.Execute(FindText: "<Institut>", ReplaceWith: institut);
                    wordDocument.Content.Find.ClearFormatting();
                    wordDocument.Content.Find.Execute(FindText: "<DayNow>", ReplaceWith: System.DateTime.Today.ToString("d"));
                    wordDocument.SaveAs2($"C:\\Проекты\\Dekanat\\справки\\справка {fio}.docx");
                    wordAplication.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void spravkaForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_GroupsDataSet.Studenti". При необходимости она может быть перемещена или удалена.
            this.studentiTableAdapter.Fill(this.dB_GroupsDataSet.Studenti);

        }
    }
}
