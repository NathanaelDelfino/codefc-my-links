using System;
using Microsoft.AspNetCore.Mvc;
using MyLinks.Domain.Repository;

namespace MyLinks.API.Controllers
{
    [ApiController]
    [Route("controller")]
    public class ResourceController : ControllerBase
    {
        private ILinkResourcesRepository _repository;
        public ResourceController(ILinkResourcesRepository repository)
        {
            _repository = repository;   
        }
        [HttpGet]
        public ActionResult Get(){
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult Get(Guid? id){
            return Ok(_repository.GetById(id.Value));
        }

        [HttpDelete("{id}")]
        public void Delete(Guid? id){
             _repository.DeleteById(id.Value);   
        }
    }
}