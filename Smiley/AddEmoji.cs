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
    public partial class AddEmoji : Form
    {
        public AddEmoji()
        {
            InitializeComponent();
        }

        private void AddEmoji_Load(object sender, EventArgs e)
        {
            Program.Helper.AddEmojiToCombobox(cbox_Categories);
        }
    }
}
