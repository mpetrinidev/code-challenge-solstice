using AutoMapper;
using ChallengeMpetrini.Api.Contracts;
using ChallengeMpetrini.Api.DTOs;
using ChallengeMpetrini.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ChallengeMpetrini.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IService<Contact> _service;
        private readonly IMapper _mapper;
        public ContactsController(IService<Contact> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<ContactDto> contacts = _mapper.Map<IEnumerable<ContactDto>>(_service.GetAll(null, p => p.City, p => p.City.State));
            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ContactDto contact = _mapper.Map<ContactDto>(_service.GetBy(p => p.Id == id, p => p.City, p => p.City.State));
            return Ok(contact);
        }

        [HttpPost]
        public IActionResult Post(AddOrUpdateContactDto model)
        {
            if (_service.Exists(p => p.Email == model.Email)) return BadRequest("This email is already in use");

            Contact entity = _mapper.Map<Contact>(model);
            _service.Add(entity);

            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        [HttpPut]
        public IActionResult Put([FromBody] AddOrUpdateContactDto model)
        {
            if (_service.Exists(p => p.Id != model.Id && p.Email == model.Email)) return BadRequest("This email is already in use");

            Contact entityDb = _mapper.Map<Contact>(model);
            _service.Update(entityDb);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Contact entity = _service.GetBy(p => p.Id == id);
            if (entity == null) return BadRequest("This contact does not exist");

            _service.Delete(entity);

            return Ok();
        }

        [HttpGet("search/{q}")]
        public IActionResult Search(string q)
        {
            ContactDto contact = _mapper.Map<ContactDto>(_service.GetBy(p => p.Email == q || p.Home_Phone_Number.Contains(q) || p.Work_Phone_Number.Contains(q) || p.Mobile_Phone_Number.Contains(q), p => p.City, p => p.City.State));
            return Ok(contact);
        }

        [HttpGet("getfrom/{stateOrCity}")]
        public IActionResult ContactsFromStateOrCity(string stateOrCity)
        {
            IEnumerable<ContactDto> contacts = _mapper.Map<IEnumerable<ContactDto>>(_service.GetAll(p => p.City.Name == stateOrCity || p.City.State.Name == stateOrCity, p => p.City, p => p.City.State));
            return Ok(contacts);
        }
    }
}
