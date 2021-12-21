using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary
{
    public class Fraction
    {
        // Fields
        private int _numerator;
        private int _denominator;
        private double _decimalForm;

        // Properties / Getters / Setters
        public int Numerator { get { return _numerator; } set { _numerator = value; } }
        public int Denomitor
        {
            get { return _denominator; }
            set
            {
                if (value == 0) { throw new Exception("Cannot have denominator = 0"); }
                _denominator = value;
            }
        }

        public double DecimalForm 
        {  
            get { return _decimalForm; } 
            set { _decimalForm = (double)Numerator / Denomitor; } 
        }


        // Contructor(s)
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denomitor = denominator;
        }



        // String
        public override string ToString()
        {
            return $"{Numerator} / {Denomitor} or {DecimalForm}";
        }
    }
}
