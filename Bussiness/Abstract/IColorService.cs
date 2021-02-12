﻿using DataAccess.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetColorsByColorId(int id);
        IResult AddColor(Color color);
        IResult UpdateColor(Color color);
        IResult DeleteColor(Color color);
    }
}
