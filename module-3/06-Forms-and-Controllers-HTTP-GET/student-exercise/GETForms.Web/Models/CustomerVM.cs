using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class CustomerVM
    {
        public string Request { get; set; }
        public IList<Customer> customers { get; set; }
    }
}
