using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FMX_ANTIVIRUS_PRO
{
    [DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            TextBox1 = new TextBox();
            ListView1 = new ListView();
            Label1 = new Label();
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            FolderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Button1.Location = new Point(338, 12);
            Button1.Name = "Button1";
            Button1.Size = new Size(102, 29);
            Button1.TabIndex = 0;
            Button1.Text = "SCAN";
            Button1.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(12, 12);
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(320, 29);
            TextBox1.TabIndex = 1;
            // 
            // ListView1
            // 
            ListView1.Location = new Point(12, 57);
            ListView1.Name = "ListView1";
            ListView1.Size = new Size(428, 298);
            ListView1.TabIndex = 2;
            ListView1.UseCompatibleStateImageBehavior = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BorderStyle = BorderStyle.Fixed3D;
            Label1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(21, 375);
            Label1.Name = "Label1";
            Label1.Size = new Size(116, 20);
            Label1.TabIndex = 3;
            Label1.Text = "STATUS NONE";
            // 
            // BackgroundWorker1
            // 
            BackgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // FolderBrowserDialog1
            // 
            FolderBrowserDialog1.SelectedPath = @"D:\Users\LOUIS\Documents";
            FolderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = My.Resources.Resources.images__2___1_;
            ClientSize = new Size(452, 428);
            Controls.Add(Label1);
            Controls.Add(ListView1);
            Controls.Add(TextBox1);
            Controls.Add(Button1);
            Name = "Form1";
            Text = "Form1";
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Button Button1;
        internal TextBox TextBox1;
        internal ListView ListView1;
        internal Label Label1;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal FolderBrowserDialog FolderBrowserDialog1;
    }
}