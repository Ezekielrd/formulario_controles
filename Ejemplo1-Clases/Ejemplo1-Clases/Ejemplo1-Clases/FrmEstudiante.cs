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
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(tex1.Text)) || !(string.IsNullOrEmpty(tex2.Text)))
            {
                Alumno alum1 = new Alumno(tex1.Text, tex2.Text);
                Datos.Alumnos.Add(alum1);
                FrmPersona fpers = new FrmPersona();
                fpers.ShowDialog();
                if (!(string.IsNullOrEmpty(fpers.tex1.Text)) || !(string.IsNullOrEmpty(fpers.tex2.Text)) ||
                    !(string.IsNullOrEmpty(fpers.tex3.Text)) || !(string.IsNullOrEmpty(fpers.tex4.Text)) ||
                    !(string.IsNullOrEmpty(fpers.text5.Text)))
                {
                    alum1.Id = fpers.tex1.Text;
                    alum1.Nombre = fpers.tex2.Text;
                    alum1.Direccion = fpers.tex3.Text;
                    alum1.Telf = fpers.tex4.Text;
                    alum1.Email = fpers.text5.Text;
                    FrmCentro fcent = new FrmCentro();
                    fcent.ShowDialog();
                    if (!(string.IsNullOrEmpty(fcent.tex1.Text)) || !(string.IsNullOrEmpty(fcent.tex2.Text)) ||
                        !(string.IsNullOrEmpty(fcent.tex3.Text)) || !(string.IsNullOrEmpty(fcent.tex4.Text)))
                    {
                        alum1.Centro = new Centro(fcent.tex1.Text, fcent.tex2.Text, fcent.tex3.Text, fcent.tex4.Text);
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
            else
            {
                MessageBox.Show("no todos los campos estan llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }
    }
}
