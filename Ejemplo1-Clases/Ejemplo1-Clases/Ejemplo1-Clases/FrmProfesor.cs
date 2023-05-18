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
    public partial class FrmProfesor : Form
    {
        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(tex1.Text)) || !(string.IsNullOrEmpty(tex2.Text)))
            {
                Profesor profe1 = new Profesor(tex1.Text, double.Parse(tex2.Text));
                Datos.Profesores.Add(profe1);
                FrmPersona fperson = new FrmPersona();
                fperson.ShowDialog();
                if (!(string.IsNullOrEmpty(fperson.tex1.Text)) || !(string.IsNullOrEmpty(fperson.tex2.Text)) ||
                    !(string.IsNullOrEmpty(fperson.tex3.Text)) || !(string.IsNullOrEmpty(fperson.tex4.Text)) ||
                    !(string.IsNullOrEmpty(fperson.text5.Text)))
                {
                    profe1.Id = fperson.tex1.Text;
                    profe1.Nombre = fperson.tex2.Text;
                    profe1.Direccion = fperson.tex3.Text;
                    profe1.Telf = fperson.tex4.Text;
                    profe1.Email = fperson.text5.Text;
                    DialogResult resp = DialogResult.Yes;
                    while (resp == DialogResult.Yes)
                    {
                        FrmCentro fcen = new FrmCentro();
                        fcen.ShowDialog();
                        if (!(string.IsNullOrEmpty(fcen.tex1.Text)) || !(string.IsNullOrEmpty(fcen.tex2.Text)) ||
                            !(string.IsNullOrEmpty(fcen.tex3.Text)) || !(string.IsNullOrEmpty(fcen.tex4.Text)))
                        {
                            Centro centro1 = new Centro();
                            centro1.Nombre = fcen.tex1.Text;
                            centro1.Dir = fcen.tex2.Text;
                            centro1.Telf = fcen.tex3.Text;
                            centro1.Email = fcen.tex4.Text;

                            profe1.Centros.Add(centro1);
                                                    
                            resp = MessageBox.Show("tiene otro centro", "confirmar", MessageBoxButtons.YesNo);                          
                       
                        }
                        else
                        {
                            MessageBox.Show("no todos los campos estan llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("no todos los capos estan llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("no todos los campos estan llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }
    }
}
