using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorChaveDeAcesso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGerarChave_Click(object sender, EventArgs e)
        {
            string est, ano, mes, cnp, mod, ser, num, chav;
            int ran;
            Random rdn = new Random();

            est = cmbEstado.Text;
            ano = dtpAno.Text;
            mes = dtpMes.Text;
            cnp = mtbCNPJ.Text;
            mod = cbModelo.Text;
            ser = txtserie.Text;
            num = txtNum.Text;
            ran = rdn.Next(111111111, 999999999);


        }
    }
}
