using Volo.Abp.Application.Dtos;

namespace FlightsApp.Airports
{
    public class AirportDto : AuditedEntityDto<int>
    {
        public string City { get; set; }
        public string Code { get; set; }
    }
}