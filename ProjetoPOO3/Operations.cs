using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPOO3
{
    public class Operations
    {
        decimal media;

        public decimal MediaAritimetica(decimal n1, decimal n2, decimal n3)
        {
            media = (n1 + n2 + n3) / 3;
            return media;
        }
    }
}
