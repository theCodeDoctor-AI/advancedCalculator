using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ModelLibrary
{
    public class NumberSet
    {        
        // Auto - Implemented
        public List<int> Numbers { get; set; }
        public string NumberSetName { get; set; }


        // Constructors
        public NumberSet() { }
        public NumberSet(List<int> numbers, string name)
        {
            Numbers = numbers;
            NumberSetName = name;
        }

        // Maybe not needed placeholder for now
        public override string ToString()
        {
            return string.Empty;
        }
    }
}
