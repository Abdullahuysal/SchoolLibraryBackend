using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //for basic voids
    public interface IResult
    {
        bool Success { get;}
        string Message { get;}

    }
}
