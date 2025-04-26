using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class OrderController : ControllerBase
{
    #region GET
    
    [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get([FromQuery]Guid id)
        {
            try
            {
                return  Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    #endregion

    #region POST

    

    #endregion
    
    #region PUT
    
    
    
    #endregion
    
    #region DELETE
    
        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> Delete(Guid id)
        {
            try
            {
                return  Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 
    
    #endregion
    
    #region PATCH
    
    
    #endregion

}