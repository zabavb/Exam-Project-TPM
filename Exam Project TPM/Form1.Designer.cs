﻿namespace Exam_Project_TPM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.rightBraceButton = new System.Windows.Forms.Button();
            this.leftBraceButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonABSOrIABS = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.expressionBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backspaceButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.rightBraceButton);
            this.groupBox1.Controls.Add(this.leftBraceButton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBox1.Size = new System.Drawing.Size(480, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing";
            // 
            // backspaceButton
            // 
            this.backspaceButton.ForeColor = System.Drawing.Color.White;
            this.backspaceButton.Location = new System.Drawing.Point(208, 26);
            this.backspaceButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(147, 53);
            this.backspaceButton.TabIndex = 3;
            this.backspaceButton.Text = "Backspace";
            this.backspaceButton.UseVisualStyleBackColor = true;
            this.backspaceButton.Click += new System.EventHandler(this.backspaceButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(366, 26);
            this.clearButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 53);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // rightBraceButton
            // 
            this.rightBraceButton.ForeColor = System.Drawing.Color.White;
            this.rightBraceButton.Location = new System.Drawing.Point(91, 26);
            this.rightBraceButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.rightBraceButton.Name = "rightBraceButton";
            this.rightBraceButton.Size = new System.Drawing.Size(72, 53);
            this.rightBraceButton.TabIndex = 1;
            this.rightBraceButton.Text = ")";
            this.rightBraceButton.UseVisualStyleBackColor = true;
            this.rightBraceButton.Click += new System.EventHandler(this.rightBraceButton_Click);
            // 
            // leftBraceButton
            // 
            this.leftBraceButton.ForeColor = System.Drawing.Color.White;
            this.leftBraceButton.Location = new System.Drawing.Point(10, 27);
            this.leftBraceButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.leftBraceButton.Name = "leftBraceButton";
            this.leftBraceButton.Size = new System.Drawing.Size(72, 53);
            this.leftBraceButton.TabIndex = 0;
            this.leftBraceButton.Text = "(";
            this.leftBraceButton.UseVisualStyleBackColor = true;
            this.leftBraceButton.Click += new System.EventHandler(this.leftBraceButton_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 220);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(117, 220);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(198, 220);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 54);
            this.button3.TabIndex = 6;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(36, 282);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 54);
            this.button4.TabIndex = 7;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(117, 282);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 54);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(198, 282);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 54);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(36, 344);
            this.button7.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 54);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(117, 344);
            this.button8.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 54);
            this.button8.TabIndex = 11;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(198, 344);
            this.button9.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 54);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.Location = new System.Drawing.Point(117, 407);
            this.button0.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(72, 54);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonComma
            // 
            this.buttonComma.ForeColor = System.Drawing.Color.White;
            this.buttonComma.Location = new System.Drawing.Point(36, 407);
            this.buttonComma.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(72, 54);
            this.buttonComma.TabIndex = 14;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = true;
            this.buttonComma.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.ForeColor = System.Drawing.Color.White;
            this.buttonMod.Location = new System.Drawing.Point(198, 407);
            this.buttonMod.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(72, 54);
            this.buttonMod.TabIndex = 15;
            this.buttonMod.Text = "mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.ForeColor = System.Drawing.Color.White;
            this.buttonPlus.Location = new System.Drawing.Point(279, 407);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(72, 54);
            this.buttonPlus.TabIndex = 16;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.ForeColor = System.Drawing.Color.White;
            this.buttonSub.Location = new System.Drawing.Point(279, 344);
            this.buttonSub.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(72, 54);
            this.buttonSub.TabIndex = 17;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.ForeColor = System.Drawing.Color.White;
            this.buttonMul.Location = new System.Drawing.Point(279, 282);
            this.buttonMul.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(72, 54);
            this.buttonMul.TabIndex = 18;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.ForeColor = System.Drawing.Color.White;
            this.buttonDiv.Location = new System.Drawing.Point(279, 220);
            this.buttonDiv.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(72, 54);
            this.buttonDiv.TabIndex = 19;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.ForeColor = System.Drawing.Color.White;
            this.buttonEquals.Location = new System.Drawing.Point(433, 407);
            this.buttonEquals.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(72, 54);
            this.buttonEquals.TabIndex = 20;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.ForeColor = System.Drawing.Color.White;
            this.buttonMC.Location = new System.Drawing.Point(433, 344);
            this.buttonMC.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(72, 54);
            this.buttonMC.TabIndex = 21;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.ForeColor = System.Drawing.Color.White;
            this.buttonMR.Location = new System.Drawing.Point(433, 220);
            this.buttonMR.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(72, 54);
            this.buttonMR.TabIndex = 22;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.buttonMR_Click);
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.ForeColor = System.Drawing.Color.White;
            this.buttonMPlus.Location = new System.Drawing.Point(433, 282);
            this.buttonMPlus.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(72, 54);
            this.buttonMPlus.TabIndex = 23;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.UseVisualStyleBackColor = true;
            this.buttonMPlus.Click += new System.EventHandler(this.buttonMPlus_Click);
            // 
            // buttonABSOrIABS
            // 
            this.buttonABSOrIABS.ForeColor = System.Drawing.Color.White;
            this.buttonABSOrIABS.Location = new System.Drawing.Point(357, 220);
            this.buttonABSOrIABS.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonABSOrIABS.Name = "buttonABSOrIABS";
            this.buttonABSOrIABS.Size = new System.Drawing.Size(72, 54);
            this.buttonABSOrIABS.TabIndex = 24;
            this.buttonABSOrIABS.Text = "+/-";
            this.buttonABSOrIABS.UseVisualStyleBackColor = true;
            this.buttonABSOrIABS.Click += new System.EventHandler(this.buttonABSOrIABS_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(117, 53);
            this.resultBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(388, 26);
            this.resultBox.TabIndex = 3;
            // 
            // expressionBox
            // 
            this.expressionBox.Location = new System.Drawing.Point(117, 17);
            this.expressionBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.expressionBox.Name = "expressionBox";
            this.expressionBox.Size = new System.Drawing.Size(388, 26);
            this.expressionBox.TabIndex = 1;
            this.expressionBox.TextChanged += new System.EventHandler(this.expressionBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 478);
            this.Controls.Add(this.buttonABSOrIABS);
            this.Controls.Add(this.buttonMPlus);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonComma);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expressionBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Calc";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button leftBraceButton;
        private System.Windows.Forms.Button rightBraceButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonABSOrIABS;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox expressionBox;
    }
}

