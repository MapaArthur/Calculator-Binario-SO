using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackLibrary;

namespace TI_AED_LABAED_Forms
{
    static class Calculadora
    {
        static string[] simbolos = { "+", "-", "*", "/", "(", ")", "^", "R" };
        static Stack pilhaRes = new Stack();
        static Stack pilhaSimb = new Stack();
        static List<string> equacoes = new List<string>();
        public static void CadastrarEquacao(string equacao)
        {
            equacoes.Add(equacao);
        }

        /// <summary>
        /// Recebe uma string contendo um símbolo por parâmetro e valida se o símbolo é válido ou não.
        /// </summary>
        /// <param name="simbolo"></param>
        /// <returns>Retorna true or false como resultado.</returns>
        private static bool ValidaSimbolo(char simbolo)
        {
            for (int i = 0; i < simbolos.Length; i++)
            {
                if (char.Parse(simbolos[i]) == simbolo)
                    return true;
            }
            return false;
        }

        private static void AdicionaOperador(SimboloOperacional simb)
        {
            SimboloOperacional auxSimboloOP; // Só olha "Peek" o objeto
            SimboloOperacional auxSimb; //guardar o objeto removido da pilha
            auxSimboloOP = (SimboloOperacional)pilhaSimb.Peek();
            while (!pilhaSimb.Empty() && auxSimboloOP.Prioridade >= simb.Prioridade)
            {
                auxSimb = (SimboloOperacional)pilhaSimb.Pop();
                pilhaRes.Push(auxSimb);
                auxSimboloOP = (SimboloOperacional)pilhaSimb.Peek();
            }
            pilhaSimb.Push(simb);
        }

        public static double CalculaPosFixa(string equacao)
        {
            int i = 0;
            Numero result;
            while (equacao != "")
            {
                try
                {
                    Numero numero;
                    numero = new Numero(double.Parse((equacao.Substring(i, i + 1))));
                    equacao = equacao.Remove(i, i + 1);
                    pilhaRes.Push(numero);

                }
                catch
                {
                    if (ValidaSimbolo(char.Parse(equacao.Substring(i, i + 1))))
                    {
                        Numero num2;
                        Numero num1;
                        switch (char.Parse(equacao.Substring(i, i + 1)))
                        {
                            case '+':
                                num2 = (Numero)pilhaRes.Pop();
                                num1 = (Numero)pilhaRes.Pop();
                                pilhaRes.Push(new Numero(num1.GetNumero + num2.GetNumero));
                                break;

                            case '-':
                                num2 = (Numero)pilhaRes.Pop();
                                num1 = (Numero)pilhaRes.Pop();
                                pilhaRes.Push(new Numero(num1.GetNumero - num2.GetNumero));
                                break;
                            case '*':
                                num2 = (Numero)pilhaRes.Pop();
                                num1 = (Numero)pilhaRes.Pop();
                                pilhaRes.Push(new Numero(num1.GetNumero * num2.GetNumero));
                                break;
                            case '/':
                                num2 = (Numero)pilhaRes.Pop();
                                num1 = (Numero)pilhaRes.Pop();
                                pilhaRes.Push(new Numero(num1.GetNumero / num2.GetNumero));
                                break;
                            case '^':
                                num2 = (Numero)pilhaRes.Pop();
                                num1 = (Numero)pilhaRes.Pop();
                                pilhaRes.Push(new Numero(Math.Pow(num1.GetNumero, num2.GetNumero)));
                                break;
                            case 'R':
                                num2 = (Numero)pilhaRes.Pop();
                                pilhaRes.Push(new Numero(Math.Sqrt(num2.GetNumero)));
                                break;
                        }
                        equacao = equacao.Remove(i, i + 1);
                    }
                    else throw new ArgumentException("O parâmentro não é uma equação PosFixa", "equacao");
                }
            }

            result = (Numero)pilhaRes.Pop();
            return result.GetNumero;
        }


