using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        // knows (properties)
        // what is its data (payload)
        // whats next (next node)
        string Directions { get; set; }

        Node Next { get; set; }

        // does (methods)
        public Node()
        {

        }
    }
}
