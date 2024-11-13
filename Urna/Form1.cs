using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urna.classes;

namespace Urna
{
    public partial class frmUrna : Form
    {
        List<Candidatos> listaCandidatos = new List<Candidatos>();




        public frmUrna()
        {
            InitializeComponent();

            Candidatos c1 = new Candidatos()
            {
                Numero = 1910,
                Candidato = "Sport Club Corinthians Paulista",
                NomePopular = "Corinthians",
                Foto = Properties.Resources.corinthians
            };



            listaCandidatos.Add(c1);

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblNum1.Text.Length < 1)
            {
                lblNum1.Text = "1";
            }
            else if (lblNum2.Text.Length < 1)
            {
                lblNum2.Text = "1";

                int candidatoNumber = int.Parse(lblNum1.Text + lblNum2.Text);

                foreach (Candidatos candidato in listaCandidatos)
                {
                    if (candidato.Numero == candidatoNumber)
                    {
                        lblNomeTime2.Text = candidato.Candidato;
                        lblNomePopular2.Text = candidato.NomePopular;
                        picTimes.Image = candidato.Foto;
                    }
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
        }

        private void btn3_Click(object sender, EventArgs e)
        {
        }

        private void btn4_Click(object sender, EventArgs e)
        {
        }

        private void btn5_Click(object sender, EventArgs e)
        {
        }

        private void btn6_Click(object sender, EventArgs e)
        {
        }

        private void btn7_Click(object sender, EventArgs e)
        {
        }

        private void btn8_Click(object sender, EventArgs e)
        {
        }

        private void btn9_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void lblNomePopular2_Click(object sender, EventArgs e)
        {

        }

        private void btnBranco_Click(object sender, EventArgs e)
        {

        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {


        }
    }
}
