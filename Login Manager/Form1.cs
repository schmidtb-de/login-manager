using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Manager
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            string subfolder = System.IO.Path.Combine(Application.StartupPath, "Stundeneingabe");
            System.IO.Directory.CreateDirectory(subfolder);
            string subfoldersave = System.IO.Path.Combine(subfolder, "save");
            System.IO.Directory.CreateDirectory(subfoldersave);
            string sinoxpfadsave = subfoldersave + "\\SINOxPfad.txt";
            if (System.IO.File.Exists(sinoxpfadsave))
            {
                txtSinoxPfad.Text = System.IO.File.ReadAllText(sinoxpfadsave);
                txtSinoxPfad.Enabled = false;
            }


            System.IO.DirectoryInfo ParentDirectory = new System.IO.DirectoryInfo(subfolder);

            foreach (System.IO.FileInfo f in ParentDirectory.GetFiles())
            {
                string woextension = Path.GetFileNameWithoutExtension(f.Name);
                string User = (woextension.Substring(0, 8));
                string Group = (woextension.Substring(8));

                if (Group == "Mergner")
                {
                    listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[0]));
                }

                if (Group == "Partheymüller")
                {
                    listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[1]));
                }
                if (Group == "Brüssow")
                {
                    listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[2]));
                }
                if (Group == "Hiller")
                {
                    listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[3]));
                }
                if (Group == "Höppel")
                {
                    listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[4]));
                }
                if (Group == "Knippert")
                {
                    listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[5]));
                }
                if (Group == "Schubert")
                {
                    listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[6]));
                }
                if (Group == "Kuhlmann")
                {
                    listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[7]));
                }
                if (Group == "Eber")
                {
                    listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[8]));
                }
                if (Group == "Wenck")
                {
                    listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[9]));
                }
                if (Group == "Springer")
                {
                    listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[10]));
                }


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNeuerLogin_Click(object sender, EventArgs e)
        {
            if (txtBenutzername.Text == "" & txtPasswort.Text == "")
            {
                buttonNeuerLogin.Enabled = false;
            }


            string SinoxPfad = "shell.run \"\"\"" + txtSinoxPfad.Text + "\"\"\"\n";
            string Benutzer = "shell.SendKeys \"" + txtBenutzername.Text + "\"\n";
            string Passwort = "shell.SendKeys \"" + txtPasswort.Text + "\"\n";
            string Pfad = AppDomain.CurrentDomain.BaseDirectory + txtBenutzername + ".vbs";
            string[] lines = { "Public Function WaitForWindow(WindowTitle)\n",
"Set WshShell = WScript.CreateObject(\"WScript.Shell\")\n", 
"success=0\n",
"I = 0\n",
"Do\n",
"I = I + 1\n",
"WScript.Sleep 300\n",
"success=WshShell.AppActivate(WindowTitle)\n",
"If I = 50 Then\n",
"x=MsgBox (\"Fenster \"+Chr(34)& WindowTitle &Chr(34)+\" konnte nicht gefunden werden.\",48,\"Warnmeldung\")\n",
"WaitForWindow = False\n",
"asyncConnection.Disconnect(2)\n",
"WScript.quit\n",
"Exit Do\n",
"End If\n",
"Loop Until success\n",
"If success Then\n",
"WaitForWindow = True\n",
"End If\n",
"End Function\n",
"'Deklaration\n",
"set shell = CreateObject(\"WScript.Shell\")\n",
"'Ausführen des Programmes\n",
SinoxPfad,
"WScript.Sleep 500\n",
"shell.AppActivate \"SINOx-Info\"\n",
"'Tastendruck simulieren\n",
"WaitForWindow(\"Anmelden\")\n",
"WScript.Sleep 100\n",
Benutzer,
"WScript.Sleep 100\n",
"shell.SendKeys \"{TAB}\"\n",
Passwort,
"WScript.Sleep 100\n",
"shell.SendKeys \"{ENTER}\"\n",
"WaitForWindow(\"SQL Server Login\")\n",
"WScript.Sleep 100\n",
"shell.SendKeys \"{TAB}\"\n",
"WScript.Sleep 100\n",
Benutzer,
"WScript.Sleep 100\n",
"shell.SendKeys \"{TAB}\"\n",
"WScript.Sleep 100\n",
Passwort,
"WScript.Sleep 100\n",
"shell.SendKeys \"{TAB}\"\n", 
"WScript.Sleep 100\n",
"shell.SendKeys \"{ENTER}\"\n",
"WaitForWindow(\"Anmelden\")\n",
"WScript.Sleep 100\n",
Benutzer,
"WScript.Sleep 100\n",
"shell.SendKeys \"{TAB}\"\n",
"WScript.Sleep 100\n",
Passwort,
"WScript.Sleep 100\n",
"shell.SendKeys \"{ENTER}\"\n",
"WaitForWindow(\"SQL Server Login\")\n",
"WScript.Sleep 100\n",
"shell.SendKeys \"{TAB}\"\n",
"WScript.Sleep 100\n",
Benutzer,
"WScript.Sleep 100\n",
"shell.SendKeys \"{TAB}\"\n",
"WScript.Sleep 100\n",
Passwort,
"WScript.Sleep 100\n",
"shell.SendKeys \"{TAB}\"\n", 
"WScript.Sleep 100\n",
"shell.SendKeys \"{ENTER}\"\n",
"WScript.Sleep 5000\n",
Passwort,
"WScript.Sleep 100\n",
"shell.SendKeys \"{ENTER}\"\n",
"WaitForWindow(\"SQL Server Login\")\n",
"WScript.Sleep 100\n",
"shell.SendKeys \"{TAB}\"",
"WScript.Sleep 100",
Benutzer,
"WScript.Sleep 100",
"shell.SendKeys \"{TAB}\"",
"WScript.Sleep 100",
Passwort,
"WScript.Sleep 100",
"shell.SendKeys \"{TAB}\"", 
"WScript.Sleep 100",
"shell.SendKeys \"{ENTER}\"",


"WScript.Sleep 1500",
"shell.SendKeys \"{TAB}\"",
"shell.SendKeys \"{RIGHT}\"",
"shell.SendKeys \"{RIGHT}\"",
"shell.SendKeys \" \"",
                            
                             };


            if (txtBenutzername.Text.Length == 8)
            {
                string subfolder = System.IO.Path.Combine(Application.StartupPath, "Stundeneingabe");
                System.IO.Directory.CreateDirectory(subfolder);
                string pathsave = subfolder + "\\" + txtBenutzername.Text + coBoSchicht.SelectedItem.ToString() + ".vbs";
                System.IO.File.WriteAllLines(pathsave, lines);
                string subfoldersave = System.IO.Path.Combine(subfolder, "save");
                System.IO.Directory.CreateDirectory(subfoldersave);
                string sinoxpfadsave = subfoldersave + "\\SINOxPfad.txt";
                System.IO.File.WriteAllText(sinoxpfadsave, txtSinoxPfad.Text);
                txtSinoxPfad.Enabled = false;

                txtBenutzername.Text = "";
                txtPasswort.Text = "";
                listView1.Items.Clear();
                System.IO.DirectoryInfo ParentDirectory = new System.IO.DirectoryInfo(subfolder);

                foreach (System.IO.FileInfo f in ParentDirectory.GetFiles())
                {
                    string woextension = Path.GetFileNameWithoutExtension(f.Name);
                    string User = (woextension.Substring(0, 8));
                    string Group = (woextension.Substring(8));

                    if (Group == "Mergner")
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[0]));
                    }

                    if (Group == "Partheymüller")
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[1]));
                    }
                    if (Group == "Brüssow")
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[2]));
                    }
                    if (Group == "Hiller")
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[3]));
                    }
                    if (Group == "Höppel")
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[4]));
                    }
                    if (Group == "Knippert")
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[5]));
                    }
                    if (Group == "Schubert")
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[6]));
                    }
                    if (Group == "Kuhlmann")
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[7]));
                    }
                    if (Group == "Eber")
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[8]));
                    }
                    if (Group == "Wenck")
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[9]));
                    }
                    if (Group == "Springer")
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { User }, listView1.Groups[10]));
                    }
                }
            }
            else
            {
                MessageBox.Show("Der Benutzername muss genau 8 Stellen haben!", "Fehler");
            }
        }

        private void txtBenutzername_TextChanged(object sender, EventArgs e)
        {           
            if (txtBenutzername.Text != "" & txtPasswort.Text != "")
            {
                buttonNeuerLogin.Enabled = true;
            }
            else
            {
                buttonNeuerLogin.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonNeuerLogin.Enabled = false;
            coBoPlatz.Items.AddRange(new string[] { "Strecken", "Ofen 4", "Eirich" });
            coBoPlatz.SelectedItem = "Strecken";
            if (coBoPlatz.SelectedItem == "Strecken")
            {
                coBoSchicht.Items.Clear();
                coBoSchicht.Items.AddRange(new string[] { "Mergner", "Partheymüller", "Brüssow", "Springer" });
                coBoSchicht.SelectedItem = "Mergner";
            }
            if (coBoPlatz.SelectedItem == "Ofen 4")
            {
                coBoSchicht.Items.Clear();
                coBoSchicht.Items.AddRange(new string[] { "Hiller", "Höppel", "Knippert", "Schubert", "Springer" });
                coBoSchicht.SelectedItem = "Hiller";
            }
            if (coBoPlatz.SelectedItem == "Eirich")
            {
                coBoSchicht.Items.Clear();
                coBoSchicht.Items.AddRange(new string[] { "Kuhlmann", "Wenck", "Eber", "Springer" });
                coBoSchicht.SelectedItem = "Kuhlmann";
            }

        }

        private void coBoPlatz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coBoPlatz.SelectedItem == "Strecken")
            {
                coBoSchicht.Items.Clear();
                coBoSchicht.Items.AddRange(new string[] { "Mergner", "Partheymüller", "Brüssow", "Springer" });
                coBoSchicht.SelectedItem = "Mergner";
            }
            if (coBoPlatz.SelectedItem == "Ofen 4")
            {
                coBoSchicht.Items.Clear();
                coBoSchicht.Items.AddRange(new string[] { "Hiller", "Höppel", "Knippert", "Schubert", "Springer" });
                coBoSchicht.SelectedItem = "Hiller";
            }
            if (coBoPlatz.SelectedItem == "Eirich")
            {
                coBoSchicht.Items.Clear();
                coBoSchicht.Items.AddRange(new string[] { "Kuhlmann", "Wenck", "Eber", "Springer" });
                coBoSchicht.SelectedItem = "Kuhlmann";
            }

        }

        private void txtPasswort_TextChanged(object sender, EventArgs e)
        {        
            if (txtBenutzername.Text != "" & txtPasswort.Text != "")
            {
                buttonNeuerLogin.Enabled = true;
            }
            else
            {
                buttonNeuerLogin.Enabled = false;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string Ausgewählt = listView1.SelectedItems[0].Text + listView1.SelectedItems[0].Group.Name;
            //Create a new subfolder under the current active folder
            string subfolder = System.IO.Path.Combine(Application.StartupPath, "Stundeneingabe");
            // Create the subfolder
            System.IO.Directory.CreateDirectory(subfolder);
            //string pathsave = Application.StartupPath +"\\" + txtBenutzername.Text + ".vbs";
            string pathsave = subfolder + "\\" + Ausgewählt + ".vbs";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.EnableRaisingEvents = false;
            process.StartInfo.FileName = pathsave;
            process.Start();
        }

    }  
    }
