namespace Regex_Builder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.lblRegexError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchForMatch_search = new System.Windows.Forms.TextBox();
            this.txtRegexInput_search = new System.Windows.Forms.TextBox();
            this.tabReplace = new System.Windows.Forms.TabPage();
            this.txtTextReplacedByRegex = new System.Windows.Forms.TextBox();
            this.txtSearchForMatch_replace = new System.Windows.Forms.TextBox();
            this.txtRegexReplaceWith = new System.Windows.Forms.TextBox();
            this.txtRegexInput_replace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
            this.chkMultiline = new System.Windows.Forms.CheckBox();
            this.chkSingleline = new System.Windows.Forms.CheckBox();
            this.chkCultureInvariant = new System.Windows.Forms.CheckBox();
            this.chkExplicitCapture = new System.Windows.Forms.CheckBox();
            this.chkIgnorePatternWhitespace = new System.Windows.Forms.CheckBox();
            this.treeResults = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.tabReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Controls.Add(this.tabReplace);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 292);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.lblRegexError);
            this.tabSearch.Controls.Add(this.label2);
            this.tabSearch.Controls.Add(this.label1);
            this.tabSearch.Controls.Add(this.txtSearchForMatch_search);
            this.tabSearch.Controls.Add(this.txtRegexInput_search);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(619, 266);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // lblRegexError
            // 
            this.lblRegexError.AutoSize = true;
            this.lblRegexError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegexError.ForeColor = System.Drawing.Color.Red;
            this.lblRegexError.Location = new System.Drawing.Point(7, 20);
            this.lblRegexError.Name = "lblRegexError";
            this.lblRegexError.Size = new System.Drawing.Size(0, 15);
            this.lblRegexError.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text To Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Regex";
            // 
            // txtSearchForMatch_search
            // 
            this.txtSearchForMatch_search.Location = new System.Drawing.Point(6, 83);
            this.txtSearchForMatch_search.Multiline = true;
            this.txtSearchForMatch_search.Name = "txtSearchForMatch_search";
            this.txtSearchForMatch_search.Size = new System.Drawing.Size(606, 177);
            this.txtSearchForMatch_search.TabIndex = 1;
            this.txtSearchForMatch_search.TextChanged += new System.EventHandler(this.OnKeyPress);
            // 
            // txtRegexInput_search
            // 
            this.txtRegexInput_search.Location = new System.Drawing.Point(6, 44);
            this.txtRegexInput_search.Name = "txtRegexInput_search";
            this.txtRegexInput_search.Size = new System.Drawing.Size(606, 20);
            this.txtRegexInput_search.TabIndex = 0;
            this.txtRegexInput_search.TextChanged += new System.EventHandler(this.OnKeyPress);
            // 
            // tabReplace
            // 
            this.tabReplace.Controls.Add(this.txtTextReplacedByRegex);
            this.tabReplace.Controls.Add(this.txtSearchForMatch_replace);
            this.tabReplace.Controls.Add(this.txtRegexReplaceWith);
            this.tabReplace.Controls.Add(this.txtRegexInput_replace);
            this.tabReplace.Location = new System.Drawing.Point(4, 22);
            this.tabReplace.Name = "tabReplace";
            this.tabReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tabReplace.Size = new System.Drawing.Size(619, 266);
            this.tabReplace.TabIndex = 1;
            this.tabReplace.Text = "Replace";
            this.tabReplace.UseVisualStyleBackColor = true;
            this.tabReplace.Click += new System.EventHandler(this.tabReplace_Click);
            // 
            // txtTextReplacedByRegex
            // 
            this.txtTextReplacedByRegex.BackColor = System.Drawing.SystemColors.Window;
            this.txtTextReplacedByRegex.Location = new System.Drawing.Point(7, 160);
            this.txtTextReplacedByRegex.Multiline = true;
            this.txtTextReplacedByRegex.Name = "txtTextReplacedByRegex";
            this.txtTextReplacedByRegex.ReadOnly = true;
            this.txtTextReplacedByRegex.Size = new System.Drawing.Size(606, 100);
            this.txtTextReplacedByRegex.TabIndex = 3;
            // 
            // txtSearchForMatch_replace
            // 
            this.txtSearchForMatch_replace.Location = new System.Drawing.Point(6, 51);
            this.txtSearchForMatch_replace.Multiline = true;
            this.txtSearchForMatch_replace.Name = "txtSearchForMatch_replace";
            this.txtSearchForMatch_replace.Size = new System.Drawing.Size(606, 103);
            this.txtSearchForMatch_replace.TabIndex = 2;
            this.txtSearchForMatch_replace.TextChanged += new System.EventHandler(this.OnKeyPress);
            // 
            // txtRegexReplaceWith
            // 
            this.txtRegexReplaceWith.Location = new System.Drawing.Point(312, 25);
            this.txtRegexReplaceWith.Name = "txtRegexReplaceWith";
            this.txtRegexReplaceWith.Size = new System.Drawing.Size(300, 20);
            this.txtRegexReplaceWith.TabIndex = 1;
            this.txtRegexReplaceWith.TextChanged += new System.EventHandler(this.OnKeyPress);
            // 
            // txtRegexInput_replace
            // 
            this.txtRegexInput_replace.Location = new System.Drawing.Point(6, 25);
            this.txtRegexInput_replace.Name = "txtRegexInput_replace";
            this.txtRegexInput_replace.Size = new System.Drawing.Size(300, 20);
            this.txtRegexInput_replace.TabIndex = 0;
            this.txtRegexInput_replace.TextChanged += new System.EventHandler(this.OnKeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Regex Options";
            // 
            // chkIgnoreCase
            // 
            this.chkIgnoreCase.AutoSize = true;
            this.chkIgnoreCase.Location = new System.Drawing.Point(390, 324);
            this.chkIgnoreCase.Name = "chkIgnoreCase";
            this.chkIgnoreCase.Size = new System.Drawing.Size(83, 17);
            this.chkIgnoreCase.TabIndex = 3;
            this.chkIgnoreCase.Text = "Ignore Case";
            this.chkIgnoreCase.UseVisualStyleBackColor = true;
            this.chkIgnoreCase.CheckedChanged += new System.EventHandler(this.RegexOptionChanged);
            // 
            // chkMultiline
            // 
            this.chkMultiline.AutoSize = true;
            this.chkMultiline.Location = new System.Drawing.Point(479, 324);
            this.chkMultiline.Name = "chkMultiline";
            this.chkMultiline.Size = new System.Drawing.Size(71, 17);
            this.chkMultiline.TabIndex = 4;
            this.chkMultiline.Text = "Multi Line";
            this.chkMultiline.UseVisualStyleBackColor = true;
            this.chkMultiline.CheckedChanged += new System.EventHandler(this.RegexOptionChanged);
            // 
            // chkSingleline
            // 
            this.chkSingleline.AutoSize = true;
            this.chkSingleline.Location = new System.Drawing.Point(556, 324);
            this.chkSingleline.Name = "chkSingleline";
            this.chkSingleline.Size = new System.Drawing.Size(78, 17);
            this.chkSingleline.TabIndex = 5;
            this.chkSingleline.Text = "Single Line";
            this.chkSingleline.UseVisualStyleBackColor = true;
            this.chkSingleline.CheckedChanged += new System.EventHandler(this.RegexOptionChanged);
            // 
            // chkCultureInvariant
            // 
            this.chkCultureInvariant.AutoSize = true;
            this.chkCultureInvariant.Location = new System.Drawing.Point(12, 324);
            this.chkCultureInvariant.Name = "chkCultureInvariant";
            this.chkCultureInvariant.Size = new System.Drawing.Size(103, 17);
            this.chkCultureInvariant.TabIndex = 6;
            this.chkCultureInvariant.Text = "Culture Invariant";
            this.chkCultureInvariant.UseVisualStyleBackColor = true;
            this.chkCultureInvariant.CheckedChanged += new System.EventHandler(this.RegexOptionChanged);
            // 
            // chkExplicitCapture
            // 
            this.chkExplicitCapture.AutoSize = true;
            this.chkExplicitCapture.Location = new System.Drawing.Point(121, 324);
            this.chkExplicitCapture.Name = "chkExplicitCapture";
            this.chkExplicitCapture.Size = new System.Drawing.Size(99, 17);
            this.chkExplicitCapture.TabIndex = 7;
            this.chkExplicitCapture.Text = "Explicit Capture";
            this.chkExplicitCapture.UseVisualStyleBackColor = true;
            this.chkExplicitCapture.CheckedChanged += new System.EventHandler(this.RegexOptionChanged);
            // 
            // chkIgnorePatternWhitespace
            // 
            this.chkIgnorePatternWhitespace.AutoSize = true;
            this.chkIgnorePatternWhitespace.Location = new System.Drawing.Point(226, 324);
            this.chkIgnorePatternWhitespace.Name = "chkIgnorePatternWhitespace";
            this.chkIgnorePatternWhitespace.Size = new System.Drawing.Size(153, 17);
            this.chkIgnorePatternWhitespace.TabIndex = 8;
            this.chkIgnorePatternWhitespace.Text = "Ignore Pattern Whitespace";
            this.chkIgnorePatternWhitespace.UseVisualStyleBackColor = true;
            this.chkIgnorePatternWhitespace.CheckedChanged += new System.EventHandler(this.RegexOptionChanged);
            // 
            // treeResults
            // 
            this.treeResults.Location = new System.Drawing.Point(12, 348);
            this.treeResults.Name = "treeResults";
            this.treeResults.Size = new System.Drawing.Size(627, 99);
            this.treeResults.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 459);
            this.Controls.Add(this.treeResults);
            this.Controls.Add(this.chkIgnorePatternWhitespace);
            this.Controls.Add(this.chkExplicitCapture);
            this.Controls.Add(this.chkCultureInvariant);
            this.Controls.Add(this.chkSingleline);
            this.Controls.Add(this.chkMultiline);
            this.Controls.Add(this.chkIgnoreCase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "RegexBulider - .Net";
            this.tabControl1.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.tabReplace.ResumeLayout(false);
            this.tabReplace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TextBox txtSearchForMatch_search;
        private System.Windows.Forms.TextBox txtRegexInput_search;
        private System.Windows.Forms.TabPage tabReplace;
        private System.Windows.Forms.TextBox txtRegexReplaceWith;
        private System.Windows.Forms.TextBox txtRegexInput_replace;
        private System.Windows.Forms.TextBox txtTextReplacedByRegex;
        private System.Windows.Forms.TextBox txtSearchForMatch_replace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkIgnoreCase;
        private System.Windows.Forms.CheckBox chkMultiline;
        private System.Windows.Forms.CheckBox chkSingleline;
        private System.Windows.Forms.CheckBox chkCultureInvariant;
        private System.Windows.Forms.CheckBox chkExplicitCapture;
        private System.Windows.Forms.CheckBox chkIgnorePatternWhitespace;
        private System.Windows.Forms.Label lblRegexError;
        private System.Windows.Forms.TreeView treeResults;
    }
}

