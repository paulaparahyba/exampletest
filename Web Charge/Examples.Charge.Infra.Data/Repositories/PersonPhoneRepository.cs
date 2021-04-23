using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonPhoneRepository : IPersonPhoneRepository
    {
        private readonly ExampleContext _context;

        public PersonPhoneRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public bool Delete(int Id)
        {
            PersonPhone entity = _context.PersonPhone.Where(x => x.BusinessEntityID == Id).FirstOrDefault();
            if (entity != null)
            {
                _context.PersonPhone.Remove(entity);
                return _context.SaveChanges() > 0;
            }
            else throw new Exception("Telefone não localizado.");
        }

        public PersonPhone Edit(PersonPhone p)
        {
            PersonPhone entity = _context.PersonPhone.Where(x => x.BusinessEntityID == p.BusinessEntityID).FirstOrDefault();
            if (entity != null)
            {
                entity.PhoneNumber = p.PhoneNumber;
                entity.PhoneNumberTypeID = p.PhoneNumberTypeID;
                _context.SaveChanges();

                return p;
            }
            else throw new Exception("Telefone não localizado.");
        }

        public PersonPhone FindById(int id)
        {
            return _context.PersonPhone.Where(x => x.BusinessEntityID == id).FirstOrDefault();
        }

        public async Task<IEnumerable<PersonPhone>> FindAllAsync() => await Task.Run(() => _context.PersonPhone);
    }
}
