using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Presentation.Contract.CommandDtos.Cards;
using Presentation.Contract.FacadeGatewayInterfaces;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        #region Fields

        private readonly ICardFacadeGatewayService _facadeService;

        #endregion

        #region Constructors

        public CardsController(ICardFacadeGatewayService facadeService)
        {
            _facadeService = facadeService;
        }

        #endregion

        #region Public Methods

        [HttpPost]
        public async Task<IActionResult> Post(CreateCardCommand command)
        {
            try
            {
                return Ok(await _facadeService.Create(command));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //TODO: Check how to get multi parameters from body
        [HttpPut]
        public async Task<IActionResult> Put(UpdateCardCommand command)
        {
            try
            {
                await _facadeService.Update(command);
                return Ok();
            }
            //TODO: Check how to get exceptions
            catch (Exception e)
            {
                //TODO: return public return type. {status, message, data}
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] string id)
        {
            try
            {
                await _facadeService.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        #endregion
    }
}