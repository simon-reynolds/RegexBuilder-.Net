using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Regex_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabReplace_Click(object sender, EventArgs e)
        {

        }

        private void OnKeyPress(object sender, EventArgs e)
        {
            string strRegex = string.Empty;
            string strTextToMatch = string.Empty;
            string senderName = (sender as TextBox).Name;

            // Take strRegex based on which textbox is 
            switch (senderName)
            {
                case "txtRegexInput_search":
                    strRegex = txtRegexInput_search.Text;
                    strTextToMatch = txtSearchForMatch_search.Text;
                    txtRegexInput_replace.Text = txtRegexInput_search.Text;
                    break;
                case "txtRegexInput_replace":
                    strRegex = txtRegexInput_replace.Text;
                    strTextToMatch = txtSearchForMatch_replace.Text;
                    txtRegexInput_search.Text = txtRegexInput_replace.Text;
                    break;
                case "txtSearchForMatch_search":
                    strTextToMatch = txtSearchForMatch_search.Text;
                    strRegex = txtRegexInput_search.Text;
                    txtSearchForMatch_replace.Text = txtSearchForMatch_search.Text;
                    break;
                case "txtSearchForMatch_replace":
                    strTextToMatch = txtSearchForMatch_replace.Text;
                    strRegex = txtRegexInput_replace.Text;
                    txtSearchForMatch_search.Text = txtSearchForMatch_replace.Text;
                    break;
                default:
                    strRegex = txtRegexInput_search.Text;
                    break;
            }
            performRegexComparison();
        }

        private void performRegexComparison()
        {
            treeResults.Nodes.Clear();
            lblRegexError.Text = string.Empty;
            RegexBuilder builder = new RegexBuilder();
            RegexOptions options = builder.setOptions(false, chkCultureInvariant.Checked, false, chkExplicitCapture.Checked,
            chkIgnoreCase.Checked, chkIgnorePatternWhitespace.Checked, chkMultiline.Checked, false, false, chkSingleline.Checked);

            try
            {
                if (!string.IsNullOrEmpty(txtRegexInput_search.Text))
                {
                    Regex rgx = builder.GetRegex(txtRegexInput_search.Text, options);
                    MatchCollection mch = rgx.Matches(txtSearchForMatch_search.Text);
                    if (mch.Count > 0)
                    {   
                        int count = 1;
                        foreach (Match match in mch)
                        {
                            TreeNode node = new TreeNode("Match " + count);
                            foreach (Group item in match.Groups)
                            {
                                TreeNode nodeMatch = new TreeNode(item.Value);

                                node.Nodes.Add(nodeMatch);
                            }
                            treeResults.Nodes.Add(node);
                            count++;
                        }
                    }
                    else
                    {
                        treeResults.Nodes.Add("No matches found");
                    }
                    txtTextReplacedByRegex.Text = rgx.Replace(txtSearchForMatch_search.Text, txtRegexReplaceWith.Text);   
                }
            }
            catch (ArgumentException ex)
            {
                lblRegexError.Text = ex.Message;
            }
        }

        private void RegexOptionChanged(object sender, EventArgs e)
        {
            performRegexComparison();
        }

    }
}
