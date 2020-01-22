using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// Adapter class that collaborate non-related and incompatible XmlConverter and JsonConverter. 
    /// This class makes these interfaces work together.
    /// This class behaves adapter between XmlConverter and JsonConverter
    /// </summary>
    public class XmlToJsonAdapter : IXmlToJson
    {
        private readonly XmlConverter _xmlConverter;

        public XmlToJsonAdapter(XmlConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }

        public void ConvertXmlToJson()
        {
            var manufacturers = _xmlConverter.GetXML()
                    .Element("Manufacturers")
                    .Elements("Manufacturer")
                    .Select(m => new Manufacturer
                    {
                        City = m.Attribute("City").Value,
                        Name = m.Attribute("Name").Value,
                        Year = Convert.ToInt32(m.Attribute("Year").Value)
                    });

            new JsonConverter(manufacturers)
                .ConvertToJson();
        }
    }
}
