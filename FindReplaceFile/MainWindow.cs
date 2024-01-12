using System;
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
    public partial class MainWindow : Form
    {
        List<string> NamesRaw;
        List<string> NamesProcessed;


        public MainWindow()
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
            loadedFilesLbl.Text = "";
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
            if (findString == "")
            {
                MessageBox.Show("the find text box can't be empty!");
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

        private void deleteFromStartBtn_Click(object sender, EventArgs e)
        {
            int deleteNum = (int)deleteFromStartNum.Value;

            foreach (string name in NamesRaw)
            {
                //get the name without the path and extension
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);
                nameCut = nameCut.Substring(0, nameCut.LastIndexOf('.'));

                //make the changes
                if (deleteNum > nameCut.Length)
                {
                    MessageBox.Show("you cant delete more than the length of the file name!");
                    return;
                }
                string processedNameCut = nameCut.Substring(deleteNum);

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

        private void deleteFromEndBtn_Click(object sender, EventArgs e)
        {
            int deleteNum = (int)deleteFromEndNum.Value;

            foreach (string name in NamesRaw)
            {
                //get the name without the path and extension
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);
                nameCut = nameCut.Substring(0, nameCut.LastIndexOf('.'));

                //make the changes
                if (deleteNum > nameCut.Length)
                {
                    MessageBox.Show("you cant delete more than the length of the file name!");
                    return;
                }
                string processedNameCut = nameCut.Substring(0, nameCut.Length - deleteNum);

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
            loadedFilesLbl.Text = "";
            foreach (string name in NamesRaw)
            {
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);

                loadedFilesLbl.Text += nameCut + ", ";
            }
        }

        private void clearTextBoxesBtn_Click(object sender, EventArgs e)
        {
            findTxt.Text = "";
            replaceTxt.Text = "";
            addToEndTxt.Text = "";
            addToStartTxt.Text = "";
            deleteFromEndNum.Value = 0;
            deleteFromStartNum.Value = 0;
        }

        private void clearLoadedFilesBtn_Click(object sender, EventArgs e)
        {
            NamesRaw.Clear();
            NamesProcessed.Clear();
            loadedFilesLbl.Text = "";
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            loadedFilesLbl.Text = "";
            findTxt.Text = "";
            replaceTxt.Text = "";
            addToEndTxt.Text = "";
            addToStartTxt.Text = "";
            deleteFromEndNum.Value = 0;
            deleteFromStartNum.Value = 0;
            NamesRaw.Clear();
            NamesProcessed.Clear();
        }
    }
}
