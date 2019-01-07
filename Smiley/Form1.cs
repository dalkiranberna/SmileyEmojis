using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smiley
{
    public partial class Form1 : Form
    {
        List<Emoji.RootObject> emojiList = JSONHelper.GetJson();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Emoji.RootObject item in emojiList)
            {
                Label l = new Label();
                l.Text = item.category;
                pnl_Emojis.Controls.Add(l);
                foreach (Emoji.Item items in item.items)
                {
                    Button b = new Button();
                    CreateButton(b);
                    b.Text = items.name + "\r\n" + items.art;
                    pnl_Emojis.Controls.Add(b);
                }
            }
        }
        

        private void CreateButton(Button b)
        {
            b.Height = 70;
            b.Width = 110;
            b.BackColor = Color.Khaki;
        }
    }
}
