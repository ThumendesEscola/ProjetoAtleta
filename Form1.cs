using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Atleta Arthur = new Atleta();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Arthur.Altura = double.Parse(txtAltura.Text);
                Arthur.Peso = double.Parse(txtPeso.Text);
                lblResposta.Text = Arthur.CalcularIMC().ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro. \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
