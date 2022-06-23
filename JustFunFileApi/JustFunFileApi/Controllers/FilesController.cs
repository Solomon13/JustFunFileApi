using JustFunFileApi.Files.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JustFunFileApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilesController : Controller
    {
        private IMediator _requsetSender;

        public FilesController(IMediator requestSender)
        {
            _requsetSender = requestSender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _requsetSender.Send(new GetFilesQuery());

            return Ok(result);
        }

    }
}
