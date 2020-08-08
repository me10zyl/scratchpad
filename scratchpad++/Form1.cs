using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scratchpad__
{
    public partial class 抓痕板 : Form
    {

        private Size preSize;
        public 抓痕板()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            ScratchTab tab1 = new ScratchTab(scratchpad1, new ScratchTextBox(richTextBox1));
            tabList.Add(tab1);
            string tabCount = FileUtil.ReadSetting("tabCount");
            if (!string.IsNullOrEmpty(tabCount))
            {
                for(int i = 0; i < int.Parse(tabCount) - 1; i++)
                {
                    toolStripButton1_Click(null, null);
                }
            }
            
            for (int i = 0; i < tabList.Count; i++)
            {
                ScratchTab tab = tabList[i];
                tab.GetTextBox().GetTextBox().Text = FileUtil.ReadTmp("scatchTab" + (i + 1) + ".txt");
            }
            preSize = this.Size;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
                    }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileUtil.AddUpdateAppSettings("tabCount", this.tabList.Count + "");
            for(int i = 0;i < tabList.Count; i++) {
                ScratchTab tab = tabList[i];
                string text = tab.GetTextBox().GetTextBox().Text;
                FileUtil.SaveTmp(text, "scatchTab" + (i+1) + ".txt");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ScratchTab tab = new ScratchTab("scratchpad" + (this.tabList.Count + 1), "scratchpad" + (this.tabList.Count + 1), this.tabList[0].GetTab().Size);
            tab.GetTextBox().GetTextBox().ContextMenuStrip = this.contextMenuStrip2;
            this.tabList.Add(tab);
            this.tabControl1.Controls.Add(tab.GetTab());
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int heightOffset = this.Size.Height - this.preSize.Height;
            int widthOffset = this.Size.Width - this.preSize.Width;
            tabControl1.Size = new Size(tabControl1.Width + widthOffset, tabControl1.Height + heightOffset);
            foreach(ScratchTab tab in this.tabList){
                tab.GetTab().Size = new Size(tab.GetTab().Width + widthOffset, tab.GetTab().Height + heightOffset);
                tab.GetTextBox().GetTextBox().Size = new Size(tab.GetTextBox().GetTextBox().Width + widthOffset,
                    tab.GetTextBox().GetTextBox().Height + heightOffset);
            }
            Console.WriteLine("sizeChanged");
            this.preSize = this.Size;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(sender + ":" + e.KeyChar);
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

    
        private void tabControl1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Modifiers.HasFlag(Keys.Control) && e.KeyCode == Keys.W)
            {
                int index = this.tabControl1.SelectedIndex;
                this.tabControl1.SelectedTab.Dispose();
                this.tabList.RemoveAt(index);
            }
            if(e.Modifiers.HasFlag(Keys.Control) && (e.KeyCode == Keys.F || e.KeyCode == Keys.H))
            {
                FindAndReplaceDialog fard = new FindAndReplaceDialog();
                fard.Form1 = this;
                fard.Owner = this;
                fard.StartPosition = FormStartPosition.Manual;
                fard.Location = new Point((this.Location.X * 2 + this.Size.Width) / 2 - fard.Size.Width / 2, (this.Location.Y * 2 + this.Size.Height) / 2 - fard.Size.Height / 2);
                fard.Show();
            }
        }

        private void 拷贝文件路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            string text = FileUtil.BASE_DIR + "\\scatchTab" + (index + 1) + ".txt";
            Clipboard.SetDataObject(text);
        }
    }
}
