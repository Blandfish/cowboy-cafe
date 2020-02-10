using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// base class representing an entree
    /// </summary>
    public abstract class Entree
    {
        public abstract double Price { get; }

        public abstract uint Calories { get; }

        public virtual List<string> SpecialInstructions { get; set; }
    }
}