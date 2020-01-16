using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WelcomeWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WelcomeWCFService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WelcomeWCFService.svc or WelcomeWCFService.svc.cs at the Solution Explorer and start debugging.
    public class WelcomeWCFService : IWelcomeWCFService
    {
        public void DoWork()
        {
            throw new NotImplementedException();
        }

        public string Welcome(string name)
        {
            return "Welcome to my first WCF Application " + name;
        }
    }
}
