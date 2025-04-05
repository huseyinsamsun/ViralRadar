using System;
using System.Security.Cryptography;

namespace ViralRadar.Domain.Common
{
	public interface IEntity<TId> where TId:struct
	{
        TId Id { get; }
        DateTime CreatedDate { get; }
        DateTime? UpdatedDate { get; set; }
        bool IsDeleted { get; set; }
    }
}

