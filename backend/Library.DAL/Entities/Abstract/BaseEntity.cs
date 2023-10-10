namespace Library.DAL.Entities.Abstract;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime UpdatedAt { get; set; }
    private DateTime _createdAt;

    protected BaseEntity()
    {
        CreatedAt = UpdatedAt = DateTime.Now;
    }

    public DateTime CreatedAt
    {
        get => _createdAt;
        set => _createdAt = (value == DateTime.MinValue) ? DateTime.Now : value;
    }
}