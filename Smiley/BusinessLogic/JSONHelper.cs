using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Smiley
{
    class JSONHelper
    {
        public JavaScriptSerializer translater = new JavaScriptSerializer();

        public List<Emoji.RootObject> GetJson()
        {
            string text = File.ReadAllText("smiley_content.json");
            List<Emoji.RootObject> emojiList = translater.Deserialize<List<Emoji.RootObject>>(text);

            return emojiList;
        }
    }
}
