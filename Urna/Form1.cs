using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna
{
    public partial class frmUrna : Form
    {
        private Dictionary<string, Candidato> _dicCandidato;

        public frmUrna()
        {
            InitializeComponent();
            _dicCandidato = new Dictionary<string, Candidato>();
            _dicCandidato.Add("1910", new Candidato() { Id = 1910, Nome = "Corinthians Paulsita Futebol Clube", NomePopular = "Corinthians", Foto = Properties.Resources.corinthians });
            _dicCandidato.Add("1912", new Candidato() { Id = 1912, Nome = "Santos Futebol Clube", NomePopular = "Santos", Foto = Properties.Resources.santos });
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            RegistrarDigito("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            RegistrarDigito("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            RegistrarDigito("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            RegistrarDigito("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            RegistrarDigito("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            RegistrarDigito("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            RegistrarDigito("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            RegistrarDigito("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            RegistrarDigito("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RegistrarDigito("0");
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {

        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {

        }

        private void btnBranco_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarDigito(string digito)
        {
            if (string.IsNullOrEmpty(lblNumero1.Text))
                lblNumero1.Text = digito;
            else
            {
                lblNumero1.Text = digito;
                PreencherCandidato(lblNumero1.Text, lblNumero2.Text, lblNumero3.Text, lblNumero4.Text);
            }
        }

        private void PreencherCandidato(string d1, string d2, string d3, string d4)
        {
            if (_dicCandidato.ContainsKey(d1 + d2 + d3 + d4))
            {
                lblNomeTime2.Text = _dicCandidato[d1 + d2 + d3 + d4].Nome;
                lblNomePopular2.Text = _dicCandidato[d1 + d2 + d3 + d4].NomePopular;
                picTimes.Image = _dicCandidato[d1 + d2 + d3 + d4].Foto;
            }
            else
            {
                MessageBox.Show("Candidato Não Encontrado!");
            }
        }

        public class Candidato
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string NomePopular { get; set; }
            public Image Foto { get; set; }
        }

        private void lblNomePopular2_Click(object sender, EventArgs e)
        {

        }
    }
}
