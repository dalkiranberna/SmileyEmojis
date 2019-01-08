using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Smiley
{
    class JSONHelper
    {
        public JavaScriptSerializer converter = new JavaScriptSerializer();
        public List<Emoji.RootObject> emojiList { get; set; }

        public List<Emoji.RootObject> GetJson()
        {
            string text = File.ReadAllText("smiley_content.json");
            emojiList = converter.Deserialize<List<Emoji.RootObject>>(text);

            return emojiList;
        }

        public void SaveToJson(string cbox, TextBox tb1, TextBox tb2)
        {
            List<Emoji.RootObject> list = Program.JsonHelper.GetJson();
            foreach (Emoji.RootObject item in list)
            {

            }
            Categories.category = cbox.Items.ToString();
            Items.name = tb1.Text;
            Items.art = tb2.Text;
            Categories.items.Add(Items);

            emojiList.Add(Categories);
            converter.Serialize(emojiList);
        }
    }
}
