using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public abstract class Verifications
    {
        //this is the class where all steps are putted in a template method, so every method executes by polymorphism, and we can even add a concrete default method
        //in this class if it is the same for every child classes, like ThisIsAMethodThatEveryoneNeed(). And if in the future a new child class need that that method
        //work differently, it can override it.

        protected Client _client;
        
        public string[] Verify()
        {
            var msg = new List<string>();
            msg.Add($"Verifying credit for {_client.Name}");
            msg.Add(VerifyActions());
            msg.Add(VerifyBalance());
            msg.Add(VerifyCredits());
            msg.Add(VerifyIncomings());
            msg.Add(ThisIsAMethodThatEveryoneNeed());

            return msg.ToArray();
        }
        protected abstract string VerifyActions();
        protected abstract string VerifyBalance();
        protected abstract string VerifyCredits();
        protected abstract string VerifyIncomings();
        protected string ThisIsAMethodThatEveryoneNeed()
        {
            return "This is a method that everyone need";
        }
    }
}
