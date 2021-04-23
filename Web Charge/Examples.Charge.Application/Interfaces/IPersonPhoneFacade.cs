using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Messages.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonPhoneFacade
    {
        Task<PersonPhoneResponse> FindAllAsync();

        PersonPhoneResponse FindById(int Id);

        PersonPhoneResponse Edit(PersonPhoneDTO dto);

        PersonPhoneResponse Create(PersonPhoneDTO dto);

        PersonPhoneResponse Delete(int Id);
    }
}