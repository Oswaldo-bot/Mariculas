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
    public partial class Datos_Academicos : Form
    {
        public Datos_Academicos()
        {
            InitializeComponent();
        }
        private void Datos_Academicos_Load(object sender, EventArgs e)
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


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region[Llenar Materias]
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Base de Datos");
            comboBox1.Items.Add("Calculo.");
            comboBox1.Items.Add("Inteligencia Artificial");
            comboBox1.Items.Add("Seguridad Informática");
            #endregion
        }

        private void chbActivo_CheckedChanged(object sender, EventArgs e)
        {
            chbActivo.Checked = false;
        }
    }
}
