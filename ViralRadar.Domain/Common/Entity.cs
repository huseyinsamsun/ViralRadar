using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace ViralRadar.Domain.Common
{
    public abstract class Entity<TId>:IEntity<TId> where TId:struct
	{
        [Key]
        public TId Id { get; protected set; }
        public DateTime CreatedDate { get; protected set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get;set; }
        public bool IsDeleted { get;set; }


        protected Entity()
        {

        }
        protected Entity(TId id)
        {
            Id = id;
        }

    }
}

