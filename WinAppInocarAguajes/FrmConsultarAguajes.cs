using System;
using System.Data;
using System.Windows.Forms;

namespace WinAppInocarAguajes
{
    public partial class FrmConsultarAguajes : Form
    {
        public FrmConsultarAguajes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int año = Convert.ToInt16(this.numericUpDown1.Text);

            string url = string.Format(this.txtUrl.Text, año);

            DataTable dtDiasAguaje = new Aguajes().ObtenerTabla(url);

            this.dataGridView1.DataSource = dtDiasAguaje;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.numericUpDown1.Value = DateTime.Now.Year;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}