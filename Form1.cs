using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeMoedas
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double valor = 0;
            double cotacao = 0;
            double resultado = 0;
            object tipo = cboPara.Text;
            string tipoDe = cboDe.Text;
            string tipoPara = cboPara.Text;


            if (String.IsNullOrEmpty(txtValor.Text) || Convert.ToDouble(txtValor.Text) == 0)
            {
                MessageBox.Show("Informe o valor para conversão de " + tipoDe + " para " + tipoPara);
            }
            else
            {
                valor = Convert.ToDouble(txtValor.Text);
            }


            if (String.IsNullOrEmpty(txtCotacao.Text) || Convert.ToDouble(txtCotacao.Text) == 0)
            {
                MessageBox.Show("Informe a cotação do " + tipo);
            }
            else
            {
                cotacao = Convert.ToDouble(txtCotacao.Text);
                resultado = valor / cotacao;

                txtResultado.Text = String.Format("{0:0.00}", resultado);
                
            }
                
        }

        private void cboDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            object tipoDe = cboDe.SelectedItem;
            object tipoPara = cboPara.SelectedItem;

            lblCotacao.Text = "Cotação do " + tipoPara.ToString();

            switch (tipoDe.ToString())
            {
                case "Real (R$)":
                    switch (tipoPara.ToString())
                    {
                        case "Dólar (US$)":
                            txtCotacao.Text = "5,42";
                            break;
                        case "Euro (EU €)":
                            txtCotacao.Text = "6,42";
                            break;
                        default:
                            txtCotacao.Text = "1,00";
                            break;
                    }
                    break;
                case "Dólar (US$)":
                    switch (tipoPara.ToString())
                    {
                        case "Real (R$)":
                            txtCotacao.Text = "0,18";
                            break;
                        case "Euro (EU €)":
                            txtCotacao.Text = "1,18";
                            break;
                        default:
                            txtCotacao.Text = "1,00";
                            break;
                    }
                    break;
                default: //Euro (EU €)
                    switch (tipoPara.ToString())
                    {
                        case "Real (R$)":
                            txtCotacao.Text = "0,16";
                            break;
                        case "Dólar (US$)":
                            txtCotacao.Text = "0,84";
                            break;
                        default:
                            txtCotacao.Text = "1,00";
                            break;
                    }
                    break;
            }
        }

        private void cboPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            object tipoDe = cboDe.SelectedItem;
            object tipoPara = cboPara.SelectedItem;

            lblCotacao.Text = "Cotação do " + tipoPara.ToString();

            switch (tipoDe.ToString())
            {
                case "Real (R$)":
                    switch (tipoPara.ToString())
                    {
                        case "Dólar (US$)":
                            txtCotacao.Text = "5,42";
                            break;
                        case "Euro (EU €)":
                            txtCotacao.Text = "6,42";
                            break;
                        default:
                            txtCotacao.Text = "1,00";
                            break;
                    }
                    break;
                case "Dólar (US$)":
                    switch (tipoPara.ToString())
                    {
                        case "Real (R$)":
                            txtCotacao.Text = "0,18";
                            break;
                        case "Euro (EU €)":
                            txtCotacao.Text = "1,18";
                            break;
                        default:
                            txtCotacao.Text = "1,00";
                            break;
                    }
                    break;
                default: //Euro (EU €)
                    switch (tipoPara.ToString())
                    {
                        case "Real (R$)":
                            txtCotacao.Text = "0,16";
                            break;
                        case "Dólar (US$)":
                            if (tipoPara.ToString() == "Dólar (US$)")
                            {
                                txtCotacao.Text = "0,84";
                            }
                            break;
                        default:
                            txtCotacao.Text = "1,00";
                            break;
                    }
                    break;
            }
        }

        private void frmConversor_Load(object sender, EventArgs e)
        {
            txtCotacao.Text = "5,42";
        }

    }
}
