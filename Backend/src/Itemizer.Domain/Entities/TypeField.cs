using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class TypeField : Entity
{
    public string Name { get; set; }

    public Type Type { get; set; } = null!;
}