using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackLibrary;

namespace TI_AED_LABAED_Forms
{
    class SimboloOperacional : Data
    {
        private char simbolo;
        private int prioridade;

        public char Simbolo { get {return simbolo;}

}
        public int Prioridade { get {return prioridade;} }

        /// <summary>
        /// Construtor da classe SimbolosOperacionais que recebe por parâmetro uma string contendo o símbolo e uma prioridade.
        /// </summary>
        /// <param name="simb"></param>
        /// <param name="prio"></param>
        public SimboloOperacional(char simb, int prio)
        {
            this.simbolo = simb;
            this.prioridade = prio;   
        }

        /// <summary>
        /// Método override ToString.
        /// </summary>
        /// <returns>Retorna o conteúdo da classe em forma de string.</returns>
        public override string ToString()
        {
            // return "Prioridade: " + Prioridade + ", Símbolo: " + Simbolo + "\n";
            return this.simbolo.ToString();
        }

        public override int CompareTo(Data obj)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(Data other)
        {
            throw new NotImplementedException();
        }
    }
}
