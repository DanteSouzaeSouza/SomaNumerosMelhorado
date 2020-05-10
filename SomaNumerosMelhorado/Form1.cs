using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaNumerosMelhorado
{
    public partial class FrmSoma : Form
    {
        public FrmSoma()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i, num, mult, soma = 0;

            // extraindo número do TextBox
            int number, multi;
            bool success = Int32.TryParse(txtNum.Text, out number);
            bool successM = Int32.TryParse(txtMultiplo.Text, out multi);
            if (success)
            {
                if (successM)
                {
                    /* inicializa o laço em 1; *
                 * testa a condição de parada: i <= num *
                 * incrementa a variavel i++ */
                    num = Convert.ToInt32(txtNum.Text);
                    mult = Convert.ToInt32(txtMultiplo.Text);
                    for (i = 1; i <= num; i++)
                    {
                        int multiplo;
                        // gera o múltiplo
                        multiplo = i * mult;
                        //faz o somatório dos números pares
                        soma += multiplo;
                        //verificando passos da soma:
                        Console.WriteLine("Múltiplo de " + mult + " a somar: " + multiplo + ". Soma = " + soma);
                    }
                    
                } else { 


                    num = Convert.ToInt32(txtNum.Text);

                    /* inicializa o laço em 1; *
                 * testa a condição de parada: i <= num *
                 * incrementa a variavel i++ */
                    for (i = 1; i <= num; i++)
                    {
                        //verifica se i é par
                        if (i % 2 == 0)
                        {
                            //faz o somatório dos números pares
                            soma += i;
                            //verificando passos da soma:
                            Console.WriteLine("Número a somar: " + i + ". Soma = " + soma);
                        }
                    }
                }

                //apresenta o total da soma dos pares no txtSoma
                txtSoma.Text = soma.ToString();
                

            }
            else
            {
                MessageBox.Show("Digite um número!");
            }
                       
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMultiplo.Clear();
            txtNum.Clear();
            txtSoma.Clear();
            txtNum.Focus();
        }
    }
}
