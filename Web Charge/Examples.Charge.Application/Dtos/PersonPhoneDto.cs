﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Charge.Application.Dtos
{
    public class PersonPhoneDTO
    {
        public int Id { get; set; }

        public string PhoneNumber { get; set; }

        public int PhoneNumberTypeId { get; set; }
    }
}
