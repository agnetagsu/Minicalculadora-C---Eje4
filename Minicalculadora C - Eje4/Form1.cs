using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minicalculadora_C___Eje4
{
    public partial class Form1 : Form
    {
        
        public decimal resultado = 0;
        public Form1() 
        {
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            resultado = Convert.ToDecimal(this.operando1.Text) + Convert.ToDecimal(this.operando2.Text);
        }

        private void resta_Click(object sender, EventArgs e)
        {
            resultado = Convert.ToDecimal(this.operando1.Text) - Convert.ToDecimal(this.operando2.Text);
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            resultado = Convert.ToDecimal(this.operando1.Text) * Convert.ToDecimal(this.operando2.Text);
        }

        private void division_Click(object sender, EventArgs e)
        {
            resultado = Convert.ToDecimal(this.operando1.Text) / Convert.ToDecimal(this.operando2.Text);
        }

        private void igual_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = Convert.ToString(resultado);
        }
    }
}
