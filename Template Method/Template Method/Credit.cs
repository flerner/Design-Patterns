using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public abstract class Credit : Verifications
    {
        public Credit(Client c)
        {
            _client= c;
        }
        protected abstract override string VerifyActions();
        protected abstract override string VerifyBalance();
        protected abstract override string VerifyCredits();
        protected abstract override string VerifyIncomings();
    }
}
