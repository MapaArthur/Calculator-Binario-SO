using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLibrary
{
    public sealed class Element : IComparable<Element>, IEquatable<Element>
    {
        private DataList data;
        internal Element previous;
        internal Element next;

        public DataList Data { get {return data; } }
        public Element Next { get { return next; } set { next = value; } }
        public Element Previous { get { return previous; } set { previous = value; } }

        public Element(DataList d)
        {
            this.data = d;
            this.next = null;
            this.previous = null;
        }
        public int CompareTo(Element other)
        {
            return this.data.CompareTo(other.data);
        }

        public bool Equals(Element other)
        {
            return this.data.Equals(other.data);
        }
    }
}
