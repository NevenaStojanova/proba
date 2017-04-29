using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Students
{
    public partial class Form1 : Form
    {
        float najvisokProsek = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            if (newStudent.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                lbListaStudenti.Items.Add(newStudent.student);
        }

        private void btnGeneriraj_Click(object sender, EventArgs e)
        {
            lbDosie.Items.Clear();
            int num = (int)nudBrPredmeti.Value;
            Random r = new Random();
            for (int i = 1; i <= num; i++)
            {
                string ime = "Предмет " + i;
                int rnd = r.Next(6, 11);

                Course c = new Course(ime, rnd);
                //Student lbListaStudenti.SelectedItem;
                lbDosie.Items.Add(c);
            }

            float avg = 0;
            foreach(Course c in lbDosie.Items)
            {
                avg += (float)c.Grade;
            }
            avg = avg / lbDosie.Items.Count;
            tbProsek.Text = string.Format("{0:0.00}", avg);

            
            if (avg > najvisokProsek) najvisokProsek = avg;
            tbNajvisokProsek.Text = string.Format("{0:0.00}",najvisokProsek);
        }

        private void lbListaStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGeneriraj.Enabled = true;
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да го избришате овој студент?","Избриши студент?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lbListaStudenti.Items.RemoveAt(lbListaStudenti.SelectedIndex);
                lbListaStudenti.SelectedIndex = -1;
                btnGeneriraj.Enabled = false;
            }
        }
    }
}
