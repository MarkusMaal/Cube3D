using SharpGL;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Cube3D
{
    public partial class Form1 : Form
    {
        private float fov = 60.0f;
        private float eyex = -5.0f;
        private float eyey = 5.0f;
        private float eyez = -1.0f;
        private float centerx = 0.0f;
        private float centery = 0.0f;
        private float centerz = 0.0f;
        private float upx = 1.0f;
        private float upy = 1.0f;
        private float upz = 0.0f;
        private float rotx = -1f;
        private float roty = -0f;
        private float rotz = -0f;
        private float rots = 0f;
        private float size = 1f;
        private float rotation = 0f;
        private float[] colorA = { 0.0f, 1.0f, 0.0f };
        private float[] colorB = { 1.0f, 1.0f, 0.0f };
        private float[] colorC = { 0.0f, 1.0f, 1.0f };
        private float[] colorD = { 1.0f, 0.0f, 1.0f };
        private float[] colorE = { 1.0f, 0.0f, 0.0f };
        private float[] colorF = { 0.0f, 0.0f, 1.0f };
        private string joystickKey = "forward";
        private bool use_joystick = false;
        private bool move_mouse = false;
        Camera m_Camera = new Camera();


        public Form1()
        {
            InitializeComponent();
        }

        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs e)
        {
            OpenGL openGl = this.openGLControl.OpenGL;
            openGl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            openGl.LoadIdentity();
            if (!use_joystick)
            {
                openGl.Rotate(this.rotation, this.rotx, this.roty, this.rotz);
            }
            else
            {
                m_Camera.setLook(openGl);
            }
            openGl.PushMatrix();
            openGl.Begin(OpenGL.GL_QUADS);
            foreach (string vertexStr in listBox1.Items)
            {
                string[] vertexArray = vertexStr.Split(",");
                float X = size * (float)Convert.ToDouble(vertexArray[0].Replace(".", ","));
                float Y = size * (float)Convert.ToDouble(vertexArray[1].Replace(".", ","));
                float Z = size * (float)Convert.ToDouble(vertexArray[2].Replace(".", ","));
                float[] color = { 0f, 0f, 0f };
                switch (vertexArray[3])
                {
                    case "A":
                        float[] clr = { colorA[0], colorA[1], colorA[2] };
                        color = clr;
                        break;
                    case "B":
                        float[] clr2 = { colorB[0], colorB[1], colorB[2] };
                        color = clr2;
                        break;
                    case "C":
                        float[] clr3 = { colorC[0], colorC[1], colorC[2] };
                        color = clr3;
                        break;
                    case "D":
                        float[] clr4 = { colorD[0], colorD[1], colorD[2] };
                        color = clr4;
                        break;
                    case "E":
                        float[] clr5 = { colorE[0], colorE[1], colorE[2] };
                        color = clr5;
                        break;
                    case "F":
                        float[] clr6 = { colorF[0], colorF[1], colorF[2] };
                        color = clr6;
                        break;
                }
                openGl.Color(color[0], color[1], color[2]);
                openGl.Vertex(X, Y, Z);
            }
            openGl.End();
            openGl.PopMatrix();
            if (move_mouse)
            {
                m_Camera.setViewByMouse();
            }
            this.rotation += this.rots;
        }

        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.Enable(OpenGL.GL_NORMALIZE);
            gl.ClearColor(0, 0, 0, 0);

            if (use_joystick)
            {
                m_Camera.setCamera(0.0f, 1.5f, 6.0f, 0.0f, 1.5f, 0.0f, 0.0f, 1.0f, 0.0f);
                m_Camera.setSpeed(1f);
            }
        }

        private void openGLControl_Resized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Perspective(60.0f, (double)Width / (double)Height, 0.01, 100.0);
            if (use_joystick)
            {
                gl.LookAt(eyex, eyey, eyez, centerx, centery, centerz, upx, upy, upz);
            } else
            {
                gl.LookAt(eyex, eyey, eyez, centerx, centery, centerz, upx, upy, upz);
            }
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }

        private void SharpGLForm_Load(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.label1.Text = "FOV: " + this.trackBar1.Value.ToString();
            this.fov = (float)this.trackBar1.Value;
            ++this.openGLControl.Width;
            --this.openGLControl.Width;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            this.label2.Text = "Eye: x=" + this.trackBar2.Value.ToString() + ", y=" + this.eyey.ToString() + ", z=" + this.eyez.ToString();
            this.eyex = (float)this.trackBar2.Value / 60.0f;
            ++this.openGLControl.Width;
            --this.openGLControl.Width;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            this.label2.Text = "Eye: x=" + this.eyex.ToString() + ", y=" + this.trackBar3.Value.ToString() + ", z=" + this.eyez.ToString();
            this.eyey = (float)this.trackBar3.Value / 60.0f;
            ++this.openGLControl.Width;
            --this.openGLControl.Width;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            this.label2.Text = "Eye: x=" + this.eyex.ToString() + ", y=" + this.eyey.ToString() + ", z=" + this.trackBar4.Value.ToString();
            this.eyez = (float)this.trackBar4.Value / 60.0f;
            ++this.openGLControl.Width;
            --this.openGLControl.Width;
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            this.centerx = ((float)this.trackBar7.Value / 3000.0f) * 2 * this.size;
            this.label3.Text = "Center: x=" + this.centerx.ToString() + ", y=" + this.centery.ToString() + ", z=" + this.centerz.ToString();
            ++this.openGLControl.Width;
            --this.openGLControl.Width;
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            this.centery = ((float)this.trackBar6.Value / 3000.0f) * 2 * this.size;
            this.label3.Text = "Center: x=" + this.centerx.ToString() + ", y=" + this.centery.ToString() + ", z=" + this.centerz.ToString();
            ++this.openGLControl.Width;
            --this.openGLControl.Width;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            this.centerz = ((float)this.trackBar5.Value / 3000.0f) * 2 * this.size;
            this.label3.Text = "Center: x=" + this.centerx.ToString() + ", y=" + this.centery.ToString() + ", z=" + this.centerz.ToString();
            ++this.openGLControl.Width;
            --this.openGLControl.Width;
        }

        private void trackBar10_Scroll(object sender, EventArgs e)
        {
            this.upx = (float)this.trackBar10.Value / 60.0f;
            this.label4.Text = "Up: x=" + this.upx.ToString() + ", y=" + this.upy.ToString() + ", z=" + this.upz.ToString();
            ++this.openGLControl.Width;
            --this.openGLControl.Width;
        }

        private void trackBar9_Scroll(object sender, EventArgs e)
        {
            this.upy = (float)this.trackBar9.Value / 60.0f;
            this.label4.Text = "Up: x=" + this.upx.ToString() + ", y=" + this.upy.ToString() + ", z=" + this.upz.ToString();
            ++this.openGLControl.Width;
            --this.openGLControl.Width;
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            this.upz = (float)this.trackBar8.Value / 60.0f;
            this.label4.Text = "Up: x=" + this.upx.ToString() + ", y=" + this.upy.ToString() + ", z=" + this.upz.ToString();
            ++this.openGLControl.Width;
            --this.openGLControl.Width;
        }

        private void trackBar14_Scroll(object sender, EventArgs e)
        {
            this.rots = (float)this.trackBar14.Value / 100f;
            this.label6.Text = "Speed: " + this.rots.ToString() + "x";
            ++this.openGLControl.Width;
            --this.openGLControl.Width;
        }

        private void openGLControl_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = !tabControl1.Visible;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                openGLControl.RenderContextType = RenderContextType.FBO;
            } else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                openGLControl.RenderContextType = RenderContextType.DIBSection;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            openGLControl.DrawFPS = checkBox2.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1; }
            openGLControl.Width--;
            openGLControl.Width++;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL1_1; }
            openGLControl.Width--;
            openGLControl.Width++;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) { openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL3_0; }
            openGLControl.Width--;
            openGLControl.Width++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            foreach (TabPage t in tabControl1.TabPages)
            {
                foreach (Control c in t.Controls)
                {
                    if (c is TrackBar bar)
                    {
                        if (!((bar.Name == "trackBar1") || (bar.Name == "trackBar14")))
                        {
                            bar.Value = r.Next(bar.Minimum, bar.Maximum);
                        }
                    }
                }
            }
        }

        private void trackBar11_ValueChanged(object sender, EventArgs e)
        {
            this.rotz = (float)this.trackBar11.Value / 100f;
            this.label5.Text = "Rotation: x=" + this.rotx.ToString() + ", y=" + this.roty.ToString() + ", z=" + this.rotz.ToString();
            ++this.openGLControl.Width;
            --this.openGLControl.Width;
        }

        private void trackBar12_ValueChanged(object sender, EventArgs e)
        {
            this.roty = (float)this.trackBar12.Value / 100f;
            this.label5.Text = "Rotation: x=" + this.rotx.ToString() + ", y=" + this.roty.ToString() + ", z=" + this.rotz.ToString();
            ++this.openGLControl.Width;
            --this.openGLControl.Width;
        }

        private void trackBar10_ValueChanged(object sender, EventArgs e)
        {
        }

        private void trackBar13_ValueChanged(object sender, EventArgs e)
        {
            this.rotx = (float)this.trackBar13.Value / 100f;
            this.label5.Text = "Rotation: x=" + this.rotx.ToString() + ", y=" + this.roty.ToString() + ", z=" + this.rotz.ToString();
            ++this.openGLControl.Width;
            --this.openGLControl.Width;
        }

        private void changeA_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = changeA.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                changeA.BackColor = colorDialog1.Color;
                float[] new_value = { (float)colorDialog1.Color.R / 255, (float)colorDialog1.Color.G / 255, (float)colorDialog1.Color.B / 255 };
                colorA = new_value;
            }
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = changeB.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                changeB.BackColor = colorDialog1.Color;
                float[] new_value = { (float)colorDialog1.Color.R / 255, (float)colorDialog1.Color.G / 255, (float)colorDialog1.Color.B / 255 };
                colorB = new_value;
            }
        }

        private void changeC_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = changeC.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                changeC.BackColor = colorDialog1.Color;
                float[] new_value = { (float)colorDialog1.Color.R / 255, (float)colorDialog1.Color.G / 255, (float)colorDialog1.Color.B / 255 };
                colorC = new_value;
            }
        }

        private void changeD_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = changeD.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                changeD.BackColor = colorDialog1.Color;
                float[] new_value = { (float)colorDialog1.Color.R / 255, (float)colorDialog1.Color.G / 255, (float)colorDialog1.Color.B / 255 };
                colorD = new_value;
            }
        }

        private void changeE_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = changeE.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                changeE.BackColor = colorDialog1.Color;
                float[] new_value = { (float)colorDialog1.Color.R / 255, (float)colorDialog1.Color.G / 255, (float)colorDialog1.Color.B / 255 };
                colorE = new_value;
            }
        }

        private void changeF_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = changeF.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                changeF.BackColor = colorDialog1.Color;
                float[] new_value = { (float)colorDialog1.Color.R / 255, (float)colorDialog1.Color.G / 255, (float)colorDialog1.Color.B / 255 };
                colorF = new_value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float[] new_valueA = { 0f, 1f, 0f };
            float[] new_valueB = { 1f, 1f, 0f };
            float[] new_valueC = { 0f, 1f, 1f };
            float[] new_valueD = { 1f, 0f, 1f };
            float[] new_valueE = { 1f, 0f, 0f };
            float[] new_valueF = { 0f, 0f, 1f };
            colorA = new_valueA;
            colorB = new_valueB;
            colorC = new_valueC;
            colorD = new_valueD;
            colorE = new_valueE;
            colorF = new_valueF;
            changeA.BackColor = System.Drawing.Color.Lime;
            changeB.BackColor = System.Drawing.Color.Yellow;
            changeC.BackColor = System.Drawing.Color.Aqua;
            changeD.BackColor = System.Drawing.Color.Fuchsia;
            changeE.BackColor = System.Drawing.Color.Red;
            changeF.BackColor = System.Drawing.Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            float[] new_valueA = { (float)(r.Next(0, 255))/255, (float)(r.Next(0, 255)) / 255, (float)(r.Next(0, 255)) / 255 };
            float[] new_valueB = { (float)(r.Next(0, 255)) / 255, (float)(r.Next(0, 255)) / 255, (float)(r.Next(0, 255)) / 255 };
            float[] new_valueC = { (float)(r.Next(0, 255)) / 255, (float)(r.Next(0, 255)) / 255, (float)(r.Next(0, 255)) / 255 };
            float[] new_valueD = { (float)(r.Next(0, 255)) / 255, (float)(r.Next(0, 255)) / 255, (float)(r.Next(0, 255)) / 255 };
            float[] new_valueE = { (float)(r.Next(0, 255)) / 255, (float)(r.Next(0, 255)) / 255, (float)(r.Next(0, 255)) / 255 };
            float[] new_valueF = { (float)(r.Next(0, 255)) / 255, (float)(r.Next(0, 255)) / 255, (float)(r.Next(0, 255)) / 255 };
            colorA = new_valueA;
            colorB = new_valueB;
            colorC = new_valueC;
            colorD = new_valueD;
            colorE = new_valueE;
            colorF = new_valueF;
            changeA.BackColor = System.Drawing.Color.FromArgb((int)(colorA[0] * 255), (int)(colorA[1] * 255), (int)(colorA[2] * 255));
            changeB.BackColor = System.Drawing.Color.FromArgb((int)(colorB[0] * 255), (int)(colorB[1] * 255), (int)(colorB[2] * 255));
            changeC.BackColor = System.Drawing.Color.FromArgb((int)(colorC[0] * 255), (int)(colorC[1] * 255), (int)(colorC[2] * 255));
            changeD.BackColor = System.Drawing.Color.FromArgb((int)(colorD[0] * 255), (int)(colorD[1] * 255), (int)(colorD[2] * 255));
            changeE.BackColor = System.Drawing.Color.FromArgb((int)(colorE[0] * 255), (int)(colorE[1] * 255), (int)(colorE[2] * 255));
            changeF.BackColor = System.Drawing.Color.FromArgb((int)(colorF[0] * 255), (int)(colorF[1] * 255), (int)(colorF[2] * 255));
        }

        private void trackBar15_Scroll(object sender, EventArgs e)
        {
            size = (float)trackBar15.Value / 1000f;
            label7.Text = string.Format("Size multiplier: {0}x", size);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            shifter.Enabled = checkBox3.Checked;
        }

        private float[] HueShift(float[] color)
        {
            float r = color[0];
            float g = color[1];
            float b = color[2];
            Color int_color = Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
            Color int_ncolor = Program.ChangeHue(int_color, 1);
            float[] new_color = { (float)int_ncolor.R/255f, (float)int_ncolor.G/255f, (float)int_ncolor.B/255f };
            return new_color;
        }

        private void shifter_Tick(object sender, EventArgs e)
        {
            colorA = HueShift(colorA);
            colorB = HueShift(colorB);
            colorC = HueShift(colorC);
            colorD = HueShift(colorD);
            colorE = HueShift(colorE);
            colorF = HueShift(colorF);
            changeA.BackColor = System.Drawing.Color.FromArgb((int)(colorA[0] * 255), (int)(colorA[1] * 255), (int)(colorA[2] * 255));
            changeB.BackColor = System.Drawing.Color.FromArgb((int)(colorB[0] * 255), (int)(colorB[1] * 255), (int)(colorB[2] * 255));
            changeC.BackColor = System.Drawing.Color.FromArgb((int)(colorC[0] * 255), (int)(colorC[1] * 255), (int)(colorC[2] * 255));
            changeD.BackColor = System.Drawing.Color.FromArgb((int)(colorD[0] * 255), (int)(colorD[1] * 255), (int)(colorD[2] * 255));
            changeE.BackColor = System.Drawing.Color.FromArgb((int)(colorE[0] * 255), (int)(colorE[1] * 255), (int)(colorE[2] * 255));
            changeF.BackColor = System.Drawing.Color.FromArgb((int)(colorF[0] * 255), (int)(colorF[1] * 255), (int)(colorF[2] * 255));
        }

        private void vertexZ_ValueChanged(object sender, EventArgs e)
        {
            vertexZdisplay.Text = string.Format("Z = {0}", (double)vertexZ.Value / 100.0);
        }

        private void vertexY_ValueChanged(object sender, EventArgs e)
        {
            vertexYdisplay.Text = string.Format("Y = {0}", (double)vertexY.Value / 100.0);
        }

        private void vertexX_ValueChanged(object sender, EventArgs e)
        {
            vertexXdisplay.Text = string.Format("X = {0}", (double)vertexX.Value / 100.0);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vertexX.Enabled = listBox1.SelectedIndices.Count > 0;
            vertexY.Enabled = listBox1.SelectedIndices.Count > 0;
            vertexZ.Enabled = listBox1.SelectedIndices.Count > 0;
            comboBox1.Enabled = listBox1.SelectedIndices.Count > 0;
            plusButton.Enabled = listBox1.SelectedIndices.Count > 0;
            minusButton.Enabled = listBox1.SelectedIndices.Count > 0;
            applyButton.Enabled = listBox1.SelectedIndices.Count > 0;
            discardButton.Enabled = listBox1.SelectedIndices.Count > 0;
            restoreButton.Enabled = true;
            if (listBox1.SelectedIndices.Count > 0)
            {
                label8.Text = string.Format("Selected vertex: {0}", listBox1.SelectedItem.ToString());
                Reselect();
            }
            else
            {
                label8.Text = "Select vertex from the list!";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            listBox1.Items[listBox1.SelectedIndex] = string.Format("{0},{1},{2},{3}", ((double)vertexX.Value / 100.0).ToString().Replace(",", "."), ((double)vertexY.Value / 100.0).ToString().Replace(",", "."), ((double)vertexZ.Value / 100.0).ToString().Replace(",", "."), comboBox1.SelectedItem.ToString());
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            Reselect();
        }

        void Reselect()
        {
            string[] values = listBox1.SelectedItem.ToString().Split(",");
            vertexX.Value = Convert.ToInt32(Convert.ToDouble(values[0].Replace(".", ",")) * 100.0);
            vertexY.Value = Convert.ToInt32(Convert.ToDouble(values[1].Replace(".", ",")) * 100.0);
            vertexZ.Value = Convert.ToInt32(Convert.ToDouble(values[2].Replace(".", ",")) * 100.0);
            int i = 0;
            foreach (string c in comboBox1.Items)
            {
                if (c == values[3])
                {
                    comboBox1.SelectedIndex = i;
                    break;
                }
                i++;
            }
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            LoadTemplate("0,1,-0.5,A;0,0,-0.5,A;1,0,-0.5,A;1,1,-0.5,A;0,1,0.5,B;0,0,0.5,B;1,0,0.5,B;1,1,0.5,B;0,0,0.5,C;0,0,-0.5,C;1,0,-0.5,C;1,0,0.5,C;0,1,0.5,D;0,1,-0.5,D;1,1,-0.5,D;1,1,0.5,D;0,1,0.5,E;0,1,-0.5,E;0,0,-0.5,E;0,0,0.5,E;1,1,0.5,F;1,1,-0.5,F;1,0,-0.5,F;1,0,0.5,F");
            this.Text = string.Format("Open GL 3D {0} 2.0", "Cube");
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            verticeCountLabel.Text = string.Format("Total number of verticies: {0}", listBox1.Items.Count);
            listBox1.Items.Add(string.Format("{0},{1},{2},{3}", ((double)vertexX.Value / 100.0).ToString().Replace(",", "."), ((double)vertexY.Value / 100.0).ToString().Replace(",", "."), ((double)vertexZ.Value / 100.0).ToString().Replace(",", "."), comboBox1.SelectedItem.ToString()));
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            verticeCountLabel.Text = string.Format("Total number of verticies: {0}", listBox1.Items.Count);
        }

        private void trackBar7_Scroll_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadTemplate("-1,1,0,A;-1,0,0,A;0,0,0,A;1,1,0,A;-1,1,1,B;-1,0,1,B;0,0,1,B;1,1,1,B;1,1,1,C;-1,1,1,C;-1,1,0,C;1,1,0,C;1,1,1,D;0,0,1,D;0,0,0,D;1,1,0,D;0,0,1,E;-1,0,1,E;-1,0,0,E;0,0,0,E;-1,1,1,F;-1,0,1,F;-1,0,0,F;-1,1,0,F");
            this.Text = string.Format("Open GL 3D {0} 2.0", "Trapese Prism");
        }

        void LoadTemplate(string data)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(data.Split(";"));
            verticeCountLabel.Text = string.Format("Total number of verticies: {0}", listBox1.Items.Count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadTemplate("0,0,0.25,A;0,0,-0.25,A;1,0,-0.25,A;1,0,0.25,A;0,1,0.25,B;0,1,-0.25,B;1,1,-0.25,B;1,1,0.25,B;0,1,0.25,C;0,1,-0.25,C;0,0,-0.25,C;0,0,0.25,C;1,1,-0.25,D;1,0,-0.25,D;0,0,-0.25,D;0,1,-0.25,D;1,1,0.25,E;1,1,-0.25,E;1,0,-0.25,E;1,0,0.25,E;1,1,0.25,F;1,0,0.25,F;0,0,0.25,F;0,1,0.25,F");
            this.Text = string.Format("Open GL 3D {0} 2.0", "Cuboid");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(string.Join(";", listBox1.Items.OfType<string>().ToArray()));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadTemplate("0,0,0.5,C;0,0,-0.5,C;1,0,-0.5,C;1,0,0.5,C;0.5,1,0.25,A;0,0,-0.5,A;1,0,-0.5,A;1,0,-0.5,A;0.5,1,0.25,B;0,0,0.5,B;1,0,0.5,B;1,0,0.5,B;0.5,1,0.25,D;0,0,-0.5,D;0,0,0.5,D;0,0,0.5,D;0.5,1,0.25,E;1,0,-0.5,E;1,0,0.5,E;1,0,0.5,E");
            this.Text = string.Format("Open GL 3D {0} 2.0", "Pyramid");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadTemplate("0,0,0.75,A;0,0,-0.12,A;1,0,-0.12,A;1,0,-0.12,A;-0.05,0,0.75,C;-1,0,-0.12,C;-0.05,0,-0.12,C;-0.05,0,-0.12,C;0,0,-1,E;0,0,-0.17,E;1,0,-0.17,E;1,0,-0.17,E;-0.05,0,-1,B;-0.05,0,-0.17,B;-1,0,-0.17,B;-1,0,-0.17,B");
            this.Text = string.Format("Open GL 3D {0} 2.0", "Markus' Stuff Logo");
        }

        private void button10_KeyDown(object sender, MouseEventArgs e)
        {
            joystickKey = "left";
            keydownTimer.Enabled = true;
        }

        private void button12_KeyDown(object sender, MouseEventArgs e)
        {
            joystickKey = "right";
            keydownTimer.Enabled = true;
        }

        private void button14_MouseUp(object sender, MouseEventArgs e)
        {
            keydownTimer.Enabled = false;
        }

        private void keydownTimer_Tick(object sender, EventArgs e)
        {
            if (joystickKey == "up")
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string[] list_item = listBox1.Items[i].ToString().Split(",");
                    float y = float.Parse(list_item[1], CultureInfo.InvariantCulture.NumberFormat) - 0.1f;
                    listBox1.Items[i] = string.Format("{0},{1},{2},{3}", list_item[0], y.ToString().Replace(",", "."), list_item[2], list_item[3]);
                }
            } else if (joystickKey == "down")
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string[] list_item = listBox1.Items[i].ToString().Split(",");
                    float y = float.Parse(list_item[1], CultureInfo.InvariantCulture.NumberFormat) + 0.1f;
                    listBox1.Items[i] = string.Format("{0},{1},{2},{3}", list_item[0], y.ToString().Replace(",", "."), list_item[2], list_item[3]);
                }
            }
            switch(joystickKey)
            {
                case "left":
                    m_Camera.moveCamera(m_Camera.getSpeed());
                    break;
                case "right":
                    m_Camera.moveCamera(-m_Camera.getSpeed());
                    break;
                case "forward":
                    m_Camera.yawCamera(m_Camera.getSpeed());
                    break;
                case "back":
                    m_Camera.yawCamera(-m_Camera.getSpeed());
                    break;
            }
        }

        private void openGLControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (use_joystick)
            {
                move_mouse = e.Control;
                
            } else
            {
                move_mouse = false;
                Cursor.Show();
            }
            switch (e.KeyCode)
            {
                case Keys.W:   //on
                    m_Camera.yawCamera(m_Camera.getSpeed());

                    break;
                case Keys.S:   //under
                    m_Camera.yawCamera(-m_Camera.getSpeed());

                    break;
                case Keys.A:   //left
                    m_Camera.moveCamera(m_Camera.getSpeed());
                    break;
                case Keys.D:   //right
                    m_Camera.moveCamera(-m_Camera.getSpeed());

                    break;
                default:
                    break;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            use_joystick = checkBox4.Checked;
            button9.Enabled = use_joystick;
            button10.Enabled = use_joystick;
            button11.Enabled = use_joystick;
            button12.Enabled = use_joystick;
            button13.Enabled = use_joystick;
            button14.Enabled = use_joystick;
            button15.Enabled = use_joystick;
            button16.Enabled = use_joystick;
        }

        private void openGLControl_KeyUp(object sender, KeyEventArgs e)
        {
            move_mouse = false;
            Cursor.Show();
        }

        private void openGLControl_MouseLeave(object sender, EventArgs e)
        {
            move_mouse = false;
            Cursor.Show();
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            joystickKey = "forward";
            keydownTimer.Enabled = true;
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            joystickKey = "back";
            keydownTimer.Enabled = true;
        }

        private void button15_KeyDown(object sender, MouseEventArgs e)
        {
            joystickKey = "down";
            keydownTimer.Enabled = true;
        }

        private void button16_KeyDown(object sender, MouseEventArgs e)
        {
            joystickKey = "up";
            keydownTimer.Enabled = true;
        }
    }

    class Camera
    {
        private Vector3 m_Position;     //position
        private Vector3 m_View;         //Towards
        private Vector3 m_UpVector;     //Up vector
        private float m_Speed;          //speed

        public Camera()
        {
            Vector3 zero = new Vector3(0f, 0f, 0f);
            Vector3 view = new Vector3(0f, 1f, 0.5f);
            Vector3 up = new Vector3(0f, 0f, 1f);
            m_Position = zero;
            m_View = view;
            m_UpVector = up;
            m_Speed = 0.1f;
        }

        public void setSpeed(float speed)
        {
            m_Speed = speed;
        }

        public float getSpeed()
        {
            return m_Speed;
        }

        public Vector3 getPosition()
        {
            return m_Position;
        }

        public Vector3 getView()
        {
            return m_View;
        }

        public Vector3 getUpVector()
        {
            return m_UpVector;
        }


        //Set the camera position, heading and up vector
        public void setCamera(float positionX, float positionY,
            float positionZ, float viewX, float viewY,
            float viewZ, float upVectorX, float upVectorY,
            float upVectorZ)
        {
            //Construction vector
            Vector3 Position = new Vector3(positionX, positionY, positionZ);
            Vector3 View = new Vector3(viewX, viewY, viewZ);
            Vector3 UpVector = new Vector3(upVectorX, upVectorY, upVectorZ);

            //Set up the camera
            m_Position = Position;
            m_View = View;
            m_UpVector = UpVector;
        }

        //Rotate camera direction
        void rotateView(float angle, float x, float y, float z)
        {
            Vector3 newView = new Vector3();
            //Calculate direction vector
            Vector3 view = m_View - m_Position;
            //Calculate sin and cos values 
            float cosTheta = (float)Math.Cos(angle);
            float sinTheta = (float)Math.Sin(angle);

            //Calculate the x value of the rotation vector
            newView.x = (cosTheta + (1 - cosTheta) * x * x) * view.x;
            newView.x += ((1 - cosTheta) * x * y - z * sinTheta) * view.y;
            newView.x += ((1 - cosTheta) * x * z + y * sinTheta) * view.z;

            //Calculate the y value of the rotation vector
            newView.y = ((1 - cosTheta) * x * y + z * sinTheta) * view.x;
            newView.y += (cosTheta + (1 - cosTheta) * y * y) * view.y;
            newView.y += ((1 - cosTheta) * y * z - x * sinTheta) * view.z;

            //Calculate the y value of the rotation vector
            newView.z = ((1 - cosTheta) * x * z - y * sinTheta) * view.x;
            newView.z += ((1 - cosTheta) * y * z + x * sinTheta) * view.y;
            newView.z += (cosTheta + (1 - cosTheta) * z * z) * view.z;

            //Update the direction of the camera
            m_View = m_Position + newView;
        }


        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
        public static extern int GetSystemMetrics(int which);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetCursorPos(out Point pt);

        [DllImport("user32.dll", EntryPoint = "ShowCursor", CharSet = CharSet.Auto)]
        public extern static void ShowCursor(int status);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern int SetCursorPos(int x, int y);

        float lastRotX = 0.0f;      //  Used to save the rotation angle
        float currentRotX = 0.0f;
        public void setViewByMouse()
        {
            const int SM_CXSCREEN = 0;
            const int SM_CYSCREEN = 1;
            Point mousePos;                                      /**< Save the current mouse position */
            int middleX = GetSystemMetrics(SM_CXSCREEN) >> 1; /**< Get half of the screen width */
            int middleY = GetSystemMetrics(SM_CYSCREEN) >> 1; /**< Get half of the screen height */
            float angleY = 0.0f;                              /**< Camera left and right rotation angle */
            float angleZ = 0.0f;                              /**< Camera vertical rotation angle */


            //  Get the current mouse position
            GetCursorPos(out mousePos);
            ShowCursor(0);

            //  If the mouse does not move, there is no need to update
            if ((mousePos.X == middleX) && (mousePos.Y == middleY))
                return;

            //  Set the mouse position in the center of the screen
            SetCursorPos(middleX, middleY);

            //  Get the mouse movement direction
            angleY = (float)((middleX - mousePos.X)) / 1000.0f;
            angleZ = (float)((middleY - mousePos.Y)) / 1000.0f;

            lastRotX = currentRotX;

            //  Tracking camera up and down rotation angle 
            currentRotX += angleZ;

            //  If the vertical rotation radian is greater than 1.0, we intercept to 1.0 and rotate
            if (currentRotX > 1.0f)
            {
                currentRotX = 1.0f;

                //  Rotate the direction according to the saved angle
                if (lastRotX != 1.0f)
                {
                    //  Find the vector perpendicular to the direction of rotation by cross product
                    Vector3 vAxis = m_View - m_Position;
                    vAxis = vAxis.crossProduct(m_UpVector);
                    vAxis = vAxis.normalize();

                    ///Spin
                    rotateView(1.0f - lastRotX, vAxis.x, vAxis.y, vAxis.z);
                }
            }
            //  If the rotation radian is less than -1.0, then also intercept to -1.0 and rotate
            else if (currentRotX < -1.0f)
            {
                currentRotX = -1.0f;
                if (lastRotX != -1.0f)
                {

                    //  Find the vector perpendicular to the direction of rotation by cross product
                    Vector3 vAxis = m_View - m_Position;
                    vAxis = vAxis.crossProduct(m_UpVector);
                    vAxis = vAxis.normalize();

                    rotateView(-1.0f - lastRotX, vAxis.x, vAxis.y, vAxis.z);
                }
            }
            //  Otherwise, rotate angleZ degrees
            else
            {
                //  Find the vector perpendicular to the direction of rotation
                Vector3 vAxis = m_View - m_Position;
                vAxis = vAxis.crossProduct(m_UpVector);
                vAxis = vAxis.normalize();

                rotateView(angleZ, vAxis.x, vAxis.y, vAxis.z);
            }

            //  Always rotate the camera left and right
            rotateView(angleY, 0, 1, 0);
        }





        public void yawCamera(float speed)
        {
            Vector3 yaw = new Vector3();
            Vector3 cross = m_View - m_Position;
            cross = cross.crossProduct(m_UpVector);

            //Normalized vector
            yaw = cross.normalize();

            m_Position.x += yaw.x * speed;
            m_Position.z += yaw.z * speed;

            m_View.x += yaw.x * speed;
            m_View.z += yaw.z * speed;
        }

        public void moveCamera(float speed)
        {
            //Calculate direction vector
            Vector3 vector = m_View - m_Position;
            vector = vector.normalize();    //Unitization 

            //Update camera
            m_Position.x += vector.x * speed;   //Update location based on speed
            m_Position.z += vector.z * speed;
            m_Position.y += vector.y * speed;

            m_View.x += vector.x * speed;       //Update direction based on speed
            m_View.y += vector.y * speed;
            m_View.z += vector.z * speed;
        }

        //Set viewpoint
        public void setLook(OpenGL gl)
        {
            gl.LookAt(m_Position.x, m_Position.y, m_Position.z,
                m_View.x, m_View.y, m_View.z,
                m_UpVector.x, m_UpVector.y, m_UpVector.z);
        }
    }


    //Vector operation class
    class Vector3
    {
        public float x, y, z;
        public Vector3()
        {
            x = 0; y = 0; z = 0;
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3(Vector3 vec)
        {
            this.x = vec.x;
            this.y = vec.y;
            this.z = vec.z;
        }

        public float length()
        {
            return (float)(x * x + y * y + z * z);
        }

        public Vector3 normalize()
        {
            float len = length();
            if (len == 0) len = 1;
            x = x / len;
            y = y / len;
            z = z / len;
            return this;
        }

        //Dot product
        public float dotProduct(Vector3 vec)
        {
            return 0f;
        }

        public Vector3 crossProduct(Vector3 vec)
        {
            Vector3 v = new Vector3();
            v.x = y * vec.z - z * vec.y;
            v.y = z * vec.x - x * vec.z;
            v.z = x * vec.y - y * vec.x;
            return v;
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            var res = new Vector3();
            res.x = v1.x + v2.x;
            res.y = v1.y + v2.y;
            res.z = v1.z + v2.z;
            return res;
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            var res = new Vector3();
            res.x = v1.x - v2.x;
            res.y = v1.y - v2.y;
            res.z = v1.z - v2.z;
            return res;
        }

        public static Vector3 operator *(Vector3 v1, Vector3 v2)
        {
            var res = new Vector3();
            res.x = v1.x * v2.x;
            res.y = v1.y * v2.y;
            res.z = v1.z * v2.z;
            return res;
        }

        public static Vector3 operator /(Vector3 v1, Vector3 v2)
        {
            var res = new Vector3();
            res.x = v1.x / v2.x;
            res.y = v1.y / v2.y;
            res.z = v1.z / v2.z;
            return res;
        }

        public static Vector3 operator -(Vector3 vec)
        {
            vec.x = -1 * vec.x;
            vec.y = -1 * vec.y;
            vec.z = -1 * vec.z;
            return vec;
        }

    }

}
