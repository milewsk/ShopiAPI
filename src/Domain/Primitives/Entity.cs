namespace Domain.Primitives;

public abstract class Entity
{
    #region Constructors
    protected Entity(Guid id)
    {
        Id = id;
        InsertionDate = DateTime.Now;
    }

    protected Entity()
    {
    }

    #endregion
    
    #region Properties
    public Guid Id { get; protected set; }
    public DateTime InsertionDate { get; protected set; }
    public DateTime LastModified { get; protected set; }

    #endregion

    #region Methods
    public void UpdateLastModified()
    {
        LastModified = DateTime.UtcNow;
    }

    #endregion
}