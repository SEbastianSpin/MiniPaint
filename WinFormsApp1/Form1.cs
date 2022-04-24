using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Globalization;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{

		private Bitmap drawArea;
		private  int Brushthickness = 1;
		bool draw = false;
		Color brushColor=Color.Black;
		int pX = -1;
		int pY = -1;
		bool lines = false;
		bool inuse = false;
		bool sqaure = false;
		bool elipse = false;

		int LastMousePosX = -1;
		int LastMousePosY = -1;


		public Form1()
		{
			InitializeComponent();
			toolStripColorSelected.BackColor = brushColor;
			ThicknessSelector.Text = Brushthickness.ToString();
			drawArea = new Bitmap(pictureBox.Size.Width, pictureBox.Size.Height);
			pictureBox.Image = drawArea;
			using (Graphics g = Graphics.FromImage(drawArea))
				 {
				 g.Clear(System.Drawing.Color.White);
				 }

		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (KnownColor color in Enum.GetValues(typeof(KnownColor))) {

			//	PictureBox ColorBox = new PictureBox();
			//	Bitmap drawAreaColor = new Bitmap(25, 25);
				
			//	using (Graphics g = Graphics.FromImage(drawAreaColor)) {
				//	g.Clear(Color.FromKnownColor(color));

				//}
				//ColorBox.Image = drawAreaColor;


				Button button = new Button();
				button.BackColor = Color.FromKnownColor(color);
				button.Size = new Size(25, 25);
				button.FlatStyle = FlatStyle.Flat;
				button.FlatAppearance.BorderSize = 0;
				button.Name = color.ToString();
				button.Click += (sender, args) =>
				 {
					 brushColor = button.BackColor;
					 toolStripColorSelected.BackColor = brushColor;
					 int a = brushColor.A;
					 int r = brushColor.R;
					 int g = brushColor.G;
					 int b = brushColor.B;

					 r = 255 - r;
					 g = 255 - g;
					 b = 255 - b;

					

					 Pen BoarderPen = new Pen(Color.FromArgb(a, r, g, b));
					 button.FlatAppearance.BorderSize = 1;
					 button.FlatAppearance.BorderColor = Color.FromArgb(a, r, g, b);
					 //button.ForeColor= Color.FromArgb(a, r, g, b);
					 ColorsLayoutPanel.Invalidate();
					
					 //button.FlatAppearance.BorderColor = brushColor;
				 };
				
				ColorsLayoutPanel.Controls.Add(button);
				//ColorsLayoutPanel.Controls.Add(ColorBox);


			}
		}

		private void pictureBox_SizeChanged(object sender, EventArgs e)
		{
			Bitmap NewDrawArea = new Bitmap(pictureBox.Size.Width, pictureBox.Size.Height);
			//drawArea = new Bitmap(pictureBox.Size.Width, pictureBox.Size.Height);
			
			using (Graphics g = Graphics.FromImage(NewDrawArea))
			{
				g.Clear(System.Drawing.Color.White);
				g.DrawImage(drawArea, 0, 0);
			}
			drawArea = NewDrawArea;
			pictureBox.Image = drawArea;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (draw)
			{
				Pen pen = new Pen(brushColor, Brushthickness);
				using (Graphics g = Graphics.FromImage(drawArea))
				{
					if(lines) g.DrawLine(pen, pX, pY, e.X, e.Y);


					if (sqaure&& inuse) {

						

						Bitmap oldBitmap = new Bitmap(drawArea, drawArea.Size.Width, drawArea.Size.Height);
						drawArea = new Bitmap(oldBitmap, drawArea.Size.Width, drawArea.Size.Height);
						pictureBox.Image = drawArea;

						oldBitmap = new Bitmap(drawArea, drawArea.Size.Width, drawArea.Size.Height);
						using (Graphics G = Graphics.FromImage(drawArea))
						{
							G.DrawRectangle(pen, new Rectangle(new Point(LastMousePosX > e.X ? e.X : LastMousePosX, LastMousePosY > e.Y ? e.Y : LastMousePosY), new Size(Math.Abs(e.X - LastMousePosX), Math.Abs(e.Y - LastMousePosY))));
						}
						pictureBox.Refresh();
						

					}

					if (elipse && inuse)//
					{

						Bitmap oldBitmap = new Bitmap(drawArea, drawArea.Size.Width, drawArea.Size.Height);
						drawArea = new Bitmap(oldBitmap, drawArea.Size.Width, drawArea.Size.Height);
						pictureBox.Image = drawArea;

						oldBitmap = new Bitmap(drawArea, drawArea.Size.Width, drawArea.Size.Height);
						using (Graphics G = Graphics.FromImage(drawArea))
						{
							G.DrawEllipse(pen, new Rectangle(new Point(LastMousePosX > e.X ? e.X : LastMousePosX, LastMousePosY > e.Y ? e.Y : LastMousePosY), new Size(Math.Abs(e.X - LastMousePosX), Math.Abs(e.Y - LastMousePosY))));
						}
						pictureBox.Refresh();

					}
					//g.DrawRectangle(pen, pX, pY, Math.Abs(e.X - LastMousePosX), e.Y - LastMousePosY);

					//g.DrawRectangle(pen, new Rectangle(new Point(LastMousePosX > e.X ? e.X : LastMousePosX, LastMousePosY > e.Y ? e.Y : LastMousePosY), new Size(Math.Abs(e.X - LastMousePosX), Math.Abs(e.Y - LastMousePosY))));
					//g.FillRectangle(new SolidBrush(Color.Black), 100, 50, 100, 100);
					//e.Graphics.DrawImage(imageFile, new PointF(0.0F, 0.0F));
				}


				pictureBox.Refresh();
				



			}

			pX = e.X;
			pY = e.Y;
		}

		private void toolBrush_Click(object sender, EventArgs e)
		{
			pictureBox.Cursor = Cursors.Cross;
			lines= true;
			sqaure = false;
			elipse = false;
		}

		private void pictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) {
				draw = true;
				inuse = false;
				LastMousePosX = e.X;
				LastMousePosY = e.Y;
				

			}
			if (e.Button == MouseButtons.Right)
			{
				draw = false;	

			}

			pX = e.X;
			pY = e.Y;
		}

		private void pictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				draw = false;
				inuse = true;
				LastMousePosX = -1;
				LastMousePosY =-1;
				//pX = e.X;
				//pY = e.Y;
				if (elipse && inuse)
				{
					Pen pen = new Pen(brushColor, Brushthickness);
					using (Graphics g = Graphics.FromImage(drawArea))
					{
						g.DrawEllipse(pen, new Rectangle(new Point(LastMousePosX > e.X ? e.X : LastMousePosX, LastMousePosY > e.Y ? e.Y : LastMousePosY), new Size(Math.Abs(e.X - LastMousePosX), Math.Abs(e.Y - LastMousePosY))));
					}
					pictureBox.Refresh();
				}

				//oldBitmap = new Bitmap(drawArea, drawArea.Size.Width, drawArea.Size.Height);
				//using (Graphics G = Graphics.FromImage(drawArea))
				//{
				//	G.DrawRectangle(pen, new Rectangle(new Point(LastMousePosX > e.X ? e.X : LastMousePosX, LastMousePosY > e.Y ? e.Y : LastMousePosY), new Size(Math.Abs(e.X - LastMousePosX), Math.Abs(e.Y - LastMousePosY))));
				//}
				//pictureBox.Refresh();

				if (sqaure) //&& inuse)
				{
					Pen pen = new Pen(brushColor, Brushthickness);
					using (Graphics g = Graphics.FromImage(drawArea))
					{
						g.DrawRectangle(pen, new Rectangle(new Point(LastMousePosX > e.X ? e.X : LastMousePosX, LastMousePosY > e.Y ? e.Y : LastMousePosY), new Size(Math.Abs(e.X - LastMousePosX), Math.Abs(e.Y - LastMousePosY))));
					}
					pictureBox.Refresh();
				}

			}
		}

		private void ColorsLayoutPanel_Paint(object sender, PaintEventArgs e)
		{
			}

		private void ColorsLayoutPanel_Click(object sender, EventArgs e)
		{
			//brushColor= e.
		}


		private void toolSquare_Click(object sender, EventArgs e)
		{
			pictureBox.Cursor = Cursors.Cross;
			lines = false;
			sqaure = true;
			elipse = false;
		}

		private void toolStripSave_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();

			saveFileDialog1.Filter = " Bitmap files (*.bmp)|*.bmp";
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				drawArea.Save(saveFileDialog1.FileName);
			}
		}

		private void toolStripLoad_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.InitialDirectory = @"C:\Users\Sebastian\Pictures\Screenshots";
			openFileDialog.Filter = "Image files (*.bmp)|*.bmp;*.png;*.jpeg"; //jpeg
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				drawArea = (Bitmap)Image.FromFile(openFileDialog.FileName);
				pictureBox.Image = drawArea;
			}

			pictureBox.Refresh();
		}

		


		private void toolTrash_Click(object sender, EventArgs e)
		{
			using (Graphics g = Graphics.FromImage(drawArea))
			{
				g.Clear(Color.White);
			

			}


			pictureBox.Refresh();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Brushthickness = 1;
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			Brushthickness = 2;
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			Brushthickness = 3;
		}

		private void toolElipse_Click(object sender, EventArgs e)
		{
			pictureBox.Cursor = Cursors.Cross;
			lines = false;
			sqaure = false;
			elipse = true;
		}

		private void toolPol_Click(object sender, EventArgs e)
		{
			CultureInfo.CurrentCulture = new CultureInfo("es-ES", false);
			//this.Controls.Clear();
			InitializeComponent();
		}
	}
}
