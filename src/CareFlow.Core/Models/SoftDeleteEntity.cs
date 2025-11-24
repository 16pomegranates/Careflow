namespace CareFlow.Core.Models
{
    public abstract class SoftDeleteEntity : EntityBase
    {
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
