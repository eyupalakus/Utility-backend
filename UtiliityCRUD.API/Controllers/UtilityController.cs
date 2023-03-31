using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UtilityCRUD.Business;
using UtilityCRUD.Business.Concrete;
using UtilityCRUD.DataAccess.Concrete;
using UtilityCRUD.Entities;

namespace UtiliityCRUD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilityController : ControllerBase
    {
        private IUtilityService _utilityService;
        public UtilityController()
        {
            _utilityService = new UtilityService();
        }
        [HttpGet]
        public List<Utility> Get()
        {
            return _utilityService.GetAllUtility();
        }
        [HttpGet("{id}")]
        public Utility Get(int id)
        {
            return _utilityService.GetUtilityById(id);
        }
        [HttpPost]
        public Utility Post([FromBody] Utility utility) {
            return _utilityService.CreateUtility(utility);
        }
        [HttpPut]
        public Utility Put([FromBody] Utility utility)
        {
            return _utilityService.UpdateUtility(utility);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _utilityService.DeleteUtility(id);
        }
    }
}
