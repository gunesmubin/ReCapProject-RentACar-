﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
