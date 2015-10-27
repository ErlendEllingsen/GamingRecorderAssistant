using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GamingRecorderAssistant
{
    public class config
    {

        #region Config vars

        //DEADLINE
        public bool deadline = false;
        public int deadlineTimer = 0;

        //PRECUT
        public bool precutFromStart = true; //fromStart tells if data is cut form start or end of project.
        public int precutTimer = 0;

        public int totalTimer = 0;
        //Breaking vars
        public int breakingTimeAccumulated = 0;
        public List<timeTrackingBreak> previousBreaks = new List<timeTrackingBreak>();
        public int breakIndex = 0;

        //Mark vars
        //Mark: point of interest
        public int poiIndex = 0;

        public List<timeTrackingMark> marks = new List<timeTrackingMark>();


        #endregion 




        public static object DeserializeObject<T>(string toDeserialize)
        {
            //XmlSerializer xmlSerializer = new XmlSerializer(toDeserialize.GetType());
            //StringReader textReader = new StringReader(toDeserialize);
            return JsonConvert.DeserializeObject<config>(toDeserialize);

            //return xmlSerializer.Deserialize(textReader);
        }

        public static string SerializeObject<T>(T toSerialize)
        {
            //XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());
            //StringWriter textWriter = new StringWriter();
            //xmlSerializer.Serialize(textWriter, toSerialize);
            //return textWriter.ToString();
            return JsonConvert.SerializeObject(toSerialize);
        }

    }
}
