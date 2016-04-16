using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPOS.Infrastructure.Domain
{
    public class ValueObjectIsInvalidException : Exception
    {
        /// <summary>
        /// Represent errors that occur if any value object is invalid
        /// </summary>
        public ValueObjectIsInvalidException(string message)
            : base(message) { }
    }
}
