using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLibrary
{
    interface IStructure
    {
       
        /// <summary>
        /// Adicionar um objeto no final da pilha
        /// </summary>
        /// <param name="Obj">Objeto Data.</param>
        void Push(Data Obj);
        /// <summary>
        /// Concatenar uma pilha  ao final da atual instância.
        /// </summary>
        /// <param name="stack">Objeto Stack.</param>
        void Concat(Stack stack);
        
        /// <summary>
        /// Remover da atual instância o último objeto
        /// </summary>
        /// <returns>Se a atual instância não estiver vázia, o último objeto é removido da atual instância e retonardo; caso contrário, é retornado 'null'</returns>
        Data Pop();
        /// <summary>
        /// Retorna o último objeto da pilha sem removê-lo
        /// </summary>
        /// <returns>Se a atual instância não estiver vázia, o último objeto é retornado da atual instância; caso contrário, é retornado 'null'</returns>
        Data Peek();
        /// <summary>
        /// Indica se a atual instância está vazia ou não.
        /// </summary>
        /// <returns>True se a atual instância estiver vazia; caso contrário, False.</returns>
        bool Empty();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Retorna uma cadeia de caracteres que representa a pilha atual</returns>
        string ToString();

    }
}
