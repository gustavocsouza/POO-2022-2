using CrudClientChargesAp2.Models.Domains;
using CrudClientChargesAp2.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CrudClientChargesAp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController:ControllerBase
        {
        private IClientRepository repository;

        public ClientsController(IClientRepository repository)
        { 
            this.repository = repository;
        }
        [HttpGet()] 
        public IEnumerable<Client>Get()
        {
            return repository.GetAll();
        }
        [HttpGet("{id}")] 
        public Client Get(int id){
            return repository.GetById(id);
        }
        [HttpPost()]
        public IActionResult Post([FromBody]Client client)
        {
            repository.Create(client);
            return Ok(client);
        } 
        [HttpPut]
        public ActionResult Put([FromBody] Client client)
        {
            repository.Update(client);
            return Ok(new {
                message = "Cliente Atualizado",
                errorCode = 202,
                objCreated = client
                });
        }

        [HttpDelete("{Id}")]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok( new {
                message = "Cliente Deletado.",
                errorCode = 202
            });
        }

    }
}