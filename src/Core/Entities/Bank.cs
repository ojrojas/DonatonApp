using Core.Interfaces;

namespace Core.Entities
{
    public class Bank: BaseEntity, IAggregateRoot
    {
        public string Description { get; set; }
    }
}