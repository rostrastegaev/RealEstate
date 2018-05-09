using System;

namespace RealEstate.Core
{
    public abstract class Entity
    {
        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime ModifiedAt { get; private set; }

        public Entity()
        {
            var now = DateTime.UtcNow;
            CreatedAt = now;
            ModifiedAt = now;
        }

        protected void Update()
        {
            ModifiedAt = DateTime.UtcNow;
        }
    }
}
