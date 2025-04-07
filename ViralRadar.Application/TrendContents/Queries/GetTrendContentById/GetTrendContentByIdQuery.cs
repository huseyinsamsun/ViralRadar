using MediatR;
using ViralRadar.Core.Common.Responses;

namespace ViralRadar.Application.TrendContents.Queries.GetTrendContentById;

public class GetTrendContentByIdQuery:IRequest<BaseResponse<TrendContentByIdDto>>
{
    public Guid Id { get; set; }
}