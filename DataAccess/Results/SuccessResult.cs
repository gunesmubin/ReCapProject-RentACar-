using DataAccess.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message):base(true,message)
        {

        }
        public SuccessResult():base(true)
        {

        }
    }
}
