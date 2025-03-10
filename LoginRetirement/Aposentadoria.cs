using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRetirement
{
    public partial class Aposentadoria : Form
    {
        public Aposentadoria()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click_1(object sender, EventArgs e)
        {
            DateTime birthDate = dateTimePicker.Value;
            string gender = comboBoxGenero.SelectedItem?.ToString();
            int retirementAge;

            if (gender == "Homem")
            {
                retirementAge = 65;
            }
            else if (gender == "Mulher")
            {
                retirementAge = 62;
            }
            else
            {
                MessageBox.Show("Por favor, selecione um gênero válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime retirementDate = birthDate.AddYears(retirementAge);
            TimeSpan timeLeft = retirementDate - DateTime.Today;

            if (timeLeft.TotalDays > 0)
            {
                MessageBox.Show($"Faltam {timeLeft.Days} dias para a aposentadoria.", "Cálculo de Aposentadoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você já está elegível para aposentadoria!", "Cálculo de Aposentadoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
