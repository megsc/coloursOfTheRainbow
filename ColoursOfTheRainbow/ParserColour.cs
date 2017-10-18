using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ColoursOfTheRainbow
{
    class ParserColour
    {
        public String serialise(Dictionary<string, string> colourData)
        {
            string jsonData = JsonConvert.SerializeObject(colourData);
            System.Diagnostics.Debug.WriteLine(jsonData);
            return jsonData;

        }

        public Dictionary<string, string> deserialise(string input)
        {
            Dictionary<string, string> readJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(input);
            return readJson;

        }

    }
}
