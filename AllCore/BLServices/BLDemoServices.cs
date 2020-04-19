using AllCore.BLServiceIntefaces;
using AllCore.DLServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllCore.BLServices
{
    public class BLDemoServices : IBLDemos
    {
        private IDemo _demoDl;

        public BLDemoServices(IDemo demoDl) // DL Interface
        {
            _demoDl = demoDl; // creating object of DL interfece
        }

        // Implementing the interface method
        public string GetDataFromBL()
        {
            // Accessing DL methods from BL - using interface of DL
            string dlData = _demoDl.GetDataFromDL();
            if (!string.IsNullOrEmpty(dlData))
            {
                return dlData; // returning DL Data
            }
            return "This is from BL"; // returning BL Data
        }
    }
}
