using System;
using AutoMapper;
using MediatR;
using Serilog;
using ViralRadar.Application.Common.Message;
using ViralRadar.Core.Common.Responses;
using ViralRadar.Core.Interfaces;
using ViralRadar.Domain.Entities;

namespace ViralRadar.Application.TrendContents.Commands
{
    public class CreateTrendContentCommandHandler : IRequestHandler<CreateTrendContentCommand, BaseResponse<long>>
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<TrendContent> _repository;
        private readonly ILogger _logger;


        public CreateTrendContentCommandHandler(IMapper mapper, IGenericRepository<TrendContent> repository,ILogger logger)
        {
            _mapper = mapper;
            _repository = repository;
            _logger = logger;
        }

        public async Task<BaseResponse<long>> Handle(CreateTrendContentCommand request, CancellationToken cancellationToken)
        {
            _logger.Information("Yeni TrendContent oluşturma başladı.{@Request}", request);
            try
            {
                var entity = _mapper.Map<TrendContent>(request);

                await _repository.AddAsync(entity);

                if (entity != null && entity.Id > 0)
                {
                    _logger.Information("Yeni TrendContentOluşturuldu.{@Id}", entity.Id);
                    return BaseResponse<long>.SuccessResponse(entity.Id, TrendContentResponseMessage.KayitEklemeBasarili);
                }

                _logger.Warning("Hatalı oluşturma", entity);
                return BaseResponse<long>.Failure(TrendContentResponseMessage.KayitEklemeHatali);
            }
            catch (Exception ex)
            {
               
                _logger.Warning("Hatalı oluşturma {@Message}", ex.Message);
                return BaseResponse<long>.Failure($"Hata oluştu: {ex.Message}");
            }
        }
    }
}

