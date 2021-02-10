using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetColorsByColorId(int id);
        void AddColor(Color color);
        void UpdateColor(Color color);
        void DeleteColor(Color color);
    }
}
