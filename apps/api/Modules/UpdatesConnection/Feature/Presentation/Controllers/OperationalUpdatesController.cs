using Microsoft.AspNetCore.Mvc;

namespace api.Modules.RulesConnection.Controllers;

[ApiController]
[Route("[controller]")]
public class OperationalUpdatesController : ControllerBase
{
    [HttpGet(Name ="OperationalUpdates")]
    public string GetAll()
    {
        return "Operational Updates API";
    }

    [HttpGet("{id}", Name ="GetByIdOperationalUpdates")]
    public IActionResult GetById( int id)
    {
        return Ok();
    }

    [HttpPost(Name ="CreateOperationalUpdates")]
    public IActionResult Create([FromBody] CreateOperationalUpdateDto dto)
    {
         return Ok();
    }    

    [HttpPut("{id}", Name = "UpdateOperationalUpdates")]
    public IActionResult Update(int id, [FromBody] UpdateOperationalUpdateDto dto)
    {
        return Ok();
    }
}
