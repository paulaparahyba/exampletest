using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Charge.Application.Messages.Request
{
    public class PersonPhoneRequest
    {
        public string Nome { get; set; }

        public Dtos.PersonPhoneDTO Dto { get; set; }
    }
}
