using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllCore.DLServiceInterfaces
{
    public interface IDemo
    {
        // Declaring DL Methods - abstraction layer - hiding implementation details from user
        string GetDataFromDL();
    }
}
