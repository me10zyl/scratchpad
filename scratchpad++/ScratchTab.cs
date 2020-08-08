using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scratchpad__
{
    public class ScratchTab
    {
        private TabPage tab;
        private ScratchTextBox textBox;
        public List<int> findIndexes = new List<int>();
        public int findIndex
        {
            get;
            set;
        }
        public String lastFindText;

        public ScratchTab(String name, String text, Size size)
        {
            RichTextBox richTextBox1 = new RichTextBox();
            richTextBox1.Location = new System.Drawing.Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            Size newSize = new Size(size.Width, size.Height + 5);
            richTextBox1.Size = newSize;
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            this.textBox = new ScratchTextBox(richTextBox1);
            this.tab = new TabPage();
            this.tab.Controls.Add(richTextBox1);
            this.tab.Location = new System.Drawing.Point(4, 22);
            this.tab.Name = name;
            this.tab.Padding = new System.Windows.Forms.Padding(3);
            this.tab.Size = size;
            this.tab.TabIndex = 0;
            this.tab.Text = text;
            this.tab.UseVisualStyleBackColor = true;
        }

        public TabPage GetTab()
        {
            return tab;
        }

        public ScratchTab(TabPage tab, ScratchTextBox textBox)
        {
            this.tab = tab;
            this.textBox = textBox;
        }

        public ScratchTextBox GetTextBox()
        {
            return textBox;
        }
    }
}
