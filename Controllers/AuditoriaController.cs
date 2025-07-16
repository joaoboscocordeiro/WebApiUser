using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiUser.Services.Auditoria;

namespace WebApiUser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuditoriaController : ControllerBase
    {
        private readonly IAuditoriaInterface _auditoriaInterface;

        public AuditoriaController(IAuditoriaInterface auditoriaInterface)
        {
            _auditoriaInterface = auditoriaInterface;
        }

        [HttpGet("Auditoria")]
        public async Task<IActionResult> BuscarAuditoria()
        {
            var auditorias = await _auditoriaInterface.BuscarAuditoria();
            return Ok(auditorias);
        }
    }
}
