using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class FrmCentro : Form
    {
        public FrmCentro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(tex1.Text)) || !(string.IsNullOrEmpty(tex2.Text)) ||
                !(string.IsNullOrEmpty(tex3.Text)) || !(string.IsNullOrEmpty(tex4.Text)))
            {
                Centro cen1 = new Centro(tex1.Text, tex2.Text, tex3.Text, tex4.Text);
                Datos.Centros.Add(cen1);
                this.Close();
            }
            else
            {
                MessageBox.Show("no todos los campos estan completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tex2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmCentro_Load(object sender, EventArgs e)
        {

        }
    }
}
