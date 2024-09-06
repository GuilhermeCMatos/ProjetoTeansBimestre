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
            if (cboEstados.SelectedIndex != -1)
            {
                string texto = cboEstados.SelectedItem.ToString();
                cboEstados.ResetText();

                //norte
                if (texto == "Amazonas (AM)" || texto == "Acre (AC)" || texto == "Rondônia (RO)" || texto == "Amapá (AP)" || texto == "Pará (PA)" || texto == "Tocantins (TO)" || texto == "Roraima (RR)")
                {
                    cboNorte.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.Remove(cboEstados.SelectedItem);
                    lblEstados.Text = cboEstados.Items.Count.ToString();
                    lblNorte.Text = cboNorte.Items.Count.ToString();
                }

                //nordeste
                if (texto == "Maranhão (MA)" || texto == "Piauí (PI)" || texto == "Bahia (BA)" || texto == "Pernambuco (PE)" || texto == "Ceará (CE)" || texto == "Rio Grande do Norte (RN)" || texto == "Alagoas (AL)" || texto == "Sergipe (SE)" || texto == "Paraíba (PB)")
                {
                    cboNordeste.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.Remove(cboEstados.SelectedItem);
                    lblEstados.Text = cboEstados.Items.Count.ToString();
                    lblNordeste.Text = cboNordeste.Items.Count.ToString();
                }

                //sudeste
                if (texto == "São Paulo (SP)" || texto == "Rio de Janeiro (RJ)" || texto == "Minas Gerais (MG)" || texto == "Espírito Santo (ES)")
                {
                    cboSudeste.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.Remove(cboEstados.SelectedItem);
                    lblEstados.Text = cboEstados.Items.Count.ToString();
                    lblSudeste.Text = cboSudeste.Items.Count.ToString();
                }

                //centro-oeste
                if (texto == "Mato Grosso (MT)" || texto == "Mato Grosso do Sul (MS)" || texto == "Goiás (GO)" || texto == "Distrito Federal (DF)")
                {
                    cboCentro.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.Remove(cboEstados.SelectedItem);
                    lblEstados.Text = cboEstados.Items.Count.ToString();
                    lblCentro.Text = cboCentro.Items.Count.ToString();
                }

                //sul
                if (texto == "Paraná (PR)" || texto == "Santa Catarina (SC)" || texto == "Rio Grande do Sul (RS)")
                {
                    cboSul.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.Remove(cboEstados.SelectedItem);
                    lblEstados.Text = cboEstados.Items.Count.ToString();
                    lblSul.Text = cboSul.Items.Count.ToString();
                }
            }
        }

        private void btNorte_Click(object sender, EventArgs e)
        {
            if (cboNorte.SelectedIndex != -1)
                cboEstados.Items.Add(cboNorte.SelectedItem);
            cboNorte.Items.Remove(cboNorte.SelectedItem);
            lblEstados.Text = cboEstados.Items.Count.ToString();
            lblNorte.Text = cboNorte.Items.Count.ToString();
            cboNorte.ResetText();
        }

        private void btNordeste_Click(object sender, EventArgs e)
        {
            if (cboNordeste.SelectedIndex != -1)
                cboEstados.Items.Add(cboNordeste.SelectedItem);
            cboNordeste.Items.Remove(cboNordeste.SelectedItem);
            lblEstados.Text = cboEstados.Items.Count.ToString();
            lblNordeste.Text = cboNordeste.Items.Count.ToString();
            cboNordeste.ResetText();
        }

        private void btCentro_Click(object sender, EventArgs e)
        {
            if (cboCentro.SelectedIndex != -1)
                cboEstados.Items.Add(cboCentro.SelectedItem);
            cboCentro.Items.Remove(cboCentro.SelectedItem);
            lblEstados.Text = cboEstados.Items.Count.ToString();
            lblCentro.Text = cboCentro.Items.Count.ToString();
            cboCentro.ResetText();
        }

        private void btSul_Click(object sender, EventArgs e)
        {
            if (cboSul.SelectedIndex != -1)
                cboEstados.Items.Add(cboSul.SelectedItem);
            cboSul.Items.Remove(cboSul.SelectedItem);
            lblEstados.Text = cboEstados.Items.Count.ToString();
            lblSul.Text = cboSul.Items.Count.ToString();
            cboSul.ResetText();
        }

        private void btSudeste_Click(object sender, EventArgs e)
        {
            if (cboSudeste.SelectedIndex != -1)
                cboEstados.Items.Add(cboSudeste.SelectedItem);
            cboSudeste.Items.Remove(cboSudeste.SelectedItem);
            lblEstados.Text = cboEstados.Items.Count.ToString();
            lblSudeste.Text = cboSudeste.Items.Count.ToString();
            cboSudeste.ResetText();
        }
    }
}
