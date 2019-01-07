using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smiley.BusinessLogic
{
    class Helper
    {
        public Button CreateButtonProperty(Emoji.Item item)
        {
            Button btn = new Button();
            btn.Height = 70;
            btn.Width = 135;
            btn.BackColor = Color.Khaki;
            btn.Text = item.name + "\r\n" + item.art;

            return btn;
        }

        public Label CreateLabelProperty(Emoji.RootObject rootObject)
        {
            Label lbl = new Label();
            lbl.Text = rootObject.category;
            lbl.Height = 30;
            lbl.Width = 300;

            return lbl;
        }
    }
}
