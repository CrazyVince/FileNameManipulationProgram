﻿namespace FindReplaceFile
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
            this.openFilesBtn = new System.Windows.Forms.Button();
            this.loadedFilesLbl = new System.Windows.Forms.Label();
            this.findTxt = new System.Windows.Forms.TextBox();
            this.replaceTxt = new System.Windows.Forms.TextBox();
            this.FRBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addToStartTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addToStartBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addToEndTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addToEndBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFilesBtn
            // 
            this.openFilesBtn.Location = new System.Drawing.Point(147, 49);
            this.openFilesBtn.Name = "openFilesBtn";
            this.openFilesBtn.Size = new System.Drawing.Size(76, 28);
            this.openFilesBtn.TabIndex = 1;
            this.openFilesBtn.Text = "open files";
            this.openFilesBtn.UseVisualStyleBackColor = true;
            this.openFilesBtn.Click += new System.EventHandler(this.openFilesBtn_Click);
            // 
            // loadedFilesLbl
            // 
            this.loadedFilesLbl.BackColor = System.Drawing.Color.GhostWhite;
            this.loadedFilesLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.loadedFilesLbl.Location = new System.Drawing.Point(12, 344);
            this.loadedFilesLbl.Name = "loadedFilesLbl";
            this.loadedFilesLbl.Size = new System.Drawing.Size(516, 129);
            this.loadedFilesLbl.TabIndex = 2;
            // 
            // findTxt
            // 
            this.findTxt.Location = new System.Drawing.Point(45, 21);
            this.findTxt.Name = "findTxt";
            this.findTxt.Size = new System.Drawing.Size(195, 20);
            this.findTxt.TabIndex = 3;
            // 
            // replaceTxt
            // 
            this.replaceTxt.Location = new System.Drawing.Point(302, 21);
            this.replaceTxt.Name = "replaceTxt";
            this.replaceTxt.Size = new System.Drawing.Size(195, 20);
            this.replaceTxt.TabIndex = 4;
            // 
            // FRBtn
            // 
            this.FRBtn.Location = new System.Drawing.Point(518, 16);
            this.FRBtn.Name = "FRBtn";
            this.FRBtn.Size = new System.Drawing.Size(122, 28);
            this.FRBtn.TabIndex = 5;
            this.FRBtn.Text = "find and replace";
            this.FRBtn.UseVisualStyleBackColor = true;
            this.FRBtn.Click += new System.EventHandler(this.FRBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(172, 234);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(51, 28);
            this.doneBtn.TabIndex = 8;
            this.doneBtn.Text = "done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "loaded files:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "find: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "replace:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.FRBtn);
            this.groupBox1.Controls.Add(this.replaceTxt);
            this.groupBox1.Location = new System.Drawing.Point(309, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 56);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "find and replace";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addToStartTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addToStartBtn);
            this.groupBox2.Location = new System.Drawing.Point(309, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 56);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "add to start";
            // 
            // addToStartTxt
            // 
            this.addToStartTxt.Location = new System.Drawing.Point(45, 21);
            this.addToStartTxt.Name = "addToStartTxt";
            this.addToStartTxt.Size = new System.Drawing.Size(195, 20);
            this.addToStartTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "add: ";
            // 
            // addToStartBtn
            // 
            this.addToStartBtn.Location = new System.Drawing.Point(302, 19);
            this.addToStartBtn.Name = "addToStartBtn";
            this.addToStartBtn.Size = new System.Drawing.Size(122, 28);
            this.addToStartBtn.TabIndex = 5;
            this.addToStartBtn.Text = "add";
            this.addToStartBtn.UseVisualStyleBackColor = true;
            this.addToStartBtn.Click += new System.EventHandler(this.addToStartBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addToEndTxt);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.addToEndBtn);
            this.groupBox3.Location = new System.Drawing.Point(309, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 56);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "add to end";
            // 
            // addToEndTxt
            // 
            this.addToEndTxt.Location = new System.Drawing.Point(45, 21);
            this.addToEndTxt.Name = "addToEndTxt";
            this.addToEndTxt.Size = new System.Drawing.Size(195, 20);
            this.addToEndTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "add: ";
            // 
            // addToEndBtn
            // 
            this.addToEndBtn.Location = new System.Drawing.Point(302, 19);
            this.addToEndBtn.Name = "addToEndBtn";
            this.addToEndBtn.Size = new System.Drawing.Size(122, 28);
            this.addToEndBtn.TabIndex = 5;
            this.addToEndBtn.Text = "add";
            this.addToEndBtn.UseVisualStyleBackColor = true;
            this.addToEndBtn.Click += new System.EventHandler(this.addToEndBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 482);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.loadedFilesLbl);
            this.Controls.Add(this.openFilesBtn);
            this.Name = "Form1";
            this.Text = "F&R filenames";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFilesBtn;
        private System.Windows.Forms.Label loadedFilesLbl;
        private System.Windows.Forms.TextBox findTxt;
        private System.Windows.Forms.TextBox replaceTxt;
        private System.Windows.Forms.Button FRBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox addToStartTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addToStartBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox addToEndTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addToEndBtn;
    }
}

