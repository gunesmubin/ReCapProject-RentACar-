using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Results
{
    public class DataResult<T>:Result,IDataResult<T>
    {
        public DataResult(T data,bool success,string message):base(success,message)
        {
            Data = data;
        }

        public DataResult(T data,bool success):base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
