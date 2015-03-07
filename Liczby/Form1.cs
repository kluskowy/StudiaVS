using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liczby
{
    public partial class OknoLiczby : Form
    {

        public string strRobocza;
        public string strLiczbaSlownie;
        public string strPrzedrostek;

        public OknoLiczby()
        {
            InitializeComponent();
        }

        private void btnNapiszSlownie_Click(object sender, EventArgs e)
        {
            tbxSlownie.Text = Slownie(Convert.ToDouble(tbxLiczba.Text));
        }


        string Slownie(double dblLiczba)
        {
            string strSet;
            string strLiczba;
            string strKoncowka;
            string strLiczbaSlownie = "";
            string strCiag = "";
            long i;
            long lngMax;

            strRobocza = tbxLiczba.Text.Trim();
            
            UsunSpacje();

            tbxLiczba.Text = strRobocza;
            lngMax = 61;
            if ((strRobocza.Length > (lngMax * 3)))
            {
                return "";
            }

            for (i = 0; i < lngMax * 3; i++)
            {
                strCiag = strCiag + "0";
            }

            strLiczba = (strCiag.Substring(0, (strCiag.Length - strRobocza.Length)) + strRobocza);

            if ((double.Parse(strLiczba) == 0))
            {
                return "zero";
            }

            for (int j = Convert.ToInt16(strLiczba.Length); (j >= 1); j = (j - 3))
            {
                strSet = strLiczba.Substring((j - 3), 3);
                strPrzedrostek = OkreslLiczbe(strSet);
                strKoncowka = OkreslDod(strPrzedrostek, strSet, ((strLiczba.Length - j)/ 3));
                strLiczbaSlownie = (strPrzedrostek + (strKoncowka + (" " + strLiczbaSlownie))).Trim();
            }
            return strLiczbaSlownie.Trim();
        }


        void UsunSpacje()
        {
            bool SaSpacje;
            SaSpacje = true;
            while (SaSpacje)
            {
                SaSpacje = false;
                for (int k = 1; (k <= strRobocza.Length); k++)
                {
                    if ((strRobocza.Substring((k - 1), 1) == " "))
                    {
                        SaSpacje = true;
                        strRobocza = (strRobocza.Substring(0, (k - 1)) + strRobocza.Substring(k, ((strRobocza.Length - k) + 1)));
                    }
                }
            }
        }

        string OkreslLiczbe(string strLiczba)
        {
            string strS;
            string strD;
            object[] tabSetki = { "", " sto", " dwieście", " trzysta", " czterysta", " pięćset", " sześćset", "siedemset", " osiemset", " dziewięćset" };
            object[] tabDziesiatki = { "", " ", " dwadzieścia", " trzydzieści", " czterdzieści", " pięćdziesiąt", " sześćdziesiąt", "siedemdziesiąt", " osiemdziesiąt", " dziewięćdziesiąt" };
            object[] tabNastki = { "dziesięć", " jedenaście", " dwanaście", " trzynaście", " czternaście", " piętnaście", " szesnaście", "siedemnaście", " osiemnaście", " dziewiętnaście" };
            object[] tabJedynki = { "", " jeden", " dwa", " trzy", " cztery", " pięć", " sześć", "siedem", " osiem", " dziewięć" };

            strS = Convert.ToString(tabSetki[Convert.ToInt16(strLiczba.Substring(0, 1))]);

            if ((Convert.ToInt16(strLiczba.Substring(1, 1)) == 1))
            {
                strD = Convert.ToString(tabNastki[Convert.ToInt16(strLiczba.Substring(2, 1))]);
            }
            else
            {
                strD = (tabDziesiatki[Convert.ToInt16(strLiczba.Substring(1, 1))] + ("" + tabJedynki[Convert.ToInt16(strLiczba.Substring(2, 1))]));
            }
            return (strS + (" " + strD.Trim())).Trim();
        }

        string OkreslDod(string strLS, string strL, long i)
        {
            if ((i == 0))
            {
                return "";
            }

            long x;
            long y;

            object [,] tabDuzeLiczby = { 
            {"tysiąc", "  tysiące", "  tysięcy"},
            {"milion", "  miliony", "  milionów"},
            {"miliard", "  miliardy", "  miliardów"},
            {"bilion", "  biliony", "  bilionów"},
            {"biliard", "  biliardy", "  biliardów"},
            {"trylion", " tryliony", " trylionów"},
            {"tryliard", " tryliardy", " tryliardów"},
            {"kwadrylion", " kwadryliony", " kwadrylionów"},
            {"kwadryliard", " kwadryliardy", " kwadryliardów"},
            {"kwintylion", " kwintyliony", " kwintylionów"},
            {"kwintyliard", " kwintyliardy", " kwintyliardów"},
            {"sekstylion", " sekstylion", " sekstylionów"},
            {"sekstyliard", " sekstyliardy", " sekstyliardów"},
            {"septylion", " septyliony", " septylionów"},
            {"septyliard", " septyliardy", " septyliardów"},
            {"oktylion", " oktyliony", " oktylionów"},
            {"oktyliard", " oktyliardy", " oktyliardów"},
            {"nonylion", " nonyliony", " nonylionów"},
            {"nonyliard", " nonyliardy", " nonyliardów"},
            {"decylion", " decyliony", " decylionów"},
            {"decyliard", " decyliardy", " decyliardów"},
            {"undecylion", " undecyliony", " undecylionów"},
            {"undecyliard", " undecyliardy", " undecyliardów"},
            {"dodecylion", " dodecyliony", " dodecylionów"},
            {"decyliard", " decyliardy", " decyliardów"},
            {"tridecylion", " tridecyliony", " tridecylionów"},
            {"tridecyliard", " tridecyliardy", " kwatuordecylionów"},
            {"kwatuordecylion", " kwatuordecyliony", " kwatuordecylionów"},
            {"kwatuordecyliard", " kwatuordecyliardy", " kwatuordecyliardów"},
            {"kwindecylion", " kwindecyliony", " kwindecyliardów"},
            {"kwindecyliard", " kwindecyliardy", " kwindecyliardów"},
            {"seksdecylion", " seksdecyliony", " seksdecylionów"},
            {"seksdecyliard", " seksdecyliardy", " seksdecyliardów"},
            {"septendecylion", " septendecyliony", " septendecylionów"},
            {"septendecyliard", " septendecyliardy", " septendecyliardów"},
            {"oktodecylion", " oktodecyliony", " oktodecylionów"},
            {"oktodecyliard", " oktodecyliardy", " oktodecyliardów"},
            {"nowemdecylion", " nowemdecyliony", " nowemdecylionów"},
            {"nowemdecyliard", " nowemdecyliardy", " nowemdecyliardów"},
            {"wicylion", " wicyliony", " wicylionów"},
            {"wicyliard", " wicyliardy", " wicyliardów"},
            {"unwicylion", " unwicyliony", " unwicylionów"},
            {"unwicyliard", " unwicyliardy", " unwicyliardów"},
            {"dowicylion", " dowicyliony", " dowicylionów"},
            {"dowicyliard", " dowicyliardy", " dowicyliardów"},
            {"triwicylion", " triwicyliony", " triwicylionów"},
            {"triwicyliard", " triwicyliardy", " triwicyliardów"},
            {"kwatuorwicylion", " kwatuorwicyliony", " kwatuorwicylionów"},
            {"kwatuorwicyliard", " kwatuorwicyliardy", " kwatuorwicyliardów"},
            {"kwinwicylion", " kwinwicyliony", " kwinwicylionów"},
            {"kwinwicyliard", "kwinwicyliardy", " kwinwicyliardów"},
            {"sekswicylion", " sekswicyliony", " sekswicylionów"},
            {"sekswicyliard", " sekswicyliardy", " sekswicyliardów"},
            {"septenwicylion", " septenwicyliony", " septenwicylionów"},
            {"septenwicyliard", " septenwicyliardy", " septenwicyliardów"},
            {"oktowicylion", " oktowicyliony", " oktowicylionów"},
            {"oktowicyliard", " oktowicyliardy", " oktowicyliardów"},
            {"nowemwicylion", " nowemwicyliony", " nowemwicylionów"},
            {"nowemwicyliard", " nowemwicyliardy", " nowemwicyliardów"},
            {"trycylion", " trycyliony", " trycylionów"},
            {"trycyliard", " trycyliard", " trycyliardów"}};

            switch (int.Parse(strL))
            {
                case 0:
                    return "";
                    break;
                case 1:
                    return Convert.ToString(tabDuzeLiczby[i,0]);
                    strLS = "";
                    break;
                default:
                    x = int.Parse(strL.Substring((strL.Length - 1), 1));
                    y = int.Parse(strL.Substring(strL.Length-1, 1));
                    if ((((x >= 2)
                                && (x <= 4))
                                && (y != 1)))
                    {
                        return Convert.ToString(tabDuzeLiczby[i,1]);
                    }
                    else
                    {
                        return Convert.ToString(tabDuzeLiczby[i,2]);
                    }
                    break;
            }
        }

    }
}
