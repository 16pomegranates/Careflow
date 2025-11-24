namespace CareFlow.Core.Models
{
    public abstract class RequestBase
    {
        public Guid TraceId { get; set; }
    }
}
