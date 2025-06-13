namespace StringApp
{
    partial class MainForm
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShowHash = new System.Windows.Forms.Button();
            this.btnShowSorted = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 12);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 20);
            this.txtKey.TabIndex = 0;
            this.txtKey.Text = "Key";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(118, 12);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 1;
            this.txtValue.Text = "1010";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 120);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(360, 120);
            this.txtOutput.TabIndex = 2;
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(12, 90);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(100, 20);
            this.txtSearchKey.TabIndex = 3;
            this.txtSearchKey.Text = "Search Key";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(224, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShowHash
            // 
            this.btnShowHash.Location = new System.Drawing.Point(12, 38);
            this.btnShowHash.Name = "btnShowHash";
            this.btnShowHash.Size = new System.Drawing.Size(100, 23);
            this.btnShowHash.TabIndex = 5;
            this.btnShowHash.Text = "Show Hashtable";
            this.btnShowHash.UseVisualStyleBackColor = true;
            this.btnShowHash.Click += new System.EventHandler(this.btnShowHash_Click);
            // 
            // btnShowSorted
            // 
            this.btnShowSorted.Location = new System.Drawing.Point(118, 38);
            this.btnShowSorted.Name = "btnShowSorted";
            this.btnShowSorted.Size = new System.Drawing.Size(100, 23);
            this.btnShowSorted.TabIndex = 6;
            this.btnShowSorted.Text = "Show SortedList";
            this.btnShowSorted.UseVisualStyleBackColor = true;
            this.btnShowSorted.Click += new System.EventHandler(this.btnShowSorted_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(118, 88);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(224, 38);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(75, 23);
            this.btnStats.TabIndex = 8;
            this.btnStats.Text = "Statistics";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnShowSorted);
            this.Controls.Add(this.btnShowHash);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearchKey);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Name = "MainForm";
            this.Text = "BitString Collection Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowHash;
        private System.Windows.Forms.Button btnShowSorted;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnStats;
    }
}