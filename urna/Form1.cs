using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urna
{
    public partial class Form1 : Form
    {
        int CandA, CandB, CandC, CandD;
        int eleitores, vencedorvotos;

        private void button1_Click(object sender, EventArgs e)
        {
            ++CandA;

            if (CandA > vencedorvotos)
            {
                vencedorvotos = CandA;
                vencedorCand = "Candidato A";
            }

            ++eleitores;
        }
        private void BtnCandB_Click(object sender, EventArgs e)
        {
            ++CandB;

            if (CandB > vencedorvotos)
            {
                vencedorvotos = CandB;
                vencedorCand = "Candidato B";
            }

            ++eleitores;
        }

        string vencedorCand;

        private void Terminar_Click(object sender, EventArgs e)
        {
            LBLVotosA.Text = CandA.ToString();
            LBLPVotosA.Text = ((double)(CandA / (double)eleitores)).ToString("P2");
            LBLVotosB.Text = CandB.ToString();
            LBLPVotosB.Text = ((double)(CandB / (double)eleitores)).ToString("P2");
            LBLVotosC.Text = CandC.ToString();
            LBLPVotosC.Text = ((double)(CandC / (double)eleitores)).ToString("P2");
            LBLVotosD.Text = CandD.ToString();
            LBLPVotosD.Text = ((double)(CandD / (double)eleitores)).ToString("P2");

            LBLTOTAL.Text = eleitores.ToString();
            LBLVENCEDOR.Text = vencedorCand;
        }

        private void BtnCandD_Click_1(object sender, EventArgs e)
        {
            ++CandD;

            if (CandD > vencedorvotos)
            {
                vencedorvotos = CandD;
                vencedorCand = "Candidato D";
            }

            ++eleitores;
        }

        private void BtnCandC_Click_1(object sender, EventArgs e)
        {
            ++CandC;

            if (CandC > vencedorvotos)
            {
                vencedorvotos = CandC;
                vencedorCand = "Candidato C";
            }

            ++eleitores;
        }

        private void BtnCandD_Click(object sender, EventArgs e)
        {
            ++CandD;

            if (CandD > vencedorvotos)
            {
                vencedorvotos = CandD;
                vencedorCand = "Candidato D";
            }

            ++eleitores;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
