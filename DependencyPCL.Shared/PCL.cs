using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyPCL
{
    public class PCL
    {
        public PCL()
        {

        }

        public string GetPlatform()
        {
#if __IOS__
            return "iOS";
#elif __ANDROID__
            return "Android";
#else
            throw new Exception("Not implementing GetPlatfom method");
#endif
        }
    }
}
