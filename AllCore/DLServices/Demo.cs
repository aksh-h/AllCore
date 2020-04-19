using AllCore.DLServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllCore.DLServices
{
    public class Demo : IDemo
    {
        // Implementing DL Methods
        public string GetDataFromDL()
        {
            return "Hey You";
        }
    }
}
