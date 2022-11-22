﻿using System.Collections.Generic;
using System;


namespace StoreWebApi2.DTOs
{
    public class CustomerDTO
    {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public List<CustomerOrderDTO> CustomerOrder { get; set; }
        
    }

}

