using LifecycleExample.Services;
using Microsoft.AspNetCore.Mvc;

namespace LifecycleExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LifecyclesController : Controller
    {
        private readonly SingletonService _singletonService;
        private readonly TransientService _transientService;
        private readonly ScopedService _scopedService;

        public LifecyclesController(SingletonService singletonService, TransientService transientService, ScopedService scopedService)
        {
            _singletonService = singletonService;
            _transientService = transientService;
            _scopedService = scopedService;
        }

        [HttpGet("singleton")]
        public IActionResult GetSingletonId([FromServices] SingletonService singletonService2)
        {
            var id1 = _singletonService.ShowId();
            var id2 = singletonService2.ShowId();
            var result = $"Controller: {id1}\nRota: {id2}";
            return Ok(result);
        }

        [HttpGet("scoped")]
        public IActionResult GetScopedId([FromServices] ScopedService scopedService2)
        {
            var id1 = _scopedService.ShowId();
            var id2 = scopedService2.ShowId();
            var result = $"Controller: {id1}\nRota: {id2}";
            return Ok(result);
        }

        [HttpGet("transient")]
        public IActionResult GetTransientId([FromServices] TransientService transientService2)
        {
            var id1 = _transientService.ShowId();
            var id2 = transientService2.ShowId();
            var result = $"Controller: {id1}\nRota: {id2}";
            return Ok(result);
        }
    }
}
