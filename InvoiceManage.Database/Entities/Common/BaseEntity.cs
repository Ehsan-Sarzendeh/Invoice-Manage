using System;

namespace InvoiceManage.Database.Entities.Common
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
    }
}
