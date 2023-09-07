using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoMania.ClassLibrary.LinkedLists
{
    public class Node
    {
        public Node(string value)
        {
            Next = null;
            Value = value;
        }
        public Node Next { get; set; }
        public string Value { get; set; }
    }
}