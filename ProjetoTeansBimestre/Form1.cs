using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTeansBimestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Iguala o número de itens no combo com o texto ao lado
            lblEstados.Text = cboEstados.Items.Count.ToString();
            lblNorte.Text = cboNorte.Items.Count.ToString();
            lblNordeste.Text = cboNordeste.Items.Count.ToString();
            lblCentro.Text = cboCentro.Items.Count.ToString();
            lblSul.Text = cboSul.Items.Count.ToString();
            lblSudeste.Text = cboSudeste.Items.Count.ToString();
        }

        private void btEstados_Click(object sender, EventArgs e)
        {
            // Verifica se existe um item selecionado no combo
            if (cboEstados.SelectedIndex != -1)
            {
                // Remove o item selecionado do combo 
                cboEstados.Items.RemoveAt(cboEstados.SelectedIndex);
                // Exibe a quantidade de itens do ComboBox
                lblEstados.Text = cboEstados.Items.Count.ToString();
                // Limpa o texto da combo
                cboEstados.ResetText();

                if (cboEstados.Text = "Amazonas, Pará, Roraima, Amapá, Rondônia, Acre e Tocantins") 
                { 
                }
            }
        }
    }
}
