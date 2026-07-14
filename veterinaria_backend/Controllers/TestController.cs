using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using veterinaria_backend.Infrastructure;

namespace veterinaria_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly DbVeterinarySjlContext _context;

        public TestController(DbVeterinarySjlContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Test()
        {
            var result = new
            {
                status = "success",
                code = 200,
                message = "Operation completed successfully."
            };

            return Ok(result);
        }

        [HttpGet("connection")]
        public IActionResult Connection()
        {
            // Consulta básica
            var canConnect = _context.Database.CanConnect();

            return Ok(new
            {
                connected = canConnect
            });

        }
    }

}
