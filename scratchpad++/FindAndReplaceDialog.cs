using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scratchpad__
{
    public partial class FindAndReplaceDialog : Form
    {

        public 抓痕板 Form1
        {
            get;
            set;
        }

        public FindAndReplaceDialog()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private List<int> findAll(RichTextBox richBox, String findText)
        {
            List<int> list = new List<int>();
            int index = -1;
            while ((index = richBox.Text.IndexOf(findText, index + 1)) != -1){
                list.Add(index);
            }
            return list;
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            抓痕板 form1 = this.Form1;
            ScratchTab tab = form1.getCurrentTab();
            string findText = findTextBox.Text;
            RichTextBox richBox = tab.GetTextBox().GetTextBox();
            RichTextBoxFinds finds = new RichTextBoxFinds();
            if (this.regexCheckBox.Checked)
            {
                Regex reg = new Regex(findText);
                MatchCollection matches = reg.Matches(richBox.Text);
                tab.findIndexes.Clear();
                foreach (Match m in matches)
                {
                    tab.findIndexes.Add(m.Index);
                }
                if (matches.Count > 0)
                {
                    int index = tab.findIndexes[tab.findIndex];
                    richBox.HideSelection = false;
                    richBox.SelectionStart = index;
                    richBox.SelectionLength = matches[tab.findIndex].Length;
                }
                tab.findIndex++;
                if(tab.findIndex > tab.findIndexes.Count - 1)
                {
                    tab.findIndex = 0;
                }
            }
            else
            {
                tab.findIndexes.Clear();
                tab.findIndexes = findAll(richBox, findText);

                if (tab.findIndexes.Count > 0)
                {
                    int index = tab.findIndexes[tab.findIndex];
                    richBox.HideSelection = false;
                    richBox.SelectionStart = index;
                    richBox.SelectionLength = findText.Length;
                }
                tab.findIndex++;
                if (tab.findIndex > tab.findIndexes.Count - 1)
                {
                    tab.findIndex = 0;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void replace_button_clicked(object sender, EventArgs e)
        {
            RichTextBox tb = this.Form1.getCurrentTab().GetTextBox().GetTextBox();
            if (this.regexCheckBox.Checked)
            {
                Regex reg = new Regex(this.findTextBox.Text);
                tb.Text = reg.Replace(tb.Text, this.repalceTextBox.Text);
            }
            else
            {
                tb.Text = tb.Text.Replace(this.findTextBox.Text, this.repalceTextBox.Text);
            }
            
        }

        private void regexCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Form1.getCurrentTab().findIndex = 0;
        }
    }
}
