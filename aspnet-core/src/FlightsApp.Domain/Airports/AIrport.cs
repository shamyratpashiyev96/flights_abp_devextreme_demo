using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace FlightsApp.Airports
{
    public class Airport : AuditedAggregateRoot<int>
    {
        [Column(TypeName = "VARCHAR(500)")]
        public string City { get; set; }

        [Column(TypeName = "VARCHAR(500)")]
        public string Code { get; set; }
    }
}