using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackLibrary;


namespace TI_AED_LABAED_Forms
{
    class Numero : Data
    {
        private double numero;

        public Numero(double num)
        {
            numero = num;
        }

        public double GetNumero { get { return numero; } }

        public override int CompareTo(Data obj)
        {
            return this.numero.CompareTo(obj);
        }

        public override bool Equals(Data other)
        {
            return this.numero.Equals(other);
        }

        public override string ToString()
        {
            return this.numero.ToString();
        }
    }
}
