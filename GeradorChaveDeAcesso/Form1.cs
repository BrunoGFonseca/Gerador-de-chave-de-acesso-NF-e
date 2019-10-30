using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorChaveDeAcesso
{
    public partial class GeradorChaveDeAcesso : Form
    {
        public GeradorChaveDeAcesso()
        {
            InitializeComponent();
        }

        private void PreencheEstado(ArrayList Estado)
        {
            //Null
            Estado.Add(" ");
            //Região Norte
            Estado.Add("RO");//11
            Estado.Add("AC");//12
            Estado.Add("AM");//13
            Estado.Add("RR");//14
            Estado.Add("PA");//15
            Estado.Add("AP");//16
            Estado.Add("TO");//17
            //Região Nordeste
            Estado.Add("MA");//21
            Estado.Add("PI");//22
            Estado.Add("CE");//23
            Estado.Add("RN");//24
            Estado.Add("PB");//25
            Estado.Add("PE");//26
            Estado.Add("AL");//27
            Estado.Add("SE");//28
            Estado.Add("BA");//29
            //Região Sudeste
            Estado.Add("MG");//31
            Estado.Add("ES");//32
            Estado.Add("RJ");//33
            Estado.Add("SP");//35
            //Região Sul
            Estado.Add("PR");//41
            Estado.Add("SC");//42
            Estado.Add("RS");//43
            //Região Centro-Oeste
            Estado.Add("MS");//50
            Estado.Add("MT");//51
            Estado.Add("GO");//52
            Estado.Add("DF");//53

            //Vinculando com o combobox
            cmbEstado.DataSource = Estado;

        }

        private void PreencheModelo(ArrayList Modelo)
        {
            //Null
            Modelo.Add(" ");

            //Modelos
            Modelo.Add("55");
            Modelo.Add("57");

            //Vinculando com o combobox
            cmbModelo.DataSource = Modelo;
        }

        private void GeradorChaveDeAcesso_Load(object sender, EventArgs e)
        {
            ArrayList Estados = new ArrayList();
            ArrayList Modelos = new ArrayList();

            PreencheEstado(Estados);
            PreencheModelo(Modelos);
        }

        private string validaEstado(string Estado)
        {
            switch (Estado)
            {
                case "RO":
                    return "11";
                //break;
                case "AC":
                    return "12";
                //break;
                case "AM":
                    return "13";
                //break;
                case "RR":
                    return "14";
                //break;
                case "PA":
                    return "15";
                //break;
                case "AP":
                    return "16";
                //break;
                case "TO":
                    return "17";
                //break;
                case "MA":
                    return "21";
                //break;
                case "PI":
                    return "22";
                //break;
                case "CE":
                    return "23";
                //break;
                case "RN":
                    return "24";
                //break;
                case "PB":
                    return "25";
                //break;
                case "PE":
                    return "26";
                //break;
                case "AL":
                    return "27";
                //break;
                case "SE":
                    return "28";
                //break;
                case "BA":
                    return "29";
                //break;
                case "MG":
                    return "31";
                //break;
                case "ES":
                    return "32";
                //break;
                case "RJ":
                    return "33";
                //break;
                case "SP":
                    return "35";
                //break;
                case "PR":
                    return "41";
                //break;
                case "SC":
                    return "42";
                //break;
                case "RS":
                    return "43";
                //break;
                case "MS":
                    return "50";
                //break;
                case "MT":
                    return "51";
                //break;
                case "GO":
                    return "52";
                //break;
                case "DF":
                    return "53";
                //break;
                default:
                    return "0";
                break;
            }
        }

        public static string digito(string chave)
        {
            int soma = 0;
            int resto = 0;
            int[] peso = { 4, 3, 2, 9, 8, 7, 6, 5 };
            int digitoRetorno;

            for (int i = 0; i < chave.Length; i++)
            {
                soma += peso[i % 8] * (int.Parse(chave.Substring(i, 1)));
            }

            resto = soma % 11;
            if (resto == 0 || resto == 1)
            {
                digitoRetorno = 0;
            }
            else
            {
                digitoRetorno = 11 - resto;
            }

            return chave + digitoRetorno.ToString();
        }

        private void BtnGerarChave_Click(object sender, EventArgs e)
        {
            string est, ano, mes, cnp, mod, ser, num, ranTxt, chave, aux;
            Regex regexObj = new Regex(@"[^\d]");
            Random rdn = new Random();
            int ranInt;

            est = validaEstado(cmbEstado.Text);
            ano = dtpAno.Text;
            mes = dtpMes.Text;
            cnp= regexObj.Replace(mtbCNPJ.Text, "");
            mod = cmbModelo.Text;
            ser = txtserie.Text;
            num = txtNum.Text;
            ranInt = rdn.Next(000000000, 999999999);

            ranTxt = ranInt.ToString();

            aux = est + ano + mes + cnp + mod + ser + num + ranTxt;

            chave = digito(aux);

            txtChaveAcesso.Text = chave;
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            cmbEstado.Text = "";
            dtpAno.Text = "";
            dtpMes.Text = "";
            mtbCNPJ.Text = "";
            cmbModelo.Text = "";
            txtserie.Text = "";
            txtNum.Text = "";
            txtChaveAcesso.Text = "";
        }
    }
}
