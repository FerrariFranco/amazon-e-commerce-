using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;
class Image : BaseDomainModel
{
    [Column(TypeName ="NVARCHAR(4000)")]
    public string? Url {get; set;}
    public int ProductId { get; set; }
    public string? ProductCode { get; set;}
}