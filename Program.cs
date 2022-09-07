using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ModelThatJSONCorrectVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\supsu\OneDrive\School Python\Project\Simulation Building\Animal Classes Py\startingPopulation.json";

            string jsonText = File.ReadAllText(fileName);

            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<PopulationModel>(jsonText);// already have the object layout set up and this will assign from json to the pre existing object
            //Console.WriteLine(data);
            //PopulationModel data = Newtonsoft.Json.JsonConvert.DeserializeObject<PopulationModel>(jsonText);// already have the object layout set up and this will assign from json to the pre existing object














            //Console.WriteLine(data.predList);
            //Console.WriteLine(data.predList[0]);
            //Console.WriteLine(data.predList[0].wolf);
            //Console.WriteLine(data.predList[0].wolf[0]);
            //Console.WriteLine(data.predList[0].wolf[0].Attack);
            //Console.WriteLine(data.predList[0].jaguar);


            //var badKeys = data.predList[0].Where(pair => pair.value.count == 0)
            //    .Select(pair => pair.Key)
            //    .ToList();


        }
    }

    
}
