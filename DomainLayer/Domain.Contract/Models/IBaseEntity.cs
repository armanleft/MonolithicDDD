using System;

namespace Domain.Contract.Models
{
    public interface IBaseEntity
    {
        public Guid Id { get; set; }
    }
}