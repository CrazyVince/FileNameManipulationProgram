using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace FindReplaceFile
{
    public partial class MainWindow : Form
    {
        List<string> loadedNames;
        List<string> processedNames;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadedNames = new List<string>();
            processedNames = new List<string>();

        }

        private void openFilesBtn_Click(object sender, EventArgs e)
        {
            //create and show a new open file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();

            //load the file names into the loaded files list
            loadedNames.Clear();
            foreach(string name in openFileDialog.FileNames)
                loadedNames.Add(name);

            //display the loaded files in the label.
            foreach (string name in loadedNames) 
            {
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);

                //if file is pdf, also show the page count
                string pageCountStr = "";

                string type = name.Substring(name.LastIndexOf('.'));
                if (type == ".pdf") pageCountStr = GetPdfPagesCount(name).ToString();
                else pageCountStr = "None";

                loadedFilesDGV.Rows.Add("", nameCut, pageCountStr);
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

            processedNames.Clear();
            foreach (string name in loadedNames)
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
                processedNames.Add(processedName);
            }

            Apply();
        }

        private void addToStartBtn_Click(object sender, EventArgs e)
        {
            string addText = addToStartTxt.Text;

            foreach (string name in loadedNames)
            {
                //get the name without the path and extension
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);

                //make the changes
                string processedNameCut = addText + nameCut;

                //add the path to the cut name
                string path = name.Substring(0, name.Length - nameCut.Length);
                string processedName = path + processedNameCut;

                //add the processed name into the processed names array
                processedNames.Add(processedName);
            }

            Apply();
        }

        private void addToEndBtn_Click(object sender, EventArgs e)
        {
            string addText = addToEndTxt.Text;

            foreach(string name in loadedNames)
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
                processedNames.Add(processedName);
            }

            //apply the changes
            Apply();
        }

        private void deleteFromStartBtn_Click(object sender, EventArgs e)
        {
            int deleteNum = (int)deleteFromStartNum.Value;

            foreach (string name in loadedNames)
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
                processedNames.Add(processedName);
            }

            //apply the changes
            Apply();
        }

        private void deleteFromEndBtn_Click(object sender, EventArgs e)
        {
            int deleteNum = (int)deleteFromEndNum.Value;

            foreach (string name in loadedNames)
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
                processedNames.Add(processedName);
            }

            //apply the changes
            Apply();
        }
        private void seperateProjectCodeBtn_Click(object sender, EventArgs e)
        {
            //get the code length
            int codeLength = (int)projectCodeLengthNum.Value;

            //clear the loaded files table
            loadedFilesDGV.Rows.Clear();
            foreach (string name in loadedNames)
            {
                //cut the name
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);

                //get the project code
                string projectCode = nameCut.Substring(0, (int)codeLength);

                //cut the code away from the name
                nameCut = nameCut.Substring(codeLength);

                //if file type is pdf, get the page count, if not leave it as 'none'
                string pageCountStr = "none";

                string type = name.Substring(name.LastIndexOf('.'));
                if (type == ".pdf") pageCountStr = GetPdfPagesCount(name).ToString();

                //load in the new values
                loadedFilesDGV.Rows.Add(projectCode, nameCut, pageCountStr);
            }
        }

        void Apply()
        {
            //Check for matching names. If matching names ar found, return out of the function.
            for (int i = 0; i < processedNames.Count; i++)
            {
                string name = processedNames[i];
                for (int j = 0; j < processedNames.Count; j++)
                {
                    if (j != i)
                    {
                        if (name == processedNames[j])
                        {
                            MessageBox.Show("aborting, because there are matching names!!!");
                            return;
                        }
                    }
                }
            }

            //rename the files to the processed names
            for (int i = 0; i < loadedNames.Count; i++)
            {
                try
                {
                    File.Move(loadedNames[i], processedNames[i]);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;
                }

            }

            //load the new values into the loaded files list
            loadedNames.Clear();
            foreach (string name in processedNames)
                loadedNames.Add(name);

            processedNames.Clear();

            //update the loaded files label to show the new names.
            loadedFilesDGV.Rows.Clear();
            foreach (string name in loadedNames)
            {
                string nameCut = name.Substring(name.LastIndexOf('\\') + 1);

                //if file is pdf, add the page count to the display
                string pageCountStr = "";

                string type = name.Substring(name.LastIndexOf('.'));
                if (type == ".pdf") pageCountStr = GetPdfPagesCount(name).ToString();

                else pageCountStr = "None";

                loadedFilesDGV.Rows.Add("", nameCut, pageCountStr);
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
            loadedNames.Clear();
            processedNames.Clear();
            loadedFilesDGV.Rows.Clear();
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            loadedFilesDGV.Rows.Clear();
            findTxt.Text = "";
            replaceTxt.Text = "";
            addToEndTxt.Text = "";
            addToStartTxt.Text = "";
            deleteFromEndNum.Value = 0;
            deleteFromStartNum.Value = 0;
            loadedNames.Clear();
            processedNames.Clear();
        }

        private void loadedFilesLst_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void loadedFilesLst_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    loadedNames.Add(file);
                    string nameCut = file.Substring(file.LastIndexOf('\\') + 1);

                    //if file is pdf, add the page count to the display
                    string pageCountStr = "";

                    string type = file.Substring(file.LastIndexOf('.'));
                    if (type == ".pdf") pageCountStr = GetPdfPagesCount(file).ToString();

                    else pageCountStr = "None";

                    loadedFilesDGV.Rows.Add("", nameCut, pageCountStr);
                }
            }
        }

        private void loadedFilesDVG_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void loadedFilesDVG_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    loadedNames.Add(file);
                    string nameCut = file.Substring(file.LastIndexOf('\\') + 1);

                    //if file is pdf, add the page count to the display
                    string pageCountStr = "";

                    string type = file.Substring(file.LastIndexOf('.'));
                    if (type == ".pdf") pageCountStr = GetPdfPagesCount(file).ToString();

                    else pageCountStr = "None";

                    loadedFilesDGV.Rows.Add("", nameCut, pageCountStr);
                }
            }
        }

        int GetPdfPagesCount(string path)
        {
            PdfReader reader = new PdfReader(path);
            int count = reader.NumberOfPages;
            reader.Dispose();
            return count;
        }

        
    }
}
