using Microsoft.VisualBasic.FileIO;
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

namespace Assembler
{
    public partial class Form1 : Form
    {
        private String filename;
        List<String> asmElements = new List<String>();
        string[] registers = new string[16];

        public Form1()
        {
            InitializeComponent();
            
        }

        private String getFileName(String filter)
        {
            try
            {
                /* Local variable used to store the filename */
                String fileNameWithPath = "";
                /* Instantiate an OpenFileDialog */
                OpenFileDialog of = new OpenFileDialog();
                /* Set the filter */
                of.Filter = filter;
                /* Get the working directory */
                of.InitialDirectory = Path.GetFullPath("..\\Debug");
                of.RestoreDirectory = true;
                /* Display the Open File dialog */
                if (of.ShowDialog() == DialogResult.OK)
                {
                    /* Get only the filename with full path */
                    fileNameWithPath = of.FileName;
                    /* Get only the filename without path */
                    filename = of.SafeFileName;
                }
                /* Return the filename with complete path */
                return fileNameWithPath;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        private string mov(string x, string y) {

            x = y;

            return x;
        }

        private int NOP()
        {
            return 0;
        }

        private string Instruction(string instr_name)
        {
            string var1 = "1", var2 = "2", rez;

            const string MOV = "MOV";

            switch (instr_name)
            {
                case MOV:
                    {
                        rez = mov(var1, var2);
                        executeText.Text = rez.ToString();
                        return rez;
                    }
                    break;

                default:
                    {
                        while (true)
                        {
                            NOP();
                        }
                    }
                    break;
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            try
            {
                /* local variable used for debugging only */
                int lineCounter = 0;
                /* List which will store each token (element) read from ASM file */
               
                /* Create a parser object used for ASM file
                    REMEMBER: this parser can be used for all kind of text files!!!
                 */
                TextFieldParser parser = new TextFieldParser(filename);
                /* Reinitialize the Text property of OutputTextBox */
                outputText.Text = "";
                /* Define delimiters in ASM file */
                String[] delimiters = { ":", ",", " ", "(", ")" };
                /* Specify that the elements in ASM file are delimited by some characters */
                parser.TextFieldType = FieldType.Delimited;
                /* Set-up the specified delimiters */
                parser.SetDelimiters(delimiters);
                /* Parse the entire ASM file based on previous specifications*/
                while (!parser.EndOfData)
                {
                    /* Read an entire line in ASM file
                       and split this line in many strings delimited by delimiters */
                    string[] asmFields = parser.ReadFields();
                    /* Store each string as a single element in the list
                       if this string is not empty */
                    foreach (string s in asmFields)
                    {
                        if (!s.Equals(""))
                        {
                            asmElements.Add(s);
                        }
                    }
                    /* Counting the number of lines stored in ASM file */
                    lineCounter++;
                }

                /* Close the parser */
                parser.Close();
                /* If the file is empty, trigger a new exception which
                   in turn will display an error message */
                if (lineCounter == 0)
                {
                    Exception exc = new Exception("The ASM file is empty!");
                    throw exc;
                }
                else
                {
                    /* Display every token in OutputTextBox */
                    foreach (String s in asmElements)
                    {
                        outputText.Text += s + Environment.NewLine;
                    }
                    /* Display an information about the process completion */
                    MessageBox.Show("Parsing is completed!", "Assembler information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                /* String used to be displayed in ASMFileTextBox */
                String filename = "";
                /* Reinitialize the Text property of OutputTextBox */
                outputText.Text = "";
                /* Take the filename selected by user */
                filename = getFileName("ASM file for didactical processor(*.asm)|*.asm");
                /* Display the filename in ASMFileTextBox */
                asmText.Text = filename != null ? filename : asmText.Text;
                /* Enable/Disable the ParseFileButton depending of user choice */
                if (!filename.Equals(""))
                {
                    btnParse.Enabled = true;
                }
                else
                {
                    btnParse.Enabled = false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void executeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            int poz = 0;

            foreach (string instr_name in asmElements)
            {
                for (int i = 0; i < 10; i++)
                {

                    string val = i.ToString();

                    if (instr_name == val)
                    {
                        registers[poz] = instr_name;
                        poz++;

                        if (poz == registers.Length)
                        {
                            for (int j = registers.Length - 1; j >= 0; j--)
                            {
                                executeText.Text = registers[j];
                            }
                        }
                    }
                }

                if (instr_name == "MOV")
                {
                    Instruction(instr_name);
                }
            }

            for (int j = registers.Length - 1; j >= 0; j--)
            {
                executeText.Text = registers[j] + "\r\n";
            }
        }
    }
}
