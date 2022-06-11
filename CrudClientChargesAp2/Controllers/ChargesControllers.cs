using CrudClientChargesAp2.Models.Domains;
using CrudClientChargesAp2.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CrudClientChargesAp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChargesController:ControllerBase
        {
        private IChargeRepository repository;

        public ChargesController(IChargeRepository repository)
        { 
            this.repository = repository;
        }
        [HttpGet()] 
        public IEnumerable<Charge>Get()
        {
            return repository.GetAll();
        }
        [HttpGet("{id}")] 
        public Charge Get(int id){
            return repository.GetById(id);
        }
        [HttpPost()]
        public IActionResult Post([FromBody]Charge charge)
        {
            repository.Create(charge);
            return Ok(charge);
        } 
        [HttpPut]
        public ActionResult Put([FromBody] Charge charge)
        {
            repository.Update(charge);
            return Ok(new {
                message = "Cobrança Atualizada",
                errorCode = 202,
                objCreated = charge
                });
        }

        [HttpDelete("{Id}")]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok( new {
                message = "Cobrança Deletada.",
                errorCode = 202
            });
        }

    }
}