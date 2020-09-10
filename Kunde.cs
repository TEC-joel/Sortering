using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Sortering
{
    class Kunde : IComparable<Kunde>
    {
        public string Fnavn { get; set; }
        public string Enavn { get; set; }
        public int Alder { get; set; }

        public Kunde()
        {
            
        }

        public Kunde(string fnv, string env, int alder)
        {
            Fnavn = fnv;
            Enavn = env;
            Alder = alder;
        }

        public int CompareTo(Kunde other)
        {
            return string.Compare(this.Fnavn, other.Fnavn );
        }
    }
}
