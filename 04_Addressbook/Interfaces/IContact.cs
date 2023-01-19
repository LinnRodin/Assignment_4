﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Addressbook.Interfaces;

internal interface IContact
{

    Guid Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; } 
    string Email { get; set; } 
    string PhoneNumber { get; set; } 
    string StreetName { get; set; } 
    string PostalCode { get; set; } 
    string City { get; set; } 
   
}
