using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingRecorderAssistant
{
    public class programConfig
    {
        #region Config vars

        //CONTROLS - Vars for restoring control values
        public bool recording_ctrl, recording_shift, recording_alt = false;
        public string recording_mainKey = "Numpad 1";

        public bool break_ctrl, break_shift, break_alt = false;
        public string break_mainkey = "Numpad 2";

        //Absolute Values
        public int keyBindSumRecording = 97;
        public int keyBindModifierSumRecording = 0;
        public int keyBindSumBreak = 98;
        public int keyBindModifierSumBreak = 0;

        #endregion 




        public static object DeserializeObject<T>(string toDeserialize)
        {
            //XmlSerializer xmlSerializer = new XmlSerializer(toDeserialize.GetType());
            //StringReader textReader = new StringReader(toDeserialize);
            return JsonConvert.DeserializeObject<programConfig>(toDeserialize);

            //return xmlSerializer.Deserialize(textReader);
        }

        public static string SerializeObject<T>(T toSerialize)
        {
            return JsonConvert.SerializeObject(toSerialize);
        }

    }
}
