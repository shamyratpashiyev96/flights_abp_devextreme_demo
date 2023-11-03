using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace FlightsApp.Airports
{
    public class AirportAppService : CrudAppService<
        Airport,
        AirportDto,
        int,
        PagedAndSortedResultRequestDto,
        CreateUpdateDto>
    {
        public AirportAppService(IRepository<Airport, int> repository) : base(repository)
        {
        }
    }
}