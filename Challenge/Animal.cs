using System;

namespace Challenge
{
    public class Animal
    {
        public virtual string Move()
        {
            return "The animal moves in a generic manner.";
        }

        public override string ToString()
        {
            return "This is a generic Animal.";
        }
    }
}
