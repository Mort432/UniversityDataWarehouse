namespace UniversityDataWarehouse.Data.Entities
{
    public abstract class EntityBase : IEntity
    {
        //We know that every entity (excluding those without unique IDs like join tables)
        //Is going to have an ID. So, why not give them a base class that gives them that for free?
        public int Id { get; set; }

        public bool Equals(IEntity other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return Id == other.Id;
        }

        //By comparing IDs AND types, we can find out when two entities are the same!
        //Hooray, determinism!
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            return Equals((IEntity) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}