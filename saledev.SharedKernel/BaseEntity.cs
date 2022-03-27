using System.ComponentModel.DataAnnotations;

namespace saledev.SharedKernel;

// This can be modified to BaseEntity<TId> to support multiple key types (e.g. Guid)
public abstract class BaseEntity<TId> where TId : struct
{
    public TId Id { get; set; }

    [StringLength(255)]
    public string? CreatedBy { get; set; }

    [StringLength(255)]
    public string? UpdatedBy { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public List<BaseDomainEvent> Events = new();
}
