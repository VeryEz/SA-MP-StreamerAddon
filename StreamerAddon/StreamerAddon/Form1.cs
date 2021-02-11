using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StreamerAddon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool bIsReadyToSave = false;
        private string mappath = null, saveFilee = null;
        //private string[] paramsetde = { "modelid", "x", "y", "z", "rx", "ry", "rz", "0.0" }; //CreateObject(modelid, Float:X, Float:Y, Float:Z, Float:rX, Float:rY, Float:rZ, Float:DrawDistance = 0.0);
        private string[] paramsetdy = {/*"modelid", "x", "y", "z", "rx", "ry", "rz",*/ "-1", "-1", "-1", "300.0", "0.0", "-1", "0" }; //CreateDynamicObject(modelid, Float:x, Float:y, Float:z, Float:rx, Float:ry, Float:rz, worldid = -1, interiorid = -1, playerid = -1, Float:streamdistance = STREAMER_OBJECT_SD, Float:drawdistance = STREAMER_OBJECT_DD, areaid = -1, priority = 0)

        private void ConvertToDynamic()
        {
            if (string.IsNullOrEmpty(mappath))
                return;

            if (File.Exists(mappath) == false)
            {
                MessageBox.Show("Map file doesn't exist anymore!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var obj = File.ReadAllText(mappath);
            {
                if (obj.Contains("CreateObject"))
                {
                    File.WriteAllText(mappath, obj.Replace("CreateObject", "CreateDynamicObject"));
                    listBox1.ResetText();
                    listBox1.DataSource = File.ReadAllLines(mappath);
                }
            }
        }

        #region Movement
        private static Point downPoint = Point.Empty;

        private void ThisForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = new Point(e.X, e.Y);
        }

        private void ThisForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y - downPoint.Y);
        }

        private void ThisForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            if (bIsReadyToSave)
            {
                DialogResult dialog = MessageBox.Show("Unsaved stuff will be lost forever(this won't delete your original map)\nAre you sure you want to quit ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonLoadMap_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Map as Text Files(*.txt)|*.txt*|Map as PWN File(*.pwn)|*.pwn*" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var getfile = openFileDialog.FileName.ToString();
                    mappath = getfile;
                    if (listBox1.Items.Count != 0) listBox1.ResetText();
                    listBox1.DataSource = File.ReadAllLines(getfile);
                    labelMapFile.Text = getfile.Remove(0, getfile.LastIndexOf(@"\") + 1);
                    timerStyle.Start();
                    bIsReadyToSave = true;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count <= 0)
            {
                MessageBox.Show("In order to save you must first load map into this program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(textBoxInputDrawDist.Text))
            {
                MessageBox.Show("Draw distance input box cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToSingle(textBoxInputDrawDist.Text) > 300.0 || Convert.ToSingle(textBoxInputDrawDist.Text) < 0.0)
            {
                MessageBox.Show("Max: 300.0\nMin: 0.0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "Text files(*.txt)|*.txt*|Pawn Files(*.pwn)|*.pwn*" })
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    paramsetdy[4] = textBoxInputDrawDist.Text; //set drawdist. value
                    foreach (string str in listBox1.Items)
                    {
                        if (!str.Contains("CreateDynamicObject"))
                            continue;

                        //save only additional parameters if drawdist. has a proper value 
                        if (Convert.ToSingle(textBoxInputDrawDist.Text) > 0.0)
                        {
                            string getresult = str.Insert(str.LastIndexOf(')'), string.Format(", {0}, {1}, {2}, {3}, {4}, {5}, {6}", paramsetdy[0], paramsetdy[1], paramsetdy[2], paramsetdy[3], paramsetdy[4], paramsetdy[5], paramsetdy[6])) + Environment.NewLine;
                            File.AppendAllText(saveFile.FileName, getresult);
                            saveFilee = saveFile.FileName;
                            bIsReadyToSave = false;
                            //MessageBox.Show("CreateObject must be converted to CreateDynamicObject in order to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else    //save only converted script objects to dynamic
                        {
                            File.AppendAllText(saveFile.FileName, string.Format(str + Environment.NewLine));
                            saveFilee = saveFile.FileName; //set saved file name info so we can use button copy
                            bIsReadyToSave = false;
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxInputDrawDist.Text = paramsetdy[4].ToString();
        }

        private void buttonDynamicObj_Click(object sender, EventArgs e)
        {
            ConvertToDynamic();
        }

        private bool bMove = true;
        private int setpos = 0;
        private void timerStyle_Tick(object sender, EventArgs e)
        {
            if (bMove)
            {
                if (labelMapFile.Location.X != -61)
                {
                    setpos -= 1;
                    labelMapFile.Location = new Point(setpos, 254);
                }
                else bMove = false;
            }
            else
            {
                if (labelMapFile.Location.X != 13)
                {
                    setpos += 1;
                    labelMapFile.Location = new Point(setpos, 254);
                }
                else bMove = true;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(saveFilee))
                return;

            Clipboard.SetText(File.ReadAllText(saveFilee));
        }
    }
}
