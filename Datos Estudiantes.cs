using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mariculas
{
    public partial class Datos_Estudiantes : Form
    {
        public Datos_Estudiantes()
        {
            InitializeComponent();
        }

        private void Datos_Estudiantes_Load(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                {
                    Stream strGuardar = saveFileDialog1.OpenFile(); StreamWriter wrtGuardar = new StreamWriter(strGuardar);
                    foreach (string linea in textBox4.Lines) { wrtGuardar.WriteLine(linea); }
                    wrtGuardar.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
