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
    public partial class NewStudent : Form
    {
        public Student student;
       
        public NewStudent()
        {
            InitializeComponent();
        }

        private void btnDodadiNov_Click(object sender, EventArgs e)
        {
            if(tbIme.Text != "" && tbPrezime.Text != "" && tbIndeks.Text != "")
            {
                student = new Students.Student(tbIme.Text, tbPrezime.Text, tbIndeks.Text);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Сите полиња се задолжителни.");
            }
        }

        private void tbIme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPrezime.Focus();
                btnDodadiNov.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnOtkazi.PerformClick();
            }
        }

        private void tbPrezime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbIndeks.Focus();
                btnDodadiNov.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnOtkazi.PerformClick();
            }
        }

        private void tbIndeks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDodadiNov.Focus();
                btnDodadiNov.PerformClick();
            }
            if(e.KeyCode == Keys.Escape)
            {
                btnOtkazi.PerformClick();
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            tbIme.Clear();
            tbPrezime.Clear();
            tbIndeks.Clear();
            Close();
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if(tbIme.Text == "") {
                e.Cancel = true;
                errorProvider1.SetError(tbIme, "Името е задолжително.");
            }
            else
            {
                errorProvider1.SetError(tbIme, null);
            }
        }

        private void tbPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrezime.Text == "")
            {
                e.Cancel = true;
                errorProvider2.SetError(tbPrezime, "Презимето е задолжително.");
            }
            else
            {
                errorProvider2.SetError(tbPrezime, null);
            }
        }

        private void tbIndeks_Validating(object sender, CancelEventArgs e)
        {
            if (validateID(tbIndeks.Text))
            {
                errorProvider1.SetError(tbIndeks, null);
                
            }
            else
            {
                e.Cancel = true;
                errorProvider3.SetError(tbIndeks, "Името е задолжително.");
            }
        }

        bool validateID(string number)
        {
            if (number.Length != 6) return false;
            foreach(char c in number)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return number[0] == '1';
        }
    }
}
