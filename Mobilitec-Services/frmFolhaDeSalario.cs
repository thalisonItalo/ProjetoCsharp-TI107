using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobilitec_Services
{

    public partial class frmFolhaDeSalario : Form
    {
        public frmFolhaDeSalario()
        {
            InitializeComponent();

        }
        double salario = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtsalariofolha.Text = txtsalario.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            salario = Convert.ToDouble(txtsalariofolha.Text);
            double porcent;

            if (salario <= 1903.98)
            {
                porcent = 0;
                txtImposto.Text = porcent.ToString();
            }


            if (salario >= 1903.99 && salario <= 2826.65)
            {
                salario = (salario * 7.5 / 100);
                txtImposto.Text = salario.ToString();

            }

            if (salario >= 2326.65 && salario <= 3751.05)
            {
                salario = (salario * 15 / 100);
                txtImposto.Text = salario.ToString();
            }

            if (salario >= 3751.06 && salario <= 4664.68)
            {
                salario = (salario * 22.5 / 100);
                txtImposto.Text = salario.ToString();
            }

            if (salario >= 4664.69 )
            {
                salario = (salario * 27.5 / 100);
                txtImposto.Text = salario.ToString();
            }



        }

        private void cbPlanoDeSaude_CheckedChanged(object sender, EventArgs e)
        {
            salario = Convert.ToDouble(txtsalario.Text);

            if (cbPlanoDeSaude.Checked)
            {
                salario = salario - 50;
                txtsalariofolha.Text = salario.ToString();
            }
            else
            {
                txtsalariofolha.Text = txtsalario.Text;
            }

        }

        private void cbLazer_SelectedIndexChanged(object sender, EventArgs e)
        {
            salario = Convert.ToDouble(txtsalariofolha.Text);

            switch (cbLazer.Text)
            {
                case "Clube A":
                    salario = salario - 100;
                   
                    break;
                case "Clube B":
                    salario = salario - 50;
                  
                    break;
                case "Clube C":
                    salario = salario - 10;
                    
                    break;
                case "":
                    txtsalariofolha.Text = txtsalario.Text;
                    break;
                default:
                    break;

            }
            txtsalariofolha.Text = salario.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImposto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double var2, var3, calc;
            var2 = Convert.ToDouble(salario);
            var3 = Convert.ToDouble(txtImposto.Text);
                calc = var2 - var3;
            txtSalarioLiquido.Text = calc.ToString();
        }
    }

}
       