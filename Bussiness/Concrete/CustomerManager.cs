using Bussiness.Abstract;
using Bussiness.Constands;
using DataAccess.Abstract;
using DataAccess.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult AddCustomer(Customer customer)
        {
            if (customer == null)
            {
                return new ErrorResult(Messages.CustomerIsEmpty);
            }
            else
            {
                _customerDal.Add(customer);
            }
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult DeleteCustomer(Customer customer)
        {
            if (customer == null)
            {
                return new ErrorResult(Messages.CustomerIsEmpty);
            }
            else
            {
                _customerDal.Delete(customer);
            }
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAllCustomer()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll().ToList(), "Müşteriler Listelendi");
        }

        public IDataResult<Customer> GetCustomerById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(x => x.Id == id));
        }

        public IResult UpdateCustomer(Customer customer)
        {
            if (customer == null)
            {
                return new ErrorResult(Messages.CustomerIsEmpty);
            }
            else
            {
                _customerDal.Update(customer);
            }
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
