using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filtrado_Glomerular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            resultadoTxt.Text = edadTxt.Text + pesoTxt.Text;
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            edadTxt.ResetText();
            pesoTxt.ResetText();
            creatininaTxt.ResetText();
            relacionACTxt.ResetText();
            razaNegraCheckBox.Checked = false;
            resultadoTxt.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
