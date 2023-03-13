using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobilitec_Services
{
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = cbCidades.SelectedItem.ToString();

            MessageBox.Show("item selecionado"+valor);
        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void bntSelecione_Click(object sender, EventArgs e)
        {
            if (rdbMasculino.Checked)
            {
                MessageBox.Show("selecionou masculino");
            } 
            if (rdbFeminino.Checked)
            {
                MessageBox.Show("selecionou feminino");
            }

            if (cbblivro.Checked)
            {
                MessageBox.Show("selecionou Livro");
            }

            if (cbbAcademia.Checked)
            {
                MessageBox.Show("selecionou Academia");
            }

            if (cbbCultura.Checked)
            {
                MessageBox.Show("selecionou Cultura");
            }

            if (cbbEsporte.Checked)
            {
                MessageBox.Show("selecionou Esportes");
            }
        }

        private void btnLImpar_Click(object sender, EventArgs e)
        {
            cbCidades.Items.Clear();
            lbPreferecias.Items.Clear();
            cbCidades.Text = "";
            rdbFeminino.Checked = false;
            rdbMasculino.Checked = false;

            cbbAcademia.Checked = false;
            cbbCultura.Checked = false;
            cbbEsporte.Checked = false;
            cbblivro.Checked = false;

        }

        private void lbPreferecias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbblivro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
