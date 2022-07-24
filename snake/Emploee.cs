using System;
namespace snake
{
    public class Emploee : Human
    {
        public int pay;

        public override string ToString()
    {
        return $"Emploee: [name - {name} | age - {age} | salary {pay}]";
    }
    }


}

