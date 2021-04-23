using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneRepository
    {
        Task<IEnumerable<PersonPhone>> FindAllAsync();

        PersonPhone Edit(PersonPhone p);

        PersonPhone FindById(int id);

        bool Delete(int Id);
    }
}
