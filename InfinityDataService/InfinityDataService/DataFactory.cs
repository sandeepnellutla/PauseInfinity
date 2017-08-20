using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfinityDataService
{
    public class DataFactory:NancyModule
    {
        public DataFactory()
        {
            Get["/"] = parameters => "Hello World";
        }
    }
}