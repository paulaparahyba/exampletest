using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneService
    {
        Task<List<PersonPhone>> FindAllAsync();

        PersonPhone Edit(PersonPhone p);

        PersonPhone Create(PersonPhone p);

        PersonPhone FindById(int id);

        bool Delete(int Id);
    }
}
