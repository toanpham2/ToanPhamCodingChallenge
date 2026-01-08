namespace CodingChallengeWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlMain = new TabControl();
            tabPage1 = new TabPage();
            fbOutputTextBox = new TextBox();
            fbClearButton = new Button();
            fbGenerateButton = new Button();
            fbPhraseBothTextBox = new TextBox();
            label6 = new Label();
            fbPhraseXTextBox = new TextBox();
            label5 = new Label();
            fbPhraseYTextBox = new TextBox();
            label4 = new Label();
            fbYTextBox = new TextBox();
            label3 = new Label();
            fbXTextBox = new TextBox();
            label2 = new Label();
            fbNTextBox = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            fiOutputTextBox = new TextBox();
            fiClearButton = new Button();
            fiGenerateButton = new Button();
            fiBTextBox = new TextBox();
            label9 = new Label();
            fiATextBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            fiNTextBox = new TextBox();
            tabPage3 = new TabPage();
            cxClearButton = new Button();
            cxGenerateButton = new Button();
            cxPhraseBothTextBox = new TextBox();
            label10 = new Label();
            cxPhraseXTextBox = new TextBox();
            label11 = new Label();
            cxPhraseYTextBox = new TextBox();
            label12 = new Label();
            cxYTextBox = new TextBox();
            label13 = new Label();
            cxXTextBox = new TextBox();
            label14 = new Label();
            cxBTextBox = new TextBox();
            label15 = new Label();
            cxATextBox = new TextBox();
            label16 = new Label();
            label17 = new Label();
            cxNTextBox = new TextBox();
            cxOutputTextBox = new TextBox();
            tabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPage1);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Controls.Add(tabPage3);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1165, 450);
            tabControlMain.TabIndex = 0;
            tabControlMain.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(fbOutputTextBox);
            tabPage1.Controls.Add(fbClearButton);
            tabPage1.Controls.Add(fbGenerateButton);
            tabPage1.Controls.Add(fbPhraseBothTextBox);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(fbPhraseXTextBox);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(fbPhraseYTextBox);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(fbYTextBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(fbXTextBox);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(fbNTextBox);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1157, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "FizzBuzz";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // fbOutputTextBox
            // 
            fbOutputTextBox.Font = new Font("Segoe UI", 10F);
            fbOutputTextBox.Location = new Point(8, 235);
            fbOutputTextBox.Multiline = true;
            fbOutputTextBox.Name = "fbOutputTextBox";
            fbOutputTextBox.ReadOnly = true;
            fbOutputTextBox.ScrollBars = ScrollBars.Vertical;
            fbOutputTextBox.Size = new Size(773, 169);
            fbOutputTextBox.TabIndex = 30;
            // 
            // fbClearButton
            // 
            fbClearButton.Location = new Point(214, 163);
            fbClearButton.Name = "fbClearButton";
            fbClearButton.Size = new Size(75, 23);
            fbClearButton.TabIndex = 29;
            fbClearButton.Text = "Clear";
            fbClearButton.UseVisualStyleBackColor = true;
            fbClearButton.Click += fbClearButton_Click;
            // 
            // fbGenerateButton
            // 
            fbGenerateButton.Location = new Point(8, 163);
            fbGenerateButton.Name = "fbGenerateButton";
            fbGenerateButton.Size = new Size(75, 23);
            fbGenerateButton.TabIndex = 28;
            fbGenerateButton.Text = "Generate";
            fbGenerateButton.UseVisualStyleBackColor = true;
            fbGenerateButton.Click += fbGenerateButton_Click;
            // 
            // fbPhraseBothTextBox
            // 
            fbPhraseBothTextBox.Location = new Point(533, 109);
            fbPhraseBothTextBox.Name = "fbPhraseBothTextBox";
            fbPhraseBothTextBox.Size = new Size(100, 23);
            fbPhraseBothTextBox.TabIndex = 27;
            fbPhraseBothTextBox.Text = "FizzBuzz";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(533, 91);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 26;
            label6.Text = "Phrase for both";
            // 
            // fbPhraseXTextBox
            // 
            fbPhraseXTextBox.Location = new Point(189, 109);
            fbPhraseXTextBox.Name = "fbPhraseXTextBox";
            fbPhraseXTextBox.Size = new Size(100, 23);
            fbPhraseXTextBox.TabIndex = 25;
            fbPhraseXTextBox.Text = "Fizz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 91);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 24;
            label5.Text = "Phrase for x";
            // 
            // fbPhraseYTextBox
            // 
            fbPhraseYTextBox.Location = new Point(376, 109);
            fbPhraseYTextBox.Name = "fbPhraseYTextBox";
            fbPhraseYTextBox.Size = new Size(100, 23);
            fbPhraseYTextBox.TabIndex = 23;
            fbPhraseYTextBox.Text = "Buzz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(376, 91);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 22;
            label4.Text = "Phrase for y";
            // 
            // fbYTextBox
            // 
            fbYTextBox.Location = new Point(376, 20);
            fbYTextBox.Name = "fbYTextBox";
            fbYTextBox.Size = new Size(100, 23);
            fbYTextBox.TabIndex = 21;
            fbYTextBox.Text = "5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 3);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 20;
            label3.Text = "y divisor (default 5)";
            // 
            // fbXTextBox
            // 
            fbXTextBox.Location = new Point(189, 20);
            fbXTextBox.Name = "fbXTextBox";
            fbXTextBox.Size = new Size(100, 23);
            fbXTextBox.TabIndex = 19;
            fbXTextBox.Text = "3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 2);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 18;
            label2.Text = "x divisor (default 3)";
            // 
            // fbNTextBox
            // 
            fbNTextBox.Location = new Point(8, 63);
            fbNTextBox.Name = "fbNTextBox";
            fbNTextBox.Size = new Size(100, 23);
            fbNTextBox.TabIndex = 17;
            fbNTextBox.Text = "30";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 45);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 16;
            label1.Text = "n (count)";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(fiOutputTextBox);
            tabPage2.Controls.Add(fiClearButton);
            tabPage2.Controls.Add(fiGenerateButton);
            tabPage2.Controls.Add(fiBTextBox);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(fiATextBox);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(fiNTextBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1157, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Fibonacci";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // fiOutputTextBox
            // 
            fiOutputTextBox.Location = new Point(6, 185);
            fiOutputTextBox.Multiline = true;
            fiOutputTextBox.Name = "fiOutputTextBox";
            fiOutputTextBox.ReadOnly = true;
            fiOutputTextBox.ScrollBars = ScrollBars.Vertical;
            fiOutputTextBox.Size = new Size(1147, 234);
            fiOutputTextBox.TabIndex = 9;
            // 
            // fiClearButton
            // 
            fiClearButton.Location = new Point(192, 119);
            fiClearButton.Name = "fiClearButton";
            fiClearButton.Size = new Size(75, 23);
            fiClearButton.TabIndex = 8;
            fiClearButton.Text = "Clear";
            fiClearButton.UseVisualStyleBackColor = true;
            fiClearButton.Click += fiClearButton_Click;
            // 
            // fiGenerateButton
            // 
            fiGenerateButton.Location = new Point(8, 119);
            fiGenerateButton.Name = "fiGenerateButton";
            fiGenerateButton.Size = new Size(75, 23);
            fiGenerateButton.TabIndex = 7;
            fiGenerateButton.Text = "Generate";
            fiGenerateButton.UseVisualStyleBackColor = true;
            fiGenerateButton.Click += fiGenerateButton_Click;
            // 
            // fiBTextBox
            // 
            fiBTextBox.Location = new Point(398, 41);
            fiBTextBox.Name = "fiBTextBox";
            fiBTextBox.Size = new Size(100, 23);
            fiBTextBox.TabIndex = 6;
            fiBTextBox.Text = "1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(398, 23);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 5;
            label9.Text = "b (default 1)";
            // 
            // fiATextBox
            // 
            fiATextBox.Location = new Point(192, 41);
            fiATextBox.Name = "fiATextBox";
            fiATextBox.Size = new Size(100, 23);
            fiATextBox.TabIndex = 4;
            fiATextBox.Text = "2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(192, 23);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 3;
            label8.Text = "a (default 2)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 23);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 2;
            label7.Text = "n(terms)";
            // 
            // fiNTextBox
            // 
            fiNTextBox.Location = new Point(8, 41);
            fiNTextBox.Name = "fiNTextBox";
            fiNTextBox.Size = new Size(100, 23);
            fiNTextBox.TabIndex = 1;
            fiNTextBox.Text = "20";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cxOutputTextBox);
            tabPage3.Controls.Add(cxBTextBox);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(cxATextBox);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(cxNTextBox);
            tabPage3.Controls.Add(cxClearButton);
            tabPage3.Controls.Add(cxGenerateButton);
            tabPage3.Controls.Add(cxPhraseBothTextBox);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(cxPhraseXTextBox);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(cxPhraseYTextBox);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(cxYTextBox);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(cxXTextBox);
            tabPage3.Controls.Add(label14);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1157, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Combined";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // cxClearButton
            // 
            cxClearButton.Location = new Point(195, 198);
            cxClearButton.Name = "cxClearButton";
            cxClearButton.Size = new Size(75, 23);
            cxClearButton.TabIndex = 43;
            cxClearButton.Text = "Clear";
            cxClearButton.UseVisualStyleBackColor = true;
            cxClearButton.Click += cxClearButton_Click;
            // 
            // cxGenerateButton
            // 
            cxGenerateButton.Location = new Point(8, 198);
            cxGenerateButton.Name = "cxGenerateButton";
            cxGenerateButton.Size = new Size(75, 23);
            cxGenerateButton.TabIndex = 42;
            cxGenerateButton.Text = "Generate";
            cxGenerateButton.UseVisualStyleBackColor = true;
            cxGenerateButton.Click += cxGenerateButton_Click;
            // 
            // cxPhraseBothTextBox
            // 
            cxPhraseBothTextBox.Location = new Point(352, 135);
            cxPhraseBothTextBox.Name = "cxPhraseBothTextBox";
            cxPhraseBothTextBox.Size = new Size(100, 23);
            cxPhraseBothTextBox.TabIndex = 41;
            cxPhraseBothTextBox.Text = "FizzBuzz";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(352, 117);
            label10.Name = "label10";
            label10.Size = new Size(88, 15);
            label10.TabIndex = 40;
            label10.Text = "Phrase for both";
            // 
            // cxPhraseXTextBox
            // 
            cxPhraseXTextBox.Location = new Point(8, 135);
            cxPhraseXTextBox.Name = "cxPhraseXTextBox";
            cxPhraseXTextBox.Size = new Size(100, 23);
            cxPhraseXTextBox.TabIndex = 39;
            cxPhraseXTextBox.Text = "Fizz";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 117);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 38;
            label11.Text = "Phrase for x";
            // 
            // cxPhraseYTextBox
            // 
            cxPhraseYTextBox.Location = new Point(195, 135);
            cxPhraseYTextBox.Name = "cxPhraseYTextBox";
            cxPhraseYTextBox.Size = new Size(100, 23);
            cxPhraseYTextBox.TabIndex = 37;
            cxPhraseYTextBox.Text = "Buzz";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(195, 117);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 36;
            label12.Text = "Phrase for y";
            // 
            // cxYTextBox
            // 
            cxYTextBox.Location = new Point(195, 46);
            cxYTextBox.Name = "cxYTextBox";
            cxYTextBox.Size = new Size(100, 23);
            cxYTextBox.TabIndex = 35;
            cxYTextBox.Text = "5";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(195, 29);
            label13.Name = "label13";
            label13.Size = new Size(108, 15);
            label13.TabIndex = 34;
            label13.Text = "y divisor (default 5)";
            // 
            // cxXTextBox
            // 
            cxXTextBox.Location = new Point(8, 46);
            cxXTextBox.Name = "cxXTextBox";
            cxXTextBox.Size = new Size(100, 23);
            cxXTextBox.TabIndex = 33;
            cxXTextBox.Text = "3";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 28);
            label14.Name = "label14";
            label14.Size = new Size(107, 15);
            label14.TabIndex = 32;
            label14.Text = "x divisor (default 3)";
            // 
            // cxBTextBox
            // 
            cxBTextBox.Location = new Point(744, 47);
            cxBTextBox.Name = "cxBTextBox";
            cxBTextBox.Size = new Size(100, 23);
            cxBTextBox.TabIndex = 49;
            cxBTextBox.Text = "1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(744, 29);
            label15.Name = "label15";
            label15.Size = new Size(71, 15);
            label15.TabIndex = 48;
            label15.Text = "b (default 1)";
            // 
            // cxATextBox
            // 
            cxATextBox.Location = new Point(744, 126);
            cxATextBox.Name = "cxATextBox";
            cxATextBox.Size = new Size(100, 23);
            cxATextBox.TabIndex = 47;
            cxATextBox.Text = "2";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(744, 108);
            label16.Name = "label16";
            label16.Size = new Size(70, 15);
            label16.TabIndex = 46;
            label16.Text = "a (default 2)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(586, 29);
            label17.Name = "label17";
            label17.Size = new Size(52, 15);
            label17.TabIndex = 45;
            label17.Text = "n(terms)";
            // 
            // cxNTextBox
            // 
            cxNTextBox.Location = new Point(586, 47);
            cxNTextBox.Name = "cxNTextBox";
            cxNTextBox.Size = new Size(100, 23);
            cxNTextBox.TabIndex = 44;
            cxNTextBox.Text = "20";
            // 
            // cxOutputTextBox
            // 
            cxOutputTextBox.Location = new Point(1, 227);
            cxOutputTextBox.Multiline = true;
            cxOutputTextBox.Name = "cxOutputTextBox";
            cxOutputTextBox.ReadOnly = true;
            cxOutputTextBox.ScrollBars = ScrollBars.Vertical;
            cxOutputTextBox.Size = new Size(1160, 191);
            cxOutputTextBox.TabIndex = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 450);
            Controls.Add(tabControlMain);
            Name = "Form1";
            Text = "Form1";
            tabControlMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox fiNTextBox;
        private TextBox fbOutputTextBox;
        private Button fbClearButton;
        private Button fbGenerateButton;
        private TextBox fbPhraseBothTextBox;
        private Label label6;
        private TextBox fbPhraseXTextBox;
        private Label label5;
        private TextBox fbPhraseYTextBox;
        private Label label4;
        private TextBox fbYTextBox;
        private Label label3;
        private TextBox fbXTextBox;
        private Label label2;
        private TextBox fbNTextBox;
        private Label label1;
        private Label label7;
        private TextBox fiATextBox;
        private Label label8;
        private TextBox fiBTextBox;
        private Label label9;
        private TextBox fiOutputTextBox;
        private Button fiClearButton;
        private Button fiGenerateButton;
        private Button cxClearButton;
        private Button cxGenerateButton;
        private TextBox cxPhraseBothTextBox;
        private Label label10;
        private TextBox cxPhraseXTextBox;
        private Label label11;
        private TextBox cxPhraseYTextBox;
        private Label label12;
        private TextBox cxYTextBox;
        private Label label13;
        private TextBox cxXTextBox;
        private Label label14;
        private TextBox cxBTextBox;
        private Label label15;
        private TextBox cxATextBox;
        private Label label16;
        private Label label17;
        private TextBox cxNTextBox;
        private TextBox cxOutputTextBox;
    }
}
