using DataAccess.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface ICustomerService
    {
        IResult AddCustomer(Customer customer);
        IResult DeleteCustomer(Customer customer);
        IResult UpdateCustomer(Customer customer);
        IDataResult<List<Customer>> GetAllCustomer();
    }
}
