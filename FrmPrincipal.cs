using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System
    .Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquacaoQuadCSharp
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            EquacaoQuad eq = new EquacaoQuad();
            eq.A = Convert.ToInt32(txtA.Text);
            eq.B = Convert.ToInt32(txtB.Text);
            eq.C = Convert.ToInt32(txtC.Text);
            eq.Bhaskara();
            Limpar();
            
            if(eq.A == 0)
                MessageBox.Show("O coeficiente a não pode ser zero.");
            
            else if (eq.Solucao == 0)
                MessageBox.Show("A equação não possui raízes reais");
            
            else if (eq.Solucao == 1)
                MessageBox.Show("x' e x\" = " + eq.X1.ToString());
            
            else
                MessageBox.Show("x' = " + eq.X1.ToString() + "\nx\" = " + eq.X2.ToString());
        }
        private void Limpar() 
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtA.Focus();

        }

        
    }
}
