using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClenArch.Domain.Validation
{
    public class DomainExceptionValidator : Exception
    {
        public DomainExceptionValidator(string error) : base(error)
        {

        }

        public static void When(bool hasError, string error)
        {
            if (hasError)
            {
                throw new DomainExceptionValidator(error);
            }
        }
    }
}
