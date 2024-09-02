using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Projeto:
namespace EquacaoQuadCSharp
{
    //Classe:
    class EquacaoQuad
    {
        // Atributo privado:
        private double _delta;

        // Propriedades:
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public double? X1 { get; private set; }
        public double? X2 { get; private set; }
        public byte Solucao { get; private set; }

        // Δ = b² – 4.a.c
        private void CalcDiscriminante() 
        {
            _delta = Math.Pow(B, 2) - 4 * A * C;

            // A equação não terá raízes reais;
            if (_delta < 0)
                Solucao = 0;

            // A equação apresentará duas raízes reais e iguais;
            else if (_delta == 0)
                Solucao = 1;

            // senao Δ > 0: A equação vai ter duas raízes reais e distintas.
            else
                Solucao = 2;
        }

        // x = - b ± √Δ / 2.a
        private void CalcX1eX2() 
        {
            var raizQuadDelta = Math.Sqrt(_delta);

            X1 = (-B + raizQuadDelta) / (2 * A);
            X2 = (-B - raizQuadDelta) / (2 * A);
        }
        public void Bhaskara() 
        {
            CalcDiscriminante();

            if (Solucao != 0)
                CalcX1eX2();
            else
            {
                X1 = null;
                X2 = null;
            }
        }
    }
}
