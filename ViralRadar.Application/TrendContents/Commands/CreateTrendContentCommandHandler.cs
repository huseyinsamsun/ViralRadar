using System;
using AutoMapper;
using MediatR;
using Serilog;
using ViralRadar.Application.Common.Message;
using ViralRadar.Core.Common.Responses;
using ViralRadar.Core.Interfaces;
using Microsoft.Extensions.Logging;
using ViralRadar.Domain.Entities;
using ViralRadar.Application.Interfaces;

namespace ViralRadar.Application.TrendContents.Commands
{
    public class CreateTrendContentCommandHandler : IRequestHandler<CreateTrendContentCommand, BaseResponse<CreateTrendContentResponse>>
    {
        private readonly IMapper _mapper;
        private readonly ITrendContentRepository _repository;
        private readonly ILogger<CreateTrendContentCommand> _logger;  


        public CreateTrendContentCommandHandler(IMapper mapper, ITrendContentRepository repository,ILogger<CreateTrendContentCommand> logger)
        {
            _mapper = mapper;
            _repository = repository;
            _logger = logger; 
        }

        public async Task<BaseResponse<CreateTrendContentResponse>> Handle(CreateTrendContentCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Yeni TrendContent oluşturma başladı.{@Request}", request);
            try
            {
                var entity = _mapper.Map<TrendContent>(request);
       

                await _repository.AddAsync(entity); 

                if (entity != null)
                {
                    _logger.LogInformation("Yeni TrendContentOluşturuldu.{@Id}", entity.Id);

                    CreateTrendContentResponse responseMessage = _mapper.Map<CreateTrendContentResponse>(entity);   

                    return BaseResponse<CreateTrendContentResponse>.SuccessResponse(responseMessage, TrendContentResponseMessage.KayitEklemeBasarili);
                }

                _logger.LogWarning("Hatalı oluşturma", entity);
                return BaseResponse<CreateTrendContentResponse>.Failure(TrendContentResponseMessage.KayitEklemeHatali);
            }
            catch (Exception ex)
            {
               
                _logger.LogWarning("Hatalı oluşturma {@Message}", ex.Message);
                return BaseResponse<CreateTrendContentResponse>.Failure($"Hata oluştu: {ex.Message}");
            }
        }
    }
}

