using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSetKeyAction : ICustomerSetKeyAction
    {
        public string Action { get; set;}
        
        public string Key { get; set;}
        public CustomerSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
