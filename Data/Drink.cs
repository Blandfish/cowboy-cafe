using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// base class representing a drink
    /// </summary>
    public abstract class Drink
    {
        public Size Size;

        public abstract double Price { get; }

        public abstract uint Calories { get; }

        public abstract List<string> SpecialInstructions { get; set; }

        public bool Ice { get; set; } = true;
    }
}