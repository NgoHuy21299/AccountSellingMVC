namespace AccountSellingMVC.Entities
{
    public abstract class EntityBase<T>
    {
        public T Id { get; set; } = default!;
    }
}