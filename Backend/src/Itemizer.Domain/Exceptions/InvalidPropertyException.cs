using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itemizer.Domain.Exceptions;
public class InvalidPropertyException : Exception
{
    public InvalidPropertyException()
    {
    }

    public InvalidPropertyException(string? message) : base(message)
    {
    }

    public InvalidPropertyException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
