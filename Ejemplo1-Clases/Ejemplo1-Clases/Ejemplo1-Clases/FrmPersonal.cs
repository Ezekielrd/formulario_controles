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
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(tex1.Text)) || !(string.IsNullOrEmpty(tex2.Text)))
            {
                Personal per1 = new Personal(tex1.Text, tex2.Text);
                Datos.Personanles.Add(per1);
                FrmPersona fperson = new FrmPersona();
                fperson.ShowDialog();
                if (!(string.IsNullOrEmpty(fperson.tex1.Text)) || !(string.IsNullOrEmpty(fperson.tex2.Text)) ||
                    !(string.IsNullOrEmpty(fperson.tex3.Text)) || !(string.IsNullOrEmpty(fperson.tex4.Text)) ||
                    !(string.IsNullOrEmpty(fperson.text5.Text)))
                {
                    per1.Id = fperson.tex1.Text;
                    per1.Nombre = fperson.tex2.Text;
                    per1.Direccion = fperson.tex3.Text;
                    per1.Telf = fperson.tex4.Text;
                    per1.Email = fperson.text5.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("no todos los campos estan llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("no todos los campos estan llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
