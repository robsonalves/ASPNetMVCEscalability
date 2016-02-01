using System;

namespace Restaurant.Entity
{
    [Serializable]
    public class Waiter
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}