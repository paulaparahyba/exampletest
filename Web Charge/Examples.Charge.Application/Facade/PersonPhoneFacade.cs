using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class PersonPhoneFacade : IPersonPhoneFacade
    {
        private readonly IPersonPhoneService _personPhoneService;
        private readonly IMapper _mapper;

        public PersonPhoneFacade(IPersonPhoneService personPhoneService, IMapper mapper)
        {
            _personPhoneService = personPhoneService;
            _mapper = mapper;
        }

        public PersonPhoneResponse Delete(int Id)
        {
            var result = _personPhoneService.Delete(Id);
            var response = new PersonPhoneResponse();
            response.Success = result;
            response.PersonPhonesObject = new List<PersonPhoneDTO>();

            return response;
        }

        public PersonPhoneResponse Edit(PersonPhoneDTO dto)
        {
            var domainEntity = _mapper.Map<Domain.Aggregates.PersonAggregate.PersonPhone>(dto);
            var result = _personPhoneService.Edit(domainEntity);
            var response = new PersonPhoneResponse();
            response.PersonPhonesObject = new List<PersonPhoneDTO>();
            response.PersonPhonesObject.Add(_mapper.Map<PersonPhoneDTO>(result));
            return response;
        }

        public PersonPhoneResponse FindById(int id)
        {
            var result = _personPhoneService.FindById(id);
            var response = new PersonPhoneResponse();
            response.PersonPhonesObject = new List<PersonPhoneDTO>();
            response.PersonPhonesObject.Add(_mapper.Map<PersonPhoneDTO>(result));
            return response;
        }

        public async Task<PersonPhoneResponse> FindAllAsync()
        {
            var result = await _personPhoneService.FindAllAsync();
            var response = new PersonPhoneResponse();
            response.PersonPhonesObject = new List<PersonPhoneDTO>();
            response.PersonPhonesObject.AddRange(result.Select(x => _mapper.Map<PersonPhoneDTO>(x)));
            return response;
        }
    }
}
