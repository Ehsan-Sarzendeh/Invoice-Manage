using System;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManage.Database.Entities.Common
{
    public abstract class BaseEntity : IEntity
    {
        [Display(Name = "شناسه")]
        public int Id { get; set; }
    }
}
