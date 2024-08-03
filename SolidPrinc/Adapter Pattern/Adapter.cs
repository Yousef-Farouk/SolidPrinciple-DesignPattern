using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.Adapter_Pattern
{
    public class Adapter : ITarget
    {

        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {

            _adaptee = adaptee;

        }

        public string Request()
        {
            string jsonData = _adaptee.SpecificRequest();
            // Convert JSON to XML (for simplicity, using a simple replace here)
            string xmlData = jsonData.Replace("{\"data\": \"", "<data>").Replace("\"}", "</data>");
            return xmlData;
        }


    }
}
