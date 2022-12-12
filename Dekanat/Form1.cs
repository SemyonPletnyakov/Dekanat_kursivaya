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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StudentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentiTableForm form2 = new StudentiTableForm();
            form2.Show();
        }

        private void GruppiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GruppiTableForm form3 = new GruppiTableForm();
            form3.Show();
        }

        private void KursiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KursiTableForm form4 = new KursiTableForm();
            form4.Show();
        }

        private void SpecialnostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecialnostTableForm form5 = new SpecialnostTableForm();
            form5.Show();
        }

        private void ResultatiSessiyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultatiSessiyTableForm form6 = new ResultatiSessiyTableForm();
            form6.Show();
        }

        private void UchebniyPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UchebniyPlanTableForm form7 = new UchebniyPlanTableForm();
            form7.Show();
        }

        private void PerechenPredmetovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerechenPredmetovTableForm form8 = new PerechenPredmetovTableForm();
            form8.Show();
        }

        private void otlichniciPoslednyayaButton_Click(object sender, EventArgs e)
        {
            otlichniciForm form9 = new otlichniciForm();
            form9.Show();
        }

        private void odna4Button_Click(object sender, EventArgs e)
        {
            odna4Form form10 = new odna4Form();
            form10.Show();
        }

        private void dvoechnikiButton_Click(object sender, EventArgs e)
        {
            dvoechnikiForm form11 = new dvoechnikiForm();
            form11.Show();
        }

        private void zachotnayaVedomostButton_Click(object sender, EventArgs e)
        {
            zachotnayaVedomostForm form12 = new zachotnayaVedomostForm();
            form12.Show();
        }

        private void uchebniyPlanButton_Click(object sender, EventArgs e)
        {
            uchebniyPlanForm form13 = new uchebniyPlanForm();
            form13.Show();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            studentForm form14 = new studentForm();
            form14.Show();
        }

        private void утвердитьУчебныйПланToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report1.Show();
        }

        private void утвердитьСписокСпециальностейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report2.Show();
        }

        private void справкаОбОбученииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spravkaForm form15 = new spravkaForm();
            form15.Show();
        }
    }
}
