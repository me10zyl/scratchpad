using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scratchpad__
{
    public class ScratchTextBox 
    {
        private RichTextBox textBox;

        public ScratchTextBox(RichTextBox textBox)
        {
            this.textBox = textBox;
        }


        public RichTextBox GetTextBox()
        {
            return textBox;
        }
    }
}
