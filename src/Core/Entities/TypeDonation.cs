using Core.Interfaces;

namespace Core.Entities
{
    public class TypeDonation: BaseEntity, IAggregateRoot
    {   
        public string Description { get; set; }
    }
}