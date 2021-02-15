using Bussiness.Abstract;
using Bussiness.Constands;
using DataAccess.Abstract;
using DataAccess.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace Bussiness.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult AddColor(Color color)
        {
            if (color!=null)
            {
                _colorDal.Add(color);
            }
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult DeleteColor(Color color)
        {
            if (color != null)
            {
                _colorDal.Delete(color);
            }
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll().ToList(),Messages.ColorListed);
        }



        public IResult UpdateColor(Color color)
        {
            if (color != null)
            {
                _colorDal.Update(color);
            }
            return new SuccessResult(Messages.ColorUpdated);
        }

        IDataResult<Color> IColorService.GetColorsByColorId(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(x => x.Id == id), Messages.ColorListed);
        }
    }
}
