using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Sortering
{
    class SortEnavn : IComparer<Kunde>
    {
        public int Compare(Kunde x, Kunde y)
        {
            return string.Compare(x.Enavn, y.Enavn);
        }
    }
}
