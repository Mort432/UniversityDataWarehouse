using System;

namespace UniversityDataWarehouse.Data.Entities
{
    public interface IEntity : IEquatable<IEntity>
    {
        int Id { get; set; }
    }
}