using System;

namespace Restaurant.Entity
{
    [Serializable]
    public class Table
    {
        public Guid Id { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
