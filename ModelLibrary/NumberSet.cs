using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ModelLibrary
{
    public class NumberSet
    {
        // Fields
        private int _totalEntries;
        private int _minValue;
        private int _maxValue;

        // Properties
        public int TotalEntries
        {
            get { return _totalEntries; }
            set { _totalEntries = Numbers.Count; }
        }

        public int MinValue
        {
            get { return _minValue; }
            set { _minValue = Numbers.Min(); }
        }

        public int MaxValue
        {
            get { return _maxValue; }
            set { _maxValue = Numbers.Max(); }
        }

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

        public override string ToString()
        {
            return string.Empty;
        }
    }
}
