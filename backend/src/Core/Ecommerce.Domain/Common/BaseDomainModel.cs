namespace Ecommerce.Domain.Common;

public abstract class BaseDomainModel {
    public int Id;
    public DateTime CreatedDate;
    public string? CreatedBy;
    public DateTime? LastModifiedDate;
    public string? LastModifiedBy;

    

}