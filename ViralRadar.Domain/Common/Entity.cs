using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace ViralRadar.Domain.Common
{
    public abstract class Entity<TId>:IEntity<Guid>
	{
        [Key]
        public Guid Id { get; protected set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; protected set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get;set; }
        public bool IsDeleted { get;set; }

        public Entity()
        {

        }

    }
}

