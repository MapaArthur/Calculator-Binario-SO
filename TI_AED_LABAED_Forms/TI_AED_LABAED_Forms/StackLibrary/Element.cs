using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLibrary
{
    public sealed class Element
    {
        private Data data;
        internal Element next;

        public Data Data { get { return data; } }
        public Element Next { get { return next; } set { next = value; } }

        public Element(Data d)
        {
            this.data = d;
            this.next = null;
        }
    }
}
