using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    public abstract class Entity : IEntity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Entity(Guid id)
        {
            this.Id = id;
        }

        public bool IsValid()
        {
            return Id != Guid.Empty;
        }

        public virtual string Format()
        {
            return "[" + Id.ToString() + "]";
        }

        public abstract bool Search(string searchString);
    }
}
