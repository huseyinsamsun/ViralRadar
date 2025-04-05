using System;
using ViralRadar.Core.Common;
using ViralRadar.Core.Interfaces;
using ViralRadar.Domain.Entities;

namespace ViralRadar.Application.Services
{
	public class TrendContentService
	{
		private readonly IGenericRepository<TrendContent> _trendContentRepository;
		public TrendContentService(IGenericRepository<TrendContent> trendContentRepository)
		{
			_trendContentRepository = trendContentRepository;
		}

		public async Task<IEnumerable<TrendContent>> GetAllTrendContentAsync()
		{
			try
			{
                var allTrend = await _trendContentRepository.GetAllAsync();
                if (allTrend?.Any() == true)
                {
                    return allTrend;
                }
    
            }
			catch (Exception ex)
			{
                return Result<IEnumerable<TrendContent>>.Failure($"Veri alınırken hata oluştu: {ex.Message}");
            }
			
        }

		public  void AddTrendContent(TrendContent trendContent)
		{
			 _trendContentRepository.AddAsync(trendContent);
		}
		public  void AddRangeTrendContent(List<TrendContent> trendContents)
		{
			if(trendContents?.Any()==true)
			{
                _trendContentRepository.AddRangeAsync(trendContents);
            }
		
		}
		public async Task<TrendContent?> TrendContentGetById(TrendContent trendContent)
		{
			var trend = (await _trendContentRepository.FindAsync(t => t.Id == trendContent.Id)).FirstOrDefault();
			if(trend!=null)
			{
                return trend;
            }
			return new TrendContent();
		
		}

		public  void UpdateTrendContent(TrendContent trendContent)
		{
			 _trendContentRepository.Update(trendContent);
		}
		public void RemoveTrendContent(TrendContent trendContent)
		{
			_trendContentRepository.Remove(trendContent);
		}
	
			 
		
	}
}

