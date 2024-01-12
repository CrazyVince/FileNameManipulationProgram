using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();

            NamesRaw.Clear();
            foreach(string name in openFileDialog.FileNames)
                NamesRaw.Add(name);

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

            if (findString == "" || replaceString == "")
            {
                MessageBox.Show("the find and replace text boxes can't be empty!");
                return;
            }

            NamesProcessed.Clear();
            foreach (string name in NamesRaw)
            {
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);
                string processedNameCut = nameCut.Replace(findString, replaceString);
                string path = name.Substring(0, name.Length - nameCut.Length);
                string processedName = path + processedNameCut;

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
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);
                string processedNameCut = addText + nameCut;
                string path = name.Substring(0, name.Length - nameCut.Length);
                string processedName = path + processedNameCut;

                NamesProcessed.Add(processedName);

                loadedFilesLbl.Text = "";
                loadedFilesLbl.Text += processedNameCut + ", ";
            }

            Apply();
        }

        private void addToEndBtn_Click(object sender, EventArgs e)
        {
            string addText = addToEndTxt.Text;

            foreach(string name in NamesRaw)
            {
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);
                nameCut = nameCut.Substring(0, nameCut.LastIndexOf('.'));
                string processedNameCut = nameCut + addText;
                string path = name.Substring(0, name.LastIndexOf('\\') + 1);
                string type = name.Substring(name.LastIndexOf('.'));
                string processedName = path + processedNameCut + type;

                NamesProcessed.Add(processedName);

                loadedFilesLbl.Text = "";
            }

            Apply();
        }

        void Apply()
        {
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

            NamesRaw.Clear();
            foreach (string name in NamesProcessed)
                NamesRaw.Add(name);

            NamesProcessed.Clear();

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
