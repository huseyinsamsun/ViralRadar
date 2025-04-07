using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using ViralRadar.Application.Common.Message;
using ViralRadar.Application.Interfaces;
using ViralRadar.Core.Common.Responses;

namespace ViralRadar.Application.TrendContents.Queries.GetTrendContentById;

public class GetTrendContentByIdQueryHandler:IRequestHandler<GetTrendContentByIdQuery,BaseResponse<TrendContentByIdDto>>
{
    private readonly ITrendContentRepository _trendContentRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetTrendContentByIdQuery> _logger;

    public GetTrendContentByIdQueryHandler(ITrendContentRepository trendContentRepository,IMapper mapper,ILogger<GetTrendContentByIdQuery> logger)
    {
        _trendContentRepository = trendContentRepository;
        _mapper = mapper;
        _logger = logger;
        
    }
    
    public async Task<BaseResponse<TrendContentByIdDto>> Handle(GetTrendContentByIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var trendContent=await _trendContentRepository.FindAsync(x=>x.Id==request.Id);
            if (trendContent?.Any() == true)
            {
                return  BaseResponse<TrendContentByIdDto>.SuccessResponse(_mapper.Map<TrendContentByIdDto>(trendContent),"");
            }
            else
            {
                return BaseResponse<TrendContentByIdDto>.Failure("Hata");
            }
        }
        catch (Exception e)
        {
            return BaseResponse<TrendContentByIdDto>.Failure(e.Message);
        }

        
        

    }
}