
using Microsoft.AspNetCore.Mvc;
using ViralRadar.Application.TrendContents.Commands;
using ViralRadar.Application.TrendContents.Queries.GetTrendContentById;
using ViralRadar.Core.Common.Responses;
    
namespace ViralRadar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrendContentController:BaseController
	{
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTrendContentCommand createTrendContentCommand)
        {
            BaseResponse<CreateTrendContentResponse> response = await Mediator.Send(createTrendContentCommand);
            if (response.Success)
            {
                return Created("", response);
            }
            else
            {
                return BadRequest(response.Errors);
            }
          
        }

       [HttpGet("{id}")]
        public async Task<IActionResult> GetTrendContentById([FromRoute] Guid id)
        {
            BaseResponse<TrendContentByIdDto> response = await Mediator.Send(new GetTrendContentByIdQuery() { Id = id });
            if (response.Success)
            {
                return Ok(response);
                
            }
            else
            {
                return BadRequest(response.Message);
            }
            
        }
    }
}