        /// <summary>
        /// Metódo que recebe uma equação matemática em forma de string para transforma-lá em pós fixa.
        /// </summary>
        /// <param name="equacao"></param>
        public static string PosFixa(string equacao)
        {
            int i = 0;
            while (equacao != "")
            {
                try
                {
                    Numero numero;
                    numero = new Numero(double.Parse((equacao.Substring(i, i + 1))));
                    equacao = equacao.Remove(i, i + 1);
                    pilhaRes.Push(numero);
                    // auxNum++;
                }
                catch
                {
                    if (ValidaSimbolo(char.Parse(equacao.Substring(i, i + 1))))
                    {
                        SimboloOperacional auxSimboloOP; // Só olha "Peek" o objeto
                        SimboloOperacional auxSimb; //guardar o objeto removido da pilha

                        switch (char.Parse(equacao.Substring(i, i + 1)))
                        {
                            case '+':
                                var soma = new SimboloOperacional(char.Parse(equacao.Substring(i, i + 1)), 1);
                                AdicionaOperador(soma);
                                equacao = equacao.Remove(i, i + 1);

                                break;

                            case '-':
                                var subtracao = new SimboloOperacional(char.Parse(equacao.Substring(i, i + 1)), 1);
                                AdicionaOperador(subtracao);
                                equacao = equacao.Remove(i, i + 1);
                                break;
                            case '*':
                                var multiplicacao = new SimboloOperacional(char.Parse(equacao.Substring(i, i + 1)), 2);
                                AdicionaOperador(multiplicacao);
                                equacao = equacao.Remove(i, i + 1);
                                break;
                            case '/':
                                var divisao = new SimboloOperacional(char.Parse(equacao.Substring(i, i + 1)), 2);
                                AdicionaOperador(divisao);
                                equacao = equacao.Remove(i, i + 1);
                                break;
                            case '^':
                                var exponencial = new SimboloOperacional(char.Parse(equacao.Substring(i, i + 1)), 3);
                                AdicionaOperador(exponencial);
                                equacao = equacao.Remove(i, i + 1);
                                break;
                            case '(':
                                var abreParentese = new SimboloOperacional(char.Parse(equacao.Substring(i, i + 1)), 0);
                                pilhaSimb.Push(abreParentese);
                                equacao = equacao.Remove(i, i + 1);
                                break;
                            case ')':
                                var fechaParentese = new SimboloOperacional(char.Parse(equacao.Substring(i, i + 1)), 0);
                                auxSimboloOP = (SimboloOperacional)pilhaSimb.Peek();
                                while (!pilhaSimb.Empty() && auxSimboloOP.Simbolo != '(')
                                {
                                    auxSimb = (SimboloOperacional)pilhaSimb.Pop();
                                    pilhaRes.Push(auxSimb);
                                    auxSimboloOP = (SimboloOperacional)pilhaSimb.Peek();
                                }
                                pilhaSimb.Pop(); // remove da pilha de simbolos o '('
                                equacao = equacao.Remove(i, i + 1);
                                break;

                            case 'R':
                                var raiz = new SimboloOperacional(char.Parse(equacao.Substring(i, i + 1)), 3);
                                AdicionaOperador(raiz);
                                equacao = equacao.Remove(i, i + 1);
                                break;
                        }
                    }
                    else throw new ArgumentException("Símbolo inválido na equaçao", "equacao");
                    //else
                    //{
                    //    equacao = ""; // Seta condição saída while, falha.
                    //    return "Símbolo inválido na equaçao.";
                    //}
                }
            }
            while (!pilhaSimb.Empty())
            {
                pilhaRes.Push(pilhaSimb.Pop());
            }      
            char[] arrChar = pilhaRes.ToString().ToCharArray();
            Array.Reverse(arrChar);
            pilhaRes = new Stack();
            pilhaSimb = new Stack();
            return new string(arrChar);
        }
    }
}
