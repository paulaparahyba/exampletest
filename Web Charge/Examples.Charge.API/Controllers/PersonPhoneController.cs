using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonPhoneController : BaseController
    {
        private IPersonPhoneFacade _facade;

        public PersonPhoneController(IPersonPhoneFacade facade, IMapper mapper)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<ActionResult<PersonPhoneResponse>> Get() => Response(await _facade.FindAllAsync());

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Response(_facade.FindById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] PersonPhoneRequest request)
        {
            var result = _facade.Edit(request.Dto);
            return Response(0, result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] PersonPhoneRequest request)
        {
            var result = _facade.Create(request.Dto);
            return Response(0, result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Response(0, _facade.Delete(id));
        }
    }
}
