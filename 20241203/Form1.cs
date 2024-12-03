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
        private void 檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
        int x, y;

        private void 藍色ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 綠色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void 紅色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void 細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 1;

        }

        private void 中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 5;
        }

        private void 粗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 10;
        }

        private void 儲存檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"C:\Users\User\Desktop\1.jpeg", ImageFormat.Jpeg);
            MessageBox.Show("儲存成功");
        }

        private void 黑色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void 直線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
        }

        private void 點ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        private void 長短虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void 長虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashPattern = new float[] { 6F, 3F };
        }
    }
}