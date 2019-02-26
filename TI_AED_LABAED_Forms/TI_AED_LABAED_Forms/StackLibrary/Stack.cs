using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLibrary
{
    /// <summary>
    /// Classe para uma pilha, contém métodos virtuais da estrutura e pode ser herdada em uma estrutura de dados
    /// </summary>
    public class Stack : IStructure
    {
        private Element back, top; // top == topo, back == fundo
        int count;

        /// <summary>
        /// Inicializa uma nova instância de pilha duplamente encadeada que está vazia e tem a capacidade inicial padrão
        /// </summary>
        public Stack()
        {
            this.top = new Element(null); //sentinela, o topo da pilha é um elemento é nulo.
            this.back = this.top; // A pilha está vazia, logo, o topo e o fundo aponta para o nulo
            count = 0; // pilha vazia
        }

        public int Count { get { return count; } }
        protected Element Back { get { return back; } set { back = value; }}
        protected Element Top { get { return top; } set { top = value; } }

        /// <summary>
        /// Adicionar um objeto no final da pilha
        /// </summary>
        /// <param name="Obj">Objeto Data.</param>
        public virtual void Push(Data Obj)
        {
            if (!this.Empty())
            {
                Element _new = new Element(Obj);
                _new.next = this.top.next;
                this.top.next = _new;
            }
            else
            {         
                this.top.next = new Element(Obj);
                this.back = this.top.next;
            }          
            this.count++;

        }


        /// <summary>
        /// Concatenar uma pilha ao final da atual instância.
        /// </summary>
        /// <param name="stack">Objeto Stack.</param>
        public virtual void Concat( Stack stack)
        {
            if (!stack.Empty())
            {
                stack.back.next = this.top.next;
                this.top.next = stack.top.next;
                if (this.Empty())
                {
                    this.back = stack.back;
                }
                this.count += stack.Count;
                stack = new Stack();
            }
            else throw new ArgumentNullException("O parâmetro é nulo", "stack");
        }

        /// <summary>
        /// Retorna o último objeto da pilha sem removê-lo
        /// </summary>
        /// <returns>Se a atual instância não estiver vázia, o último objeto é retornado da atual instância; caso contrário, é retornado 'null'</returns>
        public virtual Data Peek()
        {
            if (!this.Empty())
            {
                Element aux = new Element(this.top.next.Data);
                return aux.Data;
            }
            return null;
        }
        
        /// <summary>
        /// Remover da atual instância o último objeto
        /// </summary>
        /// <returns>Se a atual instância não estiver vázia, o último objeto é removido da atual instância e retonardo; caso contrário, é retornado 'null'</returns>
        public virtual Data Pop()
        {
            if (!this.Empty())
            {
                Element aux = this.top.next; //auxiliar   
                this.top.next = aux.next;
                aux.next = null;
                if (aux == this.back)
                {
                    this.back = this.top;
                }                  
                count--; // atualiza a quantidade de elementos da pilha
                return aux.Data;
            }
            return null;
        }
        
        

        /// <summary>
        /// Indica se a atual instância está vazia ou não.
        /// </summary>
        /// <returns>True se a atual instância estiver vazia; caso contrário, False.</returns>
        public bool Empty()
        {
            return (this.top == this.back);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Retorna uma cadeia de caracteres que representa o objeto atual</returns>
        public override string ToString()
        {
            Element aux = this.top.next;
            StringBuilder _return = new StringBuilder();
            while (aux != null)
            {
                _return.AppendFormat(aux.Data.ToString());
                aux = aux.next;
            }
            return _return.ToString();
        }


    }
}
