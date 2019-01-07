using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smiley.BusinessLogic
{
    class EmojiRepo
    {
        public void GetEmoji(List<Emoji.RootObject> emojiList, FlowLayoutPanel panel)
        {
            foreach (Emoji.RootObject item in emojiList)
            {
                Label lbl = Program.Helper.CreateLabelProperty(item);
                panel.Controls.Add(lbl);

                foreach (Emoji.Item items in item.items)
                {
                    Button btn = Program.Helper.CreateButtonProperty(items);
                    panel.Controls.Add(btn);
                    btn.MouseUp += new MouseEventHandler(btn_Emoji_MouseClick);
                }
            }
        }

        public void btn_Emoji_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show(((Button)sender).Text);
                Clipboard.SetText(((Button)sender).Text);
            }
        }

        public void AddEmoji()
        {
            
            
        }
    }
}
