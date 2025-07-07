using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilerias; // Assuming Utilerias is a separate project or namespace



namespace OtrasPruebasGIT
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var objUtilidades = new Utilerias.Utilerias();
            lblNombre.Text = objUtilidades.DevolverNombreUtileria(txtNombreUtileria.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var objUtilidades = new Utilerias.Utilerias();
            lblOperacion.Text = objUtilidades.DevolverResultadoOperacion(Convert.ToDecimal(txtNum1.Text), Convert.ToDecimal(txtNum2.Text)).ToString();
        }
    }
}
