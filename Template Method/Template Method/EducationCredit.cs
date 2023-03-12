using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public class EducationCredit : Credit
    {
        public EducationCredit(Client c) : base(c)
        {
        }

        protected override string VerifyActions()
        {
            return "It is not required to verify actions for a education credit";
        }

        protected override string VerifyBalance()
        {
            return "Verifying balance for education credit";
        }

        protected override string VerifyCredits()
        {
            return "Verifying credits for education credit";
        }

        protected override string VerifyIncomings()
        {
            return "Verifying incomings for education credit";
        }
    }
}
