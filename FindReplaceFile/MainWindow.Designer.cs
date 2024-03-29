﻿namespace FindReplaceFile
{
    partial class MainWindow
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
            this.findTxt = new System.Windows.Forms.TextBox();
            this.replaceTxt = new System.Windows.Forms.TextBox();
            this.FRBtn = new System.Windows.Forms.Button();
            this.clearAllBtn = new System.Windows.Forms.Button();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteFromStartNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteFromStartBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.deleteFromEndNum = new System.Windows.Forms.NumericUpDown();
            this.deleteFromEndBtn = new System.Windows.Forms.Button();
            this.clearTextBoxesBtn = new System.Windows.Forms.Button();
            this.clearLoadedFilesBtn = new System.Windows.Forms.Button();
            this.loadedFilesDGV = new System.Windows.Forms.DataGridView();
            this.FileCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.projectCodeLengthNum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.seperateProjectCodeBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFromStartNum)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFromEndNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadedFilesDGV)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectCodeLengthNum)).BeginInit();
            this.SuspendLayout();
            // 
            // openFilesBtn
            // 
            this.openFilesBtn.Location = new System.Drawing.Point(747, 12);
            this.openFilesBtn.Name = "openFilesBtn";
            this.openFilesBtn.Size = new System.Drawing.Size(95, 36);
            this.openFilesBtn.TabIndex = 1;
            this.openFilesBtn.Text = "open files";
            this.openFilesBtn.UseVisualStyleBackColor = true;
            this.openFilesBtn.Click += new System.EventHandler(this.openFilesBtn_Click);
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
            // clearAllBtn
            // 
            this.clearAllBtn.Location = new System.Drawing.Point(844, 50);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(93, 37);
            this.clearAllBtn.TabIndex = 8;
            this.clearAllBtn.Text = "clear everything";
            this.clearAllBtn.UseVisualStyleBackColor = true;
            this.clearAllBtn.Click += new System.EventHandler(this.clearAllBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 37);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 148);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deleteFromStartNum);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.deleteFromStartBtn);
            this.groupBox4.Location = new System.Drawing.Point(491, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(455, 56);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "delete from start";
            // 
            // deleteFromStartNum
            // 
            this.deleteFromStartNum.Location = new System.Drawing.Point(83, 19);
            this.deleteFromStartNum.Name = "deleteFromStartNum";
            this.deleteFromStartNum.Size = new System.Drawing.Size(120, 20);
            this.deleteFromStartNum.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "remove:";
            // 
            // deleteFromStartBtn
            // 
            this.deleteFromStartBtn.Location = new System.Drawing.Point(302, 19);
            this.deleteFromStartBtn.Name = "deleteFromStartBtn";
            this.deleteFromStartBtn.Size = new System.Drawing.Size(122, 28);
            this.deleteFromStartBtn.TabIndex = 5;
            this.deleteFromStartBtn.Text = "delete";
            this.deleteFromStartBtn.UseVisualStyleBackColor = true;
            this.deleteFromStartBtn.Click += new System.EventHandler(this.deleteFromStartBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "remove:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.deleteFromEndNum);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.deleteFromEndBtn);
            this.groupBox5.Location = new System.Drawing.Point(491, 148);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(455, 56);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "delete from end";
            // 
            // deleteFromEndNum
            // 
            this.deleteFromEndNum.Location = new System.Drawing.Point(83, 21);
            this.deleteFromEndNum.Name = "deleteFromEndNum";
            this.deleteFromEndNum.Size = new System.Drawing.Size(120, 20);
            this.deleteFromEndNum.TabIndex = 13;
            // 
            // deleteFromEndBtn
            // 
            this.deleteFromEndBtn.Location = new System.Drawing.Point(302, 19);
            this.deleteFromEndBtn.Name = "deleteFromEndBtn";
            this.deleteFromEndBtn.Size = new System.Drawing.Size(122, 28);
            this.deleteFromEndBtn.TabIndex = 5;
            this.deleteFromEndBtn.Text = "delete";
            this.deleteFromEndBtn.UseVisualStyleBackColor = true;
            this.deleteFromEndBtn.Click += new System.EventHandler(this.deleteFromEndBtn_Click);
            // 
            // clearTextBoxesBtn
            // 
            this.clearTextBoxesBtn.Location = new System.Drawing.Point(844, 11);
            this.clearTextBoxesBtn.Name = "clearTextBoxesBtn";
            this.clearTextBoxesBtn.Size = new System.Drawing.Size(93, 37);
            this.clearTextBoxesBtn.TabIndex = 19;
            this.clearTextBoxesBtn.Text = "clear text boxes";
            this.clearTextBoxesBtn.UseVisualStyleBackColor = true;
            this.clearTextBoxesBtn.Click += new System.EventHandler(this.clearTextBoxesBtn_Click);
            // 
            // clearLoadedFilesBtn
            // 
            this.clearLoadedFilesBtn.Location = new System.Drawing.Point(748, 50);
            this.clearLoadedFilesBtn.Name = "clearLoadedFilesBtn";
            this.clearLoadedFilesBtn.Size = new System.Drawing.Size(93, 37);
            this.clearLoadedFilesBtn.TabIndex = 20;
            this.clearLoadedFilesBtn.Text = "clear loaded files";
            this.clearLoadedFilesBtn.UseVisualStyleBackColor = true;
            this.clearLoadedFilesBtn.Click += new System.EventHandler(this.clearLoadedFilesBtn_Click);
            // 
            // loadedFilesDGV
            // 
            this.loadedFilesDGV.AllowDrop = true;
            this.loadedFilesDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.loadedFilesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadedFilesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileCode,
            this.FileName,
            this.PageCount});
            this.loadedFilesDGV.Location = new System.Drawing.Point(27, 332);
            this.loadedFilesDGV.Name = "loadedFilesDGV";
            this.loadedFilesDGV.Size = new System.Drawing.Size(943, 197);
            this.loadedFilesDGV.TabIndex = 22;
            this.loadedFilesDGV.DragDrop += new System.Windows.Forms.DragEventHandler(this.loadedFilesDVG_DragDrop);
            this.loadedFilesDGV.DragEnter += new System.Windows.Forms.DragEventHandler(this.loadedFilesDVG_DragEnter);
            // 
            // FileCode
            // 
            this.FileCode.HeaderText = "code";
            this.FileCode.Name = "FileCode";
            this.FileCode.Width = 200;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "file name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 600;
            // 
            // PageCount
            // 
            this.PageCount.HeaderText = "page count";
            this.PageCount.Name = "PageCount";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.projectCodeLengthNum);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.seperateProjectCodeBtn);
            this.groupBox6.Location = new System.Drawing.Point(12, 210);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(353, 56);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "seperate project code";
            // 
            // projectCodeLengthNum
            // 
            this.projectCodeLengthNum.Location = new System.Drawing.Point(83, 21);
            this.projectCodeLengthNum.Name = "projectCodeLengthNum";
            this.projectCodeLengthNum.Size = new System.Drawing.Size(120, 20);
            this.projectCodeLengthNum.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "code length:";
            // 
            // seperateProjectCodeBtn
            // 
            this.seperateProjectCodeBtn.Location = new System.Drawing.Point(219, 16);
            this.seperateProjectCodeBtn.Name = "seperateProjectCodeBtn";
            this.seperateProjectCodeBtn.Size = new System.Drawing.Size(122, 28);
            this.seperateProjectCodeBtn.TabIndex = 5;
            this.seperateProjectCodeBtn.Text = "seperate";
            this.seperateProjectCodeBtn.UseVisualStyleBackColor = true;
            this.seperateProjectCodeBtn.Click += new System.EventHandler(this.seperateProjectCodeBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 541);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.loadedFilesDGV);
            this.Controls.Add(this.clearLoadedFilesBtn);
            this.Controls.Add(this.clearTextBoxesBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearAllBtn);
            this.Controls.Add(this.openFilesBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "FNMP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFromStartNum)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFromEndNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadedFilesDGV)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectCodeLengthNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFilesBtn;
        private System.Windows.Forms.TextBox findTxt;
        private System.Windows.Forms.TextBox replaceTxt;
        private System.Windows.Forms.Button FRBtn;
        private System.Windows.Forms.Button clearAllBtn;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown deleteFromStartNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteFromStartBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown deleteFromEndNum;
        private System.Windows.Forms.Button deleteFromEndBtn;
        private System.Windows.Forms.Button clearTextBoxesBtn;
        private System.Windows.Forms.Button clearLoadedFilesBtn;
        private System.Windows.Forms.DataGridView loadedFilesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageCount;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown projectCodeLengthNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button seperateProjectCodeBtn;
    }
}

