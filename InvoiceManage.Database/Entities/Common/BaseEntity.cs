using System;

namespace InvoiceManage.Database.Entities.Common
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
