using Microsoft.AspNetCore.Mvc;

namespace MyAppService.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class MyDataController : Controller {
        public MyDataController() { }
        // I would make this async if I had a persistence layer.
        // GET: api/MyController/data
        [HttpGet("data")]
        public JsonResult GetData() {
            var result = new[] {
             "Item 1!",
             "Item 2!",
             "Item 3!",
             "Etc. etc. etc."
            };

            return Json(result);
        }
    }
}