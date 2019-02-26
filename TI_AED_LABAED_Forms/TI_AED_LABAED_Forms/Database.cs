using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TI_AED_LABAED_Forms
{
    class Database
    {
        public void LerArquivo(string nomeArquivo)
        {
            StreamReader arq = new StreamReader(nomeArquivo);
            {
                if(File.Exists(nomeArquivo))
                {
                    while(!arq.EndOfStream)
                    {
                        Calculadora.CadastrarEquacao(arq.ReadLine());
                    }
                }
            }arq.Close();
        }
        
    }
}
