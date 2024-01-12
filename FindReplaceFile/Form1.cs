﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FindReplaceFile
{
    public partial class Form1 : Form
    {
        List<string> NamesRaw;
        List<string> NamesProcessed;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NamesRaw = new List<string>();
            NamesProcessed = new List<string>();

        }

        private void openFilesBtn_Click(object sender, EventArgs e)
        {
            //create and show a new open file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();

            //load the file names into the loaded files list
            NamesRaw.Clear();
            foreach(string name in openFileDialog.FileNames)
                NamesRaw.Add(name);

            //display the loaded files in the label.
            ResetTexts();
            foreach (string name in NamesRaw) 
            {
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);

                loadedFilesLbl.Text += nameCut + ", ";
            }
        }

        private void FRBtn_Click(object sender, EventArgs e)
        {
            string findString = findTxt.Text;
            string replaceString = replaceTxt.Text;

            //if the text boxes are epmty, abort
            if (findString == "" || replaceString == "")
            {
                MessageBox.Show("the find and replace text boxes can't be empty!");
                return;
            }

            NamesProcessed.Clear();
            foreach (string name in NamesRaw)
            {
                //get the name without the path and extension
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);
                nameCut = nameCut.Substring(0, nameCut.LastIndexOf('.'));

                //make the changes
                string processedNameCut = nameCut.Replace(findString, replaceString);

                //add the path and the extension to the cut name
                string path = name.Substring(0, name.LastIndexOf('\\') + 1);
                string type = name.Substring(name.LastIndexOf('.'));
                string processedName = path + processedNameCut + type;

                //add the processed name into the processed names list
                NamesProcessed.Add(processedName);
            }

            Apply();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            ResetTexts();
            NamesRaw.Clear();
            NamesProcessed.Clear();
        }



        private void addToStartBtn_Click(object sender, EventArgs e)
        {
            string addText = addToStartTxt.Text;

            foreach (string name in NamesRaw)
            {
                //get the name without the path and extension
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);

                //make the changes
                string processedNameCut = addText + nameCut;

                //add the path to the cut name
                string path = name.Substring(0, name.Length - nameCut.Length);
                string processedName = path + processedNameCut;

                //add the processed name into the processed names array
                NamesProcessed.Add(processedName);
            }

            Apply();
        }

        private void addToEndBtn_Click(object sender, EventArgs e)
        {
            string addText = addToEndTxt.Text;

            foreach(string name in NamesRaw)
            {
                //get the name without the path and extension
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);
                nameCut = nameCut.Substring(0, nameCut.LastIndexOf('.'));

                //make the changes
                string processedNameCut = nameCut + addText;

                //add the path and extension to the cut name
                string path = name.Substring(0, name.LastIndexOf('\\') + 1);
                string type = name.Substring(name.LastIndexOf('.'));
                string processedName = path + processedNameCut + type;

                //add the processed name to the processed names array
                NamesProcessed.Add(processedName);
            }

            //apply the changes
            Apply();
        }

        void Apply()
        {
            //Check for matching names. If matching names ar found, return out of the function.
            for (int i = 0; i < NamesProcessed.Count; i++)
            {
                string name = NamesProcessed[i];
                for (int j = 0; j < NamesProcessed.Count; j++)
                {
                    if (j != i)
                    {
                        if (name == NamesProcessed[j])
                        {
                            MessageBox.Show("aborting, because there are matching names!!!");
                            return;
                        }
                    }
                }
            }

            //rename the files to the processed names
            for (int i = 0; i < NamesRaw.Count; i++)
            {
                try
                {
                    File.Move(NamesRaw[i], NamesProcessed[i]);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;
                }

            }

            //load the new values into the loaded files list
            NamesRaw.Clear();
            foreach (string name in NamesProcessed)
                NamesRaw.Add(name);

            NamesProcessed.Clear();

            //update the loaded files label to show the new names.
            ResetTexts();
            foreach (string name in NamesRaw)
            {
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);

                loadedFilesLbl.Text += nameCut + ", ";
            }
        }


        void ResetTexts()
        {
            loadedFilesLbl.Text = "";
            findTxt.Text = "";
            replaceTxt.Text = "";
            addToEndTxt.Text = "";
            addToStartTxt.Text = "";
        }
    }
}
