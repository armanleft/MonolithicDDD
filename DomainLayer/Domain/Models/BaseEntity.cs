using Domain.Contract.Models;
using System;

namespace Domain.Models
{
    public abstract class BaseEntity : IBaseEntity
    {
        #region Properties

        public Guid Id { get; set; }

        #endregion

        #region Constructors

        protected BaseEntity()
        {
            Id = new Guid();
        }

        #endregion
    }
}