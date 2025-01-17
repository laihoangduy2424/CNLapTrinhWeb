using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("cv_dt")]
        public IActionResult tinh_chuvi_dientich_duongkinh(double rr)
        {
            if (rr <= 0)
                return BadRequest("Bán kính phải dương");
            double cv = 3.14 * 2 * rr;
            double dt = 3.14 * rr * rr;
            double dk = rr * 2;
            var json_str = new { dientich = dt, chuvi = cv, duongkinh = dk };
            return Ok(json_str);
        }
    }
}
