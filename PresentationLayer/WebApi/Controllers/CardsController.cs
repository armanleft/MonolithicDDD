using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Post([FromBody] string value)
        {
            try
            {
                return Ok(await _facadeService.Create(value));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        #endregion
    }
}