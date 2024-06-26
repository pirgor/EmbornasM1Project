using M1_Partial_Library.Data;
using M1_Partial_Library.Objects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmbornasM1Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ISqlData _db;

        public ItemController(ISqlData db)
        {
            _db = db;
        }

        // POST Item Info
        [AllowAnonymous]
        [HttpPost]
        [Route("/api/[controller]/addItem")]
        public IActionResult AddItem([FromBody] Item item)
        {
            if (item == null)
            {
                return BadRequest("Item object is null");
            }

            _db.addItem(item);

            return Ok("Item added successfully.");
        }

        // GET Item Info
        [AllowAnonymous]
        [HttpGet]
        [Route("/api/[controller]/getItem")]
        public IActionResult GetItem(int id)
        {
            Item item = _db.ReadData(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        //Update Item Info
        [AllowAnonymous]
        [HttpPut]
        [Route("/api/[controller]/updateItem")]
        public IActionResult UpdateItem([FromBody] Item item)
        {
            if (item == null)
            {
                return BadRequest("Item object is null");
            }

            Item existingItem = _db.ReadData(item.Id);

            if (existingItem == null)
            {
                return NotFound("Item not found");
            }

            existingItem.Name = item.Name;
            existingItem.Code = item.Code;
            existingItem.Brand = item.Brand;
            existingItem.UnitPrice = item.UnitPrice;

            _db.UpdateData(existingItem);

            return Ok("Item updated successfully.");
        }

    }
}
