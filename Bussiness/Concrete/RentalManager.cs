using Bussiness.Abstract;
using Bussiness.Constands;
using DataAccess.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class RentalManager:IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult RentCar(Rental rental)
        {
            if (rental==null)
            {
                return new ErrorResult(Messages.RentalIsEmpty);
            }
            if (rental.CarId==0 || rental.CustomerId==0||rental.RentDate==null)
            {
                return new ErrorResult(Messages.RentalIsEmpty);
            }
            var car = _rentalDal.Get(x => x.CarId == rental.CarId && x.ReturnDate==null);
            if (car==null)
            {
                _rentalDal.Add(rental);
            }
            else
            {
                return new ErrorResult(Messages.RentalNotAdded);
            }
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult RentBackCar(Rental rental)
        {
            if (rental == null)
            {
                return new ErrorResult(Messages.RentalBackIsEmpty);
            }
            if (rental.CarId == 0 || rental.CustomerId == 0 ||rental.ReturnDate == null)
            {
                return new ErrorResult(Messages.RentalBackIsEmpty);
            }
            var car = _rentalDal.Get(x => x.CarId == rental.CarId && x.ReturnDate == null);
            if (car != null)
            {
                rental.Id = car.Id;
                rental.RentDate = car.RentDate;
                _rentalDal.Update(rental);
            }
            else
            {
                return new ErrorResult(Messages.RentalNotAdded);
            }
            return new SuccessResult(Messages.RentalBackAdded);
        }

    }
}
