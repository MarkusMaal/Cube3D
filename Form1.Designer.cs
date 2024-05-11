
using SharpGL;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using SharpGL.Version;
using System;

namespace Cube3D
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private OpenGLControl openGLControl;
        private Label label1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Label label2;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private TrackBar trackBar5;
        private TrackBar trackBar6;
        private TrackBar trackBar7;
        private Label label3;
        private TrackBar trackBar8;
        private TrackBar trackBar9;
        private TrackBar trackBar10;
        private Label label4;
        private TrackBar trackBar11;
        private TrackBar trackBar12;
        private TrackBar trackBar13;
        private Label label5;
        private TrackBar trackBar14;
        private Label label6;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openGLControl = new SharpGL.OpenGLControl();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.trackBar10 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar11 = new System.Windows.Forms.TrackBar();
            this.trackBar12 = new System.Windows.Forms.TrackBar();
            this.trackBar13 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar14 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.up = new System.Windows.Forms.TabPage();
            this.eyespot = new System.Windows.Forms.TabPage();
            this.center = new System.Windows.Forms.TabPage();
            this.rot = new System.Windows.Forms.TabPage();
            this.colors = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.changeA = new System.Windows.Forms.Button();
            this.changeB = new System.Windows.Forms.Button();
            this.changeC = new System.Windows.Forms.Button();
            this.changeD = new System.Windows.Forms.Button();
            this.changeE = new System.Windows.Forms.Button();
            this.changeF = new System.Windows.Forms.Button();
            this.dims = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar15 = new System.Windows.Forms.TrackBar();
            this.shape = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.restoreButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.verticeCountLabel = new System.Windows.Forms.Label();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.discardButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.vertexZdisplay = new System.Windows.Forms.Label();
            this.vertexZ = new System.Windows.Forms.TrackBar();
            this.vertexYdisplay = new System.Windows.Forms.Label();
            this.vertexY = new System.Windows.Forms.TrackBar();
            this.vertexXdisplay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vertexX = new System.Windows.Forms.TrackBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.joypad = new System.Windows.Forms.TabPage();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.misc = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.shifter = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.keydownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar14)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.up.SuspendLayout();
            this.eyespot.SuspendLayout();
            this.center.SuspendLayout();
            this.rot.SuspendLayout();
            this.colors.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.dims.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar15)).BeginInit();
            this.shape.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vertexZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexX)).BeginInit();
            this.joypad.SuspendLayout();
            this.misc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openGLControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl.DrawFPS = true;
            this.openGLControl.FrameRate = 60;
            this.openGLControl.Location = new System.Drawing.Point(0, 0);
            this.openGLControl.Margin = new System.Windows.Forms.Padding(5);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(1183, 686);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.Click += new System.EventHandler(this.openGLControl_Click);
            this.openGLControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.openGLControl_KeyDown);
            this.openGLControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.openGLControl_KeyUp);
            this.openGLControl.MouseLeave += new System.EventHandler(this.openGLControl_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "FOV: 60";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar1.Location = new System.Drawing.Point(7, 41);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 120;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(162, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 60;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar2.Location = new System.Drawing.Point(4, 44);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar2.Maximum = 3000;
            this.trackBar2.Minimum = -3000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(162, 45);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Value = -5;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eye: x=-5, y=5, z=-1";
            // 
            // trackBar3
            // 
            this.trackBar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar3.Location = new System.Drawing.Point(174, 44);
            this.trackBar3.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar3.Maximum = 3000;
            this.trackBar3.Minimum = -3000;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(162, 45);
            this.trackBar3.TabIndex = 5;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar3.Value = 5;
            this.trackBar3.ValueChanged += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar4.Location = new System.Drawing.Point(343, 44);
            this.trackBar4.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar4.Maximum = 3000;
            this.trackBar4.Minimum = -3000;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(162, 45);
            this.trackBar4.TabIndex = 6;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar4.Value = 1;
            this.trackBar4.ValueChanged += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBar5
            // 
            this.trackBar5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar5.Location = new System.Drawing.Point(342, 39);
            this.trackBar5.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar5.Maximum = 3000;
            this.trackBar5.Minimum = -3000;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(162, 45);
            this.trackBar5.TabIndex = 10;
            this.trackBar5.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar5.ValueChanged += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // trackBar6
            // 
            this.trackBar6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar6.Location = new System.Drawing.Point(173, 39);
            this.trackBar6.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar6.Maximum = 3000;
            this.trackBar6.Minimum = -3000;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(162, 45);
            this.trackBar6.TabIndex = 9;
            this.trackBar6.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar6.ValueChanged += new System.EventHandler(this.trackBar6_Scroll);
            // 
            // trackBar7
            // 
            this.trackBar7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar7.Location = new System.Drawing.Point(4, 39);
            this.trackBar7.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar7.Maximum = 3000;
            this.trackBar7.Minimum = -3000;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(162, 45);
            this.trackBar7.TabIndex = 8;
            this.trackBar7.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar7.Scroll += new System.EventHandler(this.trackBar7_Scroll_1);
            this.trackBar7.ValueChanged += new System.EventHandler(this.trackBar7_Scroll);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Center: x=0, y=0, z=0";
            // 
            // trackBar8
            // 
            this.trackBar8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar8.Location = new System.Drawing.Point(354, 43);
            this.trackBar8.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar8.Maximum = 210;
            this.trackBar8.Minimum = -210;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(158, 45);
            this.trackBar8.TabIndex = 14;
            this.trackBar8.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar8.ValueChanged += new System.EventHandler(this.trackBar8_Scroll);
            // 
            // trackBar9
            // 
            this.trackBar9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar9.Location = new System.Drawing.Point(180, 43);
            this.trackBar9.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar9.Maximum = 210;
            this.trackBar9.Minimum = -210;
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Size = new System.Drawing.Size(162, 45);
            this.trackBar9.TabIndex = 13;
            this.trackBar9.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar9.Value = 1;
            this.trackBar9.ValueChanged += new System.EventHandler(this.trackBar9_Scroll);
            // 
            // trackBar10
            // 
            this.trackBar10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar10.Location = new System.Drawing.Point(11, 43);
            this.trackBar10.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar10.Maximum = 210;
            this.trackBar10.Minimum = -210;
            this.trackBar10.Name = "trackBar10";
            this.trackBar10.Size = new System.Drawing.Size(162, 45);
            this.trackBar10.TabIndex = 12;
            this.trackBar10.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar10.Value = 1;
            this.trackBar10.ValueChanged += new System.EventHandler(this.trackBar10_Scroll);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Up: x=1, y=1, z=0";
            // 
            // trackBar11
            // 
            this.trackBar11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar11.Location = new System.Drawing.Point(351, 41);
            this.trackBar11.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar11.Maximum = 36000;
            this.trackBar11.Minimum = -36000;
            this.trackBar11.Name = "trackBar11";
            this.trackBar11.Size = new System.Drawing.Size(158, 45);
            this.trackBar11.TabIndex = 18;
            this.trackBar11.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar11.Value = 1;
            this.trackBar11.ValueChanged += new System.EventHandler(this.trackBar11_ValueChanged);
            // 
            // trackBar12
            // 
            this.trackBar12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar12.Location = new System.Drawing.Point(177, 41);
            this.trackBar12.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar12.Maximum = 36000;
            this.trackBar12.Minimum = -36000;
            this.trackBar12.Name = "trackBar12";
            this.trackBar12.Size = new System.Drawing.Size(162, 45);
            this.trackBar12.TabIndex = 17;
            this.trackBar12.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar12.Value = 1;
            this.trackBar12.ValueChanged += new System.EventHandler(this.trackBar12_ValueChanged);
            // 
            // trackBar13
            // 
            this.trackBar13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar13.Location = new System.Drawing.Point(8, 41);
            this.trackBar13.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar13.Maximum = 36000;
            this.trackBar13.Minimum = -36000;
            this.trackBar13.Name = "trackBar13";
            this.trackBar13.Size = new System.Drawing.Size(162, 45);
            this.trackBar13.TabIndex = 16;
            this.trackBar13.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar13.Value = 1;
            this.trackBar13.ValueChanged += new System.EventHandler(this.trackBar13_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Rotation: x=1, y=1, z=1";
            // 
            // trackBar14
            // 
            this.trackBar14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar14.LargeChange = 10;
            this.trackBar14.Location = new System.Drawing.Point(177, 40);
            this.trackBar14.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar14.Maximum = 500;
            this.trackBar14.Minimum = -500;
            this.trackBar14.Name = "trackBar14";
            this.trackBar14.Size = new System.Drawing.Size(158, 45);
            this.trackBar14.TabIndex = 20;
            this.trackBar14.TickFrequency = 2;
            this.trackBar14.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar14.Scroll += new System.EventHandler(this.trackBar14_Scroll);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Speed: 0x";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.up);
            this.tabControl1.Controls.Add(this.eyespot);
            this.tabControl1.Controls.Add(this.center);
            this.tabControl1.Controls.Add(this.rot);
            this.tabControl1.Controls.Add(this.colors);
            this.tabControl1.Controls.Add(this.dims);
            this.tabControl1.Controls.Add(this.shape);
            this.tabControl1.Controls.Add(this.joypad);
            this.tabControl1.Controls.Add(this.misc);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 567);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1183, 119);
            this.tabControl1.TabIndex = 21;
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.Black;
            this.up.Controls.Add(this.label4);
            this.up.Controls.Add(this.trackBar10);
            this.up.Controls.Add(this.trackBar9);
            this.up.Controls.Add(this.trackBar8);
            this.up.Location = new System.Drawing.Point(4, 25);
            this.up.Name = "up";
            this.up.Padding = new System.Windows.Forms.Padding(3);
            this.up.Size = new System.Drawing.Size(1175, 90);
            this.up.TabIndex = 0;
            this.up.Text = "Up";
            // 
            // eyespot
            // 
            this.eyespot.BackColor = System.Drawing.Color.Black;
            this.eyespot.Controls.Add(this.label2);
            this.eyespot.Controls.Add(this.trackBar2);
            this.eyespot.Controls.Add(this.trackBar3);
            this.eyespot.Controls.Add(this.trackBar4);
            this.eyespot.Location = new System.Drawing.Point(4, 25);
            this.eyespot.Name = "eyespot";
            this.eyespot.Size = new System.Drawing.Size(1175, 90);
            this.eyespot.TabIndex = 2;
            this.eyespot.Text = "Eye";
            // 
            // center
            // 
            this.center.BackColor = System.Drawing.Color.Black;
            this.center.Controls.Add(this.label3);
            this.center.Controls.Add(this.trackBar7);
            this.center.Controls.Add(this.trackBar6);
            this.center.Controls.Add(this.trackBar5);
            this.center.Location = new System.Drawing.Point(4, 25);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(1175, 90);
            this.center.TabIndex = 3;
            this.center.Text = "Center";
            // 
            // rot
            // 
            this.rot.BackColor = System.Drawing.Color.Black;
            this.rot.Controls.Add(this.label5);
            this.rot.Controls.Add(this.trackBar13);
            this.rot.Controls.Add(this.trackBar12);
            this.rot.Controls.Add(this.trackBar11);
            this.rot.Location = new System.Drawing.Point(4, 25);
            this.rot.Name = "rot";
            this.rot.Size = new System.Drawing.Size(1175, 90);
            this.rot.TabIndex = 4;
            this.rot.Text = "Rotation";
            // 
            // colors
            // 
            this.colors.BackColor = System.Drawing.Color.Black;
            this.colors.Controls.Add(this.checkBox3);
            this.colors.Controls.Add(this.button3);
            this.colors.Controls.Add(this.button2);
            this.colors.Controls.Add(this.flowLayoutPanel1);
            this.colors.Location = new System.Drawing.Point(4, 25);
            this.colors.Name = "colors";
            this.colors.Size = new System.Drawing.Size(1175, 90);
            this.colors.TabIndex = 5;
            this.colors.Text = "Colors";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(326, 18);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(50, 20);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Shift";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(764, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Random";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(764, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanel1.Controls.Add(this.changeA);
            this.flowLayoutPanel1.Controls.Add(this.changeB);
            this.flowLayoutPanel1.Controls.Add(this.changeC);
            this.flowLayoutPanel1.Controls.Add(this.changeD);
            this.flowLayoutPanel1.Controls.Add(this.changeE);
            this.flowLayoutPanel1.Controls.Add(this.changeF);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(382, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(376, 63);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // changeA
            // 
            this.changeA.BackColor = System.Drawing.Color.Lime;
            this.changeA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeA.Location = new System.Drawing.Point(3, 3);
            this.changeA.Name = "changeA";
            this.changeA.Size = new System.Drawing.Size(55, 55);
            this.changeA.TabIndex = 1;
            this.changeA.UseVisualStyleBackColor = false;
            this.changeA.Click += new System.EventHandler(this.changeA_Click);
            // 
            // changeB
            // 
            this.changeB.BackColor = System.Drawing.Color.Yellow;
            this.changeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeB.Location = new System.Drawing.Point(64, 3);
            this.changeB.Name = "changeB";
            this.changeB.Size = new System.Drawing.Size(55, 55);
            this.changeB.TabIndex = 2;
            this.changeB.UseVisualStyleBackColor = false;
            this.changeB.Click += new System.EventHandler(this.changeB_Click);
            // 
            // changeC
            // 
            this.changeC.BackColor = System.Drawing.Color.Aqua;
            this.changeC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeC.Location = new System.Drawing.Point(125, 3);
            this.changeC.Name = "changeC";
            this.changeC.Size = new System.Drawing.Size(55, 55);
            this.changeC.TabIndex = 3;
            this.changeC.UseVisualStyleBackColor = false;
            this.changeC.Click += new System.EventHandler(this.changeC_Click);
            // 
            // changeD
            // 
            this.changeD.BackColor = System.Drawing.Color.Fuchsia;
            this.changeD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeD.Location = new System.Drawing.Point(186, 3);
            this.changeD.Name = "changeD";
            this.changeD.Size = new System.Drawing.Size(55, 55);
            this.changeD.TabIndex = 4;
            this.changeD.UseVisualStyleBackColor = false;
            this.changeD.Click += new System.EventHandler(this.changeD_Click);
            // 
            // changeE
            // 
            this.changeE.BackColor = System.Drawing.Color.Red;
            this.changeE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeE.Location = new System.Drawing.Point(247, 3);
            this.changeE.Name = "changeE";
            this.changeE.Size = new System.Drawing.Size(55, 55);
            this.changeE.TabIndex = 5;
            this.changeE.UseVisualStyleBackColor = false;
            this.changeE.Click += new System.EventHandler(this.changeE_Click);
            // 
            // changeF
            // 
            this.changeF.BackColor = System.Drawing.Color.Blue;
            this.changeF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeF.Location = new System.Drawing.Point(308, 3);
            this.changeF.Name = "changeF";
            this.changeF.Size = new System.Drawing.Size(55, 55);
            this.changeF.TabIndex = 6;
            this.changeF.UseVisualStyleBackColor = false;
            this.changeF.Click += new System.EventHandler(this.changeF_Click);
            // 
            // dims
            // 
            this.dims.BackColor = System.Drawing.Color.Black;
            this.dims.Controls.Add(this.label7);
            this.dims.Controls.Add(this.trackBar15);
            this.dims.Location = new System.Drawing.Point(4, 25);
            this.dims.Name = "dims";
            this.dims.Size = new System.Drawing.Size(1175, 90);
            this.dims.TabIndex = 6;
            this.dims.Text = "Dimensions";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Size multiplier: 1x";
            // 
            // trackBar15
            // 
            this.trackBar15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar15.Location = new System.Drawing.Point(25, 33);
            this.trackBar15.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar15.Maximum = 50000;
            this.trackBar15.Name = "trackBar15";
            this.trackBar15.Size = new System.Drawing.Size(1117, 45);
            this.trackBar15.TabIndex = 14;
            this.trackBar15.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar15.Value = 1;
            this.trackBar15.ValueChanged += new System.EventHandler(this.trackBar15_Scroll);
            // 
            // shape
            // 
            this.shape.BackColor = System.Drawing.Color.Black;
            this.shape.Controls.Add(this.button6);
            this.shape.Controls.Add(this.flowLayoutPanel2);
            this.shape.Controls.Add(this.verticeCountLabel);
            this.shape.Controls.Add(this.minusButton);
            this.shape.Controls.Add(this.plusButton);
            this.shape.Controls.Add(this.discardButton);
            this.shape.Controls.Add(this.applyButton);
            this.shape.Controls.Add(this.comboBox1);
            this.shape.Controls.Add(this.label12);
            this.shape.Controls.Add(this.vertexZdisplay);
            this.shape.Controls.Add(this.vertexZ);
            this.shape.Controls.Add(this.vertexYdisplay);
            this.shape.Controls.Add(this.vertexY);
            this.shape.Controls.Add(this.vertexXdisplay);
            this.shape.Controls.Add(this.label8);
            this.shape.Controls.Add(this.vertexX);
            this.shape.Controls.Add(this.listBox1);
            this.shape.Location = new System.Drawing.Point(4, 25);
            this.shape.Name = "shape";
            this.shape.Size = new System.Drawing.Size(1175, 90);
            this.shape.TabIndex = 7;
            this.shape.Text = "Verticies";
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(608, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 30);
            this.button6.TabIndex = 17;
            this.button6.Text = "Copy vertices";
            this.toolTip1.SetToolTip(this.button6, "Forgets any changes made to selected vertex.");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.restoreButton);
            this.flowLayoutPanel2.Controls.Add(this.button4);
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Controls.Add(this.button7);
            this.flowLayoutPanel2.Controls.Add(this.button8);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(703, 48);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(464, 35);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // restoreButton
            // 
            this.restoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreButton.Location = new System.Drawing.Point(3, 3);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(56, 30);
            this.restoreButton.TabIndex = 13;
            this.restoreButton.Text = "Cube";
            this.toolTip1.SetToolTip(this.restoreButton, "Restore default vertices for the default 3D cube shape.");
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(65, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 30);
            this.button4.TabIndex = 14;
            this.button4.Text = "Trapese prism";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(174, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 30);
            this.button5.TabIndex = 15;
            this.button5.Text = "Cuboid";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(241, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 30);
            this.button7.TabIndex = 16;
            this.button7.Text = "Pyramid";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(308, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 30);
            this.button8.TabIndex = 17;
            this.button8.Text = "Markus\' stuff logo";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // verticeCountLabel
            // 
            this.verticeCountLabel.AutoSize = true;
            this.verticeCountLabel.Location = new System.Drawing.Point(703, 12);
            this.verticeCountLabel.Name = "verticeCountLabel";
            this.verticeCountLabel.Size = new System.Drawing.Size(154, 16);
            this.verticeCountLabel.TabIndex = 15;
            this.verticeCountLabel.Text = "Total number of verticies: 24";
            // 
            // minusButton
            // 
            this.minusButton.Enabled = false;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Location = new System.Drawing.Point(655, 48);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(42, 30);
            this.minusButton.TabIndex = 14;
            this.minusButton.Text = "-";
            this.toolTip1.SetToolTip(this.minusButton, "Delete selected vertex");
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Enabled = false;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Location = new System.Drawing.Point(608, 48);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(41, 30);
            this.plusButton.TabIndex = 12;
            this.plusButton.Text = "+";
            this.toolTip1.SetToolTip(this.plusButton, "Add a vertex based on these settings");
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // discardButton
            // 
            this.discardButton.Enabled = false;
            this.discardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discardButton.Location = new System.Drawing.Point(527, 12);
            this.discardButton.Name = "discardButton";
            this.discardButton.Size = new System.Drawing.Size(75, 30);
            this.discardButton.TabIndex = 11;
            this.discardButton.Text = "Discard";
            this.toolTip1.SetToolTip(this.discardButton, "Forgets any changes made to selected vertex.");
            this.discardButton.UseVisualStyleBackColor = true;
            this.discardButton.Click += new System.EventHandler(this.discardButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.Location = new System.Drawing.Point(527, 48);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 30);
            this.applyButton.TabIndex = 10;
            this.applyButton.Text = "Apply";
            this.toolTip1.SetToolTip(this.applyButton, "Add these changes to the selected vertex and apply it to the shape immediately.");
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.comboBox1.Location = new System.Drawing.Point(469, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(469, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Color";
            // 
            // vertexZdisplay
            // 
            this.vertexZdisplay.Location = new System.Drawing.Point(359, 19);
            this.vertexZdisplay.Name = "vertexZdisplay";
            this.vertexZdisplay.Size = new System.Drawing.Size(100, 23);
            this.vertexZdisplay.TabIndex = 7;
            this.vertexZdisplay.Text = "Z = 0";
            // 
            // vertexZ
            // 
            this.vertexZ.Enabled = false;
            this.vertexZ.Location = new System.Drawing.Point(359, 38);
            this.vertexZ.Maximum = 100;
            this.vertexZ.Minimum = -100;
            this.vertexZ.Name = "vertexZ";
            this.vertexZ.Size = new System.Drawing.Size(104, 45);
            this.vertexZ.TabIndex = 6;
            this.vertexZ.TickFrequency = 12;
            this.vertexZ.ValueChanged += new System.EventHandler(this.vertexZ_ValueChanged);
            // 
            // vertexYdisplay
            // 
            this.vertexYdisplay.Location = new System.Drawing.Point(249, 19);
            this.vertexYdisplay.Name = "vertexYdisplay";
            this.vertexYdisplay.Size = new System.Drawing.Size(100, 23);
            this.vertexYdisplay.TabIndex = 5;
            this.vertexYdisplay.Text = "Y = 0";
            // 
            // vertexY
            // 
            this.vertexY.Enabled = false;
            this.vertexY.Location = new System.Drawing.Point(249, 38);
            this.vertexY.Maximum = 100;
            this.vertexY.Minimum = -100;
            this.vertexY.Name = "vertexY";
            this.vertexY.Size = new System.Drawing.Size(104, 45);
            this.vertexY.TabIndex = 4;
            this.vertexY.TickFrequency = 12;
            this.vertexY.ValueChanged += new System.EventHandler(this.vertexY_ValueChanged);
            // 
            // vertexXdisplay
            // 
            this.vertexXdisplay.Location = new System.Drawing.Point(139, 19);
            this.vertexXdisplay.Name = "vertexXdisplay";
            this.vertexXdisplay.Size = new System.Drawing.Size(100, 23);
            this.vertexXdisplay.TabIndex = 3;
            this.vertexXdisplay.Text = "X = 0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Select vertex from the list!";
            // 
            // vertexX
            // 
            this.vertexX.Enabled = false;
            this.vertexX.Location = new System.Drawing.Point(139, 38);
            this.vertexX.Maximum = 100;
            this.vertexX.Minimum = -100;
            this.vertexX.Name = "vertexX";
            this.vertexX.Size = new System.Drawing.Size(104, 45);
            this.vertexX.TabIndex = 1;
            this.vertexX.TickFrequency = 12;
            this.vertexX.ValueChanged += new System.EventHandler(this.vertexX_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "0,1,-0.5,A",
            "0,0,-0.5,A",
            "1,0,-0.5,A",
            "1,1,-0.5,A",
            "0,1,0.5,B",
            "0,0,0.5,B",
            "1,0,0.5,B",
            "1,1,0.5,B",
            "0,0,0.5,C",
            "0,0,-0.5,C",
            "1,0,-0.5,C",
            "1,0,0.5,C",
            "0,1,0.5,D",
            "0,1,-0.5,D",
            "1,1,-0.5,D",
            "1,1,0.5,D",
            "0,1,0.5,E",
            "0,1,-0.5,E",
            "0,0,-0.5,E",
            "0,0,0.5,E",
            "1,1,0.5,F",
            "1,1,-0.5,F",
            "1,0,-0.5,F",
            "1,0,0.5,F"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 90);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // joypad
            // 
            this.joypad.BackColor = System.Drawing.Color.Black;
            this.joypad.Controls.Add(this.checkBox4);
            this.joypad.Controls.Add(this.button16);
            this.joypad.Controls.Add(this.button15);
            this.joypad.Controls.Add(this.button14);
            this.joypad.Controls.Add(this.button13);
            this.joypad.Controls.Add(this.button12);
            this.joypad.Controls.Add(this.button11);
            this.joypad.Controls.Add(this.button10);
            this.joypad.Controls.Add(this.button9);
            this.joypad.Location = new System.Drawing.Point(4, 25);
            this.joypad.Name = "joypad";
            this.joypad.Size = new System.Drawing.Size(1175, 90);
            this.joypad.TabIndex = 8;
            this.joypad.Text = "Joystick";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(17, 15);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(61, 20);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Enable";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button16.Enabled = false;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(567, 8);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 32);
            this.button16.TabIndex = 7;
            this.button16.Text = "Up";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button16_KeyDown);
            this.button16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button14_MouseUp);
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button15.Enabled = false;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(405, 8);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 32);
            this.button15.TabIndex = 6;
            this.button15.Text = "Down";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button15_KeyDown);
            this.button15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button14_MouseUp);
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.Enabled = false;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(648, 46);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 32);
            this.button14.TabIndex = 5;
            this.button14.Text = "L. Right";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button14_MouseUp);
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button13.Enabled = false;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(324, 46);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 32);
            this.button13.TabIndex = 4;
            this.button13.Text = "L. Left";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button14_MouseUp);
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.Enabled = false;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(567, 46);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 32);
            this.button12.TabIndex = 3;
            this.button12.Text = "Right";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button12_KeyDown);
            this.button12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button14_MouseUp);
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button11.Enabled = false;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(486, 46);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 32);
            this.button11.TabIndex = 2;
            this.button11.Text = "Backward";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button11_MouseDown);
            this.button11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button14_MouseUp);
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.Enabled = false;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(405, 46);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 32);
            this.button10.TabIndex = 1;
            this.button10.Text = "Left";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button10_KeyDown);
            this.button10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button14_MouseUp);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.Enabled = false;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(486, 8);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 32);
            this.button9.TabIndex = 0;
            this.button9.Text = "Forward";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button9_MouseDown);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button14_MouseUp);
            // 
            // misc
            // 
            this.misc.BackColor = System.Drawing.Color.Black;
            this.misc.Controls.Add(this.button1);
            this.misc.Controls.Add(this.groupBox1);
            this.misc.Controls.Add(this.checkBox2);
            this.misc.Controls.Add(this.checkBox1);
            this.misc.Controls.Add(this.label1);
            this.misc.Controls.Add(this.trackBar14);
            this.misc.Controls.Add(this.trackBar1);
            this.misc.Controls.Add(this.label6);
            this.misc.Location = new System.Drawing.Point(4, 25);
            this.misc.Name = "misc";
            this.misc.Padding = new System.Windows.Forms.Padding(3);
            this.misc.Size = new System.Drawing.Size(1175, 90);
            this.misc.TabIndex = 1;
            this.misc.Text = "Misc";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(356, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Random!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(458, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 89);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open GL version";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 64);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Open GL 3.0";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Open GL 2.1";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Open GL 1.1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(356, 17);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(75, 20);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Draw FPS";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(356, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 20);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Fullscreen";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // shifter
            // 
            this.shifter.Interval = 16;
            this.shifter.Tick += new System.EventHandler(this.shifter_Tick);
            // 
            // keydownTimer
            // 
            this.keydownTimer.Tick += new System.EventHandler(this.keydownTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1183, 686);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.openGLControl);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Open GL 3D Cube 2.0";
            this.Load += new System.EventHandler(this.SharpGLForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar14)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.up.ResumeLayout(false);
            this.up.PerformLayout();
            this.eyespot.ResumeLayout(false);
            this.eyespot.PerformLayout();
            this.center.ResumeLayout(false);
            this.center.PerformLayout();
            this.rot.ResumeLayout(false);
            this.rot.PerformLayout();
            this.colors.ResumeLayout(false);
            this.colors.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.dims.ResumeLayout(false);
            this.dims.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar15)).EndInit();
            this.shape.ResumeLayout(false);
            this.shape.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vertexZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexX)).EndInit();
            this.joypad.ResumeLayout(false);
            this.joypad.PerformLayout();
            this.misc.ResumeLayout(false);
            this.misc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage up;
        private TabPage eyespot;
        private TabPage center;
        private TabPage tabPage5;
        private TabPage misc;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private TabPage colors;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button changeA;
        private Button changeB;
        private Button changeC;
        private Button changeD;
        private Button changeE;
        private Button changeF;
        private ColorDialog colorDialog1;
        private Button button3;
        private Button button2;
        private TabPage dims;
        private Label label7;
        private TrackBar trackBar15;
        private TabPage rot;
        private CheckBox checkBox3;
        private Timer shifter;
        private TabPage shape;
        private Button minusButton;
        private ToolTip toolTip1;
        private Button restoreButton;
        private Button plusButton;
        private Button discardButton;
        private Button applyButton;
        private ComboBox comboBox1;
        private Label label12;
        private Label vertexZdisplay;
        private TrackBar vertexZ;
        private Label vertexYdisplay;
        private TrackBar vertexY;
        private Label vertexXdisplay;
        private Label label8;
        private TrackBar vertexX;
        private ListBox listBox1;
        private Label verticeCountLabel;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TabPage joypad;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Timer keydownTimer;
        private Button button16;
        private Button button15;
        private CheckBox checkBox4;
    }
}

