using Core.Interfaces;

namespace Core.Entities
{
    public class StateMaterial: BaseEntity, IAggregateRoot
    {
        public string Description { get; set; }
    }
}