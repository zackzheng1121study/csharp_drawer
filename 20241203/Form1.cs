using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace _20241203
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int pen_width = 1;
        int pen_style = 0;
        Pen p = new Pen(Color.Black, 3);
        private void �ɮ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
        int x, y;

        private void �Ŧ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);

                g.DrawLine(p, x, y, e.X, e.Y);

                //g.DrawLine(Pens.Black, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
                pictureBox1.Refresh();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);

        }

        private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 1;

        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 5;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 10;
        }

        private void �x�s�ɮ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"C:\Users\User\Desktop\1.jpeg", ImageFormat.Jpeg);
            MessageBox.Show("�x�s���\");
        }

        private void �¦�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void ���uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
        }

        private void �IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void �M��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        private void ���u��uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void ����uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashPattern = new float[] { 6F, 3F };
        }
    }
}