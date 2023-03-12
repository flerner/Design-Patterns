using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public class PersonalCredit : Credit
    {
        public PersonalCredit(Client c) : base(c)
        {
        }

        protected override string VerifyActions()
        {
            return "Verifying actions for personal credit";
        }

        protected override string VerifyBalance()
        {
            return "Verifying balance for personal credit";
        }

        protected override string VerifyCredits()
        {
            return "Verifying credits for personal credit";
        }

        protected override string VerifyIncomings()
        {
            return "Verifying incomings for personal credit";
        }
    }
}
