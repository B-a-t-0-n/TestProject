using Dadata.Model;
using Dadata;
using Microsoft.AspNetCore.Mvc;
using TestProject.Model.Dto;

namespace TestProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdressController : ControllerBase
    {
        private readonly ILogger<AdressController> _logger;

        public AdressController(ILogger<AdressController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Конечная точка ОК
        /// </summary>
        /// <param name="Adress"></param>
        /// <returns>HTTP код</returns>
        /// 
        /// <response code="200">Успешное выполнение запроса</response>
        [HttpGet]
        [ProducesResponseType<OkResult>(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAdress(string Adress)
        {

            var builder = WebApplication.CreateBuilder();
            var token = builder.Configuration["UserSettings:Token"];
            var secret = builder.Configuration["UserSettings:Secret"];

            var api = new CleanClientAsync(token, secret);
            var result = await api.Clean<Address>(Adress);
            
            return Ok(result);
        }
    }
}
