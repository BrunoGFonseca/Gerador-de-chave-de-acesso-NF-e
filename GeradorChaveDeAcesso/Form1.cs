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

        public bool validaComboBox(string Est, string Mod)
        {
            if ((Est.Equals("0")) || (Mod.Equals(" ")))
            {
                /*
                if (Est.Equals("0"))
                {
                    MessageBox.Show("Selecione um estado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Selecione um modelo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validaCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            if (cnpj.Length != 14)
                return false;

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public bool isVazio(string est, string mod, string ano, string mes, string cnp, string ser, string num)
        {
            if (est.Equals(""))
                return true;
            else if (mod.Equals(""))
                return true;
            else if (ano.Equals(""))
                return true;
            else if (mes.Equals(""))
                return true;
            else if (cnp.Equals(""))
                return true;
            else if (ser.Equals(""))
                return true;
            else if (num.Equals(""))
                return true;
            else
                return false;
        }

        private void BtnGerarChave_Click(object sender, EventArgs e)
        {
            string est, ano, mes, cnp, mod, ser, num, ranTxt, chave, aux;
            Regex regexObj = new Regex(@"[^\d]");
            Random rdn = new Random();
            int ranInt;
            bool cnpj, vazio, valid;

            //Pegando os valores da tela
            est = validaEstado(cmbEstado.Text);
            mod = cmbModelo.Text;
            ano = dtpAno.Text;
            mes = dtpMes.Text;
            cnp = regexObj.Replace(mtbCNPJ.Text, "");
            ser = txtserie.Text;
            num = txtNum.Text;
            ranInt = rdn.Next(000000000, 999999999);
            ranTxt = ranInt.ToString();

            //Efetuando validações
            vazio = isVazio(est, mod, ano, mes, cnp, ser, num);
            valid = validaComboBox(est, mod);
            cnpj = validaCnpj(cnp);

            if (!vazio)
            {
                if (valid)
                {
                    if (cnpj)
                    {
                        aux = est + ano + mes + cnp + mod + ser + num + ranTxt;
                        chave = digito(aux);

                        txtChaveAcesso.Text = chave;
                    }
                    else
                    {
                        MessageBox.Show("CNPJ inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Estado ou Modelo está vazio","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Existem campos vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void TxtNum_Leave(object sender, EventArgs e)
        {
            string num = txtNum.Text;

            if(num.Length < 9)
            {
                MessageBox.Show("Campo número está com menos de 9 digitos","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Txtserie_Leave(object sender, EventArgs e)
        {
            string serie = txtserie.Text;

            if (serie.Length < 3)
            {
                MessageBox.Show("Campo série está com menos de 3 digitos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            string mensagem;

            mensagem = "Estado: Informe código IBGE do estado do fornecedor\n\n" +
                        "Ano: informe ano com 2 digitos\n\n" + "Mês: informe mês com 2 digitos\n\n" +
                        "CNPJ: Informe o CNPJ\n\n" + "Modelo: Informe o modelo\n\n" + "Série: Informe a série com 3 digitos\n\n" +
                        "Número: Informe um numero maior do que a última nota do fornecedor no sistema 9 digitos\n\n" +
                        "Desenvolvido por Bruno Fonseca\n"+ "Bruno.Fonseca@pentare.com.br\n\n" +"teste " + "teste";

            MessageBox.Show("As informações dos campos são: \n\n" + mensagem,"Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
