
namespace Password_Generator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SecurityLevelBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordCount = new System.Windows.Forms.TextBox();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.IterationBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordList = new System.Windows.Forms.RichTextBox();
            this.ToolTipSecurityLevel = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipPasswordLength = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipPasswordCount = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipTrackbar = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipGenerate = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipPasswordList = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IterationBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SecurityLevelBox
            // 
            this.SecurityLevelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecurityLevelBox.FormattingEnabled = true;
            this.SecurityLevelBox.Items.AddRange(new object[] {
            "Low Security",
            "Medium Security",
            "High Security"});
            this.SecurityLevelBox.Location = new System.Drawing.Point(12, 29);
            this.SecurityLevelBox.Name = "SecurityLevelBox";
            this.SecurityLevelBox.Size = new System.Drawing.Size(121, 21);
            this.SecurityLevelBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Security Level (Low if not set)";
            // 
            // PasswordLength
            // 
            this.PasswordLength.Location = new System.Drawing.Point(12, 77);
            this.PasswordLength.Name = "PasswordLength";
            this.PasswordLength.Size = new System.Drawing.Size(100, 20);
            this.PasswordLength.TabIndex = 2;
            this.PasswordLength.Text = "16";
            this.PasswordLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordLenParse);
            this.PasswordLength.Leave += new System.EventHandler(this.PasswordLenParse);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password Length (min. 2, max 1024)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of passwords to generate\r\n(min. 1, max 128)";
            // 
            // PasswordCount
            // 
            this.PasswordCount.Location = new System.Drawing.Point(12, 141);
            this.PasswordCount.Name = "PasswordCount";
            this.PasswordCount.Size = new System.Drawing.Size(100, 20);
            this.PasswordCount.TabIndex = 5;
            this.PasswordCount.Text = "1";
            this.PasswordCount.DragLeave += new System.EventHandler(this.PasswordCountParse);
            this.PasswordCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordCountParse);
            this.PasswordCount.Leave += new System.EventHandler(this.PasswordCountParse);
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Location = new System.Drawing.Point(12, 256);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(178, 29);
            this.ButtonGenerate.TabIndex = 7;
            this.ButtonGenerate.Text = "Generate!";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.GeneratePasswords);
            // 
            // IterationBar
            // 
            this.IterationBar.Location = new System.Drawing.Point(8, 209);
            this.IterationBar.Minimum = 1;
            this.IterationBar.Name = "IterationBar";
            this.IterationBar.Size = new System.Drawing.Size(182, 45);
            this.IterationBar.TabIndex = 8;
            this.IterationBar.Value = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Iterations (higher = more secure)\r\n1     2   3    4   5    6   7    8   9    10";
            // 
            // PasswordList
            // 
            this.PasswordList.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordList.Location = new System.Drawing.Point(196, 12);
            this.PasswordList.Name = "PasswordList";
            this.PasswordList.ReadOnly = true;
            this.PasswordList.Size = new System.Drawing.Size(280, 273);
            this.PasswordList.TabIndex = 10;
            this.PasswordList.Text = "You haven\'t generated passwords yet\nPress the Generate button to get a list!";
            this.PasswordList.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 302);
            this.Controls.Add(this.PasswordList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IterationBar);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecurityLevelBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Secure Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.IterationBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SecurityLevelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordCount;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.TrackBar IterationBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox PasswordList;
        private System.Windows.Forms.ToolTip ToolTipSecurityLevel;
        private System.Windows.Forms.ToolTip ToolTipPasswordLength;
        private System.Windows.Forms.ToolTip ToolTipPasswordCount;
        private System.Windows.Forms.ToolTip ToolTipTrackbar;
        private System.Windows.Forms.ToolTip ToolTipGenerate;
        private System.Windows.Forms.ToolTip ToolTipPasswordList;
    }
}

