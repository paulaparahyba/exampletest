using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonPhoneService : IPersonPhoneService
    {
        private readonly IPersonPhoneRepository _personPhoneRepository;
        public PersonPhoneService(IPersonPhoneRepository personPhoneRepository)
        {
            _personPhoneRepository = personPhoneRepository;
        }

        public async Task<List<PersonPhone>> FindAllAsync() => (await _personPhoneRepository.FindAllAsync()).ToList();

        public PersonPhone Edit(PersonPhone p)
        {
            return _personPhoneRepository.Edit(p);
        }

        public PersonPhone Create(PersonPhone p)
        {
            return _personPhoneRepository.Create(p);
        }

        public bool Delete(int Id)
        {
            return _personPhoneRepository.Delete(Id);
        }

        public PersonPhone FindById(int id)
        {
            return _personPhoneRepository.FindById(id);
        }
    }
}
