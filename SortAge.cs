using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Sortering
{
    class SortAge : IComparer<Kunde>
    {
        public int Compare([AllowNull] Kunde x, [AllowNull] Kunde y)
        {
            return x.Alder.CompareTo(y.Alder);
        }
    }
}
