namespace StreamerAddon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxInputDrawDist = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLoadMap = new System.Windows.Forms.Button();
            this.buttonDynamicObj = new System.Windows.Forms.Button();
            this.labelMapFile = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonCopy = new System.Windows.Forms.Button();
            this.timerStyle = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBoxInputDrawDist
            // 
            this.textBoxInputDrawDist.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxInputDrawDist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInputDrawDist.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputDrawDist.Location = new System.Drawing.Point(373, 251);
            this.textBoxInputDrawDist.MaxLength = 10;
            this.textBoxInputDrawDist.Name = "textBoxInputDrawDist";
            this.textBoxInputDrawDist.Size = new System.Drawing.Size(83, 22);
            this.textBoxInputDrawDist.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxInputDrawDist, "Input Draw Distance\r\n(Max 300.0f)");
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(444, 208);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Draw Distance";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "___________________________________________________________________________";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Green;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(90, 286);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(60, 27);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.toolTip1.SetToolTip(this.buttonSave, "Save draw distance to all objects into file,\r\nput Draw Distance to 0.0 if you wan" +
        "t to save only converted objects.");
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(438, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "X";
            this.toolTip1.SetToolTip(this.button2, "Exit");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(412, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 27);
            this.button3.TabIndex = 6;
            this.button3.Text = "_";
            this.toolTip1.SetToolTip(this.button3, "Minimize Window");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "StreamerAddon";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // buttonLoadMap
            // 
            this.buttonLoadMap.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonLoadMap.FlatAppearance.BorderSize = 0;
            this.buttonLoadMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadMap.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadMap.ForeColor = System.Drawing.Color.White;
            this.buttonLoadMap.Location = new System.Drawing.Point(12, 286);
            this.buttonLoadMap.Name = "buttonLoadMap";
            this.buttonLoadMap.Size = new System.Drawing.Size(73, 27);
            this.buttonLoadMap.TabIndex = 8;
            this.buttonLoadMap.Text = "Load Map";
            this.toolTip1.SetToolTip(this.buttonLoadMap, "Load objects code from .txt or .pwn file");
            this.buttonLoadMap.UseVisualStyleBackColor = false;
            this.buttonLoadMap.Click += new System.EventHandler(this.buttonLoadMap_Click);
            // 
            // buttonDynamicObj
            // 
            this.buttonDynamicObj.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonDynamicObj.FlatAppearance.BorderSize = 0;
            this.buttonDynamicObj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDynamicObj.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDynamicObj.ForeColor = System.Drawing.Color.White;
            this.buttonDynamicObj.Location = new System.Drawing.Point(297, 286);
            this.buttonDynamicObj.Name = "buttonDynamicObj";
            this.buttonDynamicObj.Size = new System.Drawing.Size(159, 27);
            this.buttonDynamicObj.TabIndex = 12;
            this.buttonDynamicObj.Text = "Convert To Dynamic Object";
            this.toolTip1.SetToolTip(this.buttonDynamicObj, "Converts \'CreateObject\' to \'CreateDynamicObject\'");
            this.buttonDynamicObj.UseVisualStyleBackColor = false;
            this.buttonDynamicObj.Click += new System.EventHandler(this.buttonDynamicObj_Click);
            // 
            // labelMapFile
            // 
            this.labelMapFile.AutoSize = true;
            this.labelMapFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.labelMapFile.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMapFile.ForeColor = System.Drawing.Color.White;
            this.labelMapFile.Location = new System.Drawing.Point(13, 254);
            this.labelMapFile.Name = "labelMapFile";
            this.labelMapFile.Size = new System.Drawing.Size(60, 16);
            this.labelMapFile.TabIndex = 13;
            this.labelMapFile.Text = "Load Map";
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.Teal;
            this.buttonCopy.FlatAppearance.BorderSize = 0;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopy.ForeColor = System.Drawing.Color.White;
            this.buttonCopy.Location = new System.Drawing.Point(238, 286);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(53, 27);
            this.buttonCopy.TabIndex = 14;
            this.buttonCopy.Text = "Copy";
            this.toolTip1.SetToolTip(this.buttonCopy, "Copy all object into clipboard");
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // timerStyle
            // 
            this.timerStyle.Interval = 75;
            this.timerStyle.Tick += new System.EventHandler(this.timerStyle_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(468, 322);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.labelMapFile);
            this.Controls.Add(this.buttonDynamicObj);
            this.Controls.Add(this.buttonLoadMap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxInputDrawDist);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SA:MP Plugin streamer addon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputDrawDist;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLoadMap;
        private System.Windows.Forms.Button buttonDynamicObj;
        private System.Windows.Forms.Label labelMapFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timerStyle;
        private System.Windows.Forms.Button buttonCopy;
    }
}

