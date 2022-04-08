namespace WinFormsApp1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolBrush = new System.Windows.Forms.ToolStripButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.ColorsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.labelColors = new System.Windows.Forms.Label();
			this.toolStripColorSelected = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripLoad = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolElipse = new System.Windows.Forms.ToolStripButton();
			this.toolSquare = new System.Windows.Forms.ToolStripButton();
			this.toolTrash = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
			this.toolEng = new System.Windows.Forms.ToolStripButton();
			this.toolPol = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
			this.ThicknessSelector = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.ColorsLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripSave,
            this.toolStripLoad,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolBrush,
            this.toolElipse,
            this.toolSquare,
            this.toolTrash,
            this.toolStripSeparator2,
            this.toolStripLabel5,
            this.ThicknessSelector,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.toolStripColorSelected,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.toolEng,
            this.toolPol});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(822, 27);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(44, 24);
			this.toolStripLabel1.Text = "Tools";
			// 
			// toolBrush
			// 
			this.toolBrush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBrush.Image = ((System.Drawing.Image)(resources.GetObject("toolBrush.Image")));
			this.toolBrush.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolBrush.Name = "toolBrush";
			this.toolBrush.Size = new System.Drawing.Size(29, 24);
			this.toolBrush.Text = "Brush";
			this.toolBrush.Click += new System.EventHandler(this.toolBrush_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.53846F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.46154F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ColorsLayoutPanel, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 408);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// pictureBox
			// 
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new System.Drawing.Point(3, 3);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(705, 402);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.pictureBox.SizeChanged += new System.EventHandler(this.pictureBox_SizeChanged);
			this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
			this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
			this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
			// 
			// ColorsLayoutPanel
			// 
			this.ColorsLayoutPanel.AutoScroll = true;
			this.ColorsLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ColorsLayoutPanel.Controls.Add(this.labelColors);
			this.ColorsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ColorsLayoutPanel.Location = new System.Drawing.Point(714, 3);
			this.ColorsLayoutPanel.Name = "ColorsLayoutPanel";
			this.ColorsLayoutPanel.Size = new System.Drawing.Size(105, 402);
			this.ColorsLayoutPanel.TabIndex = 1;
			this.ColorsLayoutPanel.Click += new System.EventHandler(this.ColorsLayoutPanel_Click);
			this.ColorsLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorsLayoutPanel_Paint);
			// 
			// labelColors
			// 
			this.labelColors.AutoSize = true;
			this.labelColors.Location = new System.Drawing.Point(3, 0);
			this.labelColors.Name = "labelColors";
			this.labelColors.Size = new System.Drawing.Size(51, 20);
			this.labelColors.TabIndex = 0;
			this.labelColors.Text = "Colors";
			this.labelColors.Click += new System.EventHandler(this.label1_Click);
			// 
			// toolStripColorSelected
			// 
			this.toolStripColorSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripColorSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripColorSelected.Name = "toolStripColorSelected";
			this.toolStripColorSelected.Size = new System.Drawing.Size(29, 24);
			this.toolStripColorSelected.Text = "toolStripButton1";
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(106, 24);
			this.toolStripLabel2.Text = "Color Selected";
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(32, 24);
			this.toolStripLabel3.Text = "File";
			// 
			// toolStripSave
			// 
			this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
			this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSave.Name = "toolStripSave";
			this.toolStripSave.Size = new System.Drawing.Size(29, 24);
			this.toolStripSave.Text = "SAVE";
			this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
			// 
			// toolStripLoad
			// 
			this.toolStripLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLoad.Image")));
			this.toolStripLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLoad.Name = "toolStripLoad";
			this.toolStripLoad.Size = new System.Drawing.Size(29, 24);
			this.toolStripLoad.Text = "LOAD";
			this.toolStripLoad.Click += new System.EventHandler(this.toolStripLoad_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// toolElipse
			// 
			this.toolElipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolElipse.Image = ((System.Drawing.Image)(resources.GetObject("toolElipse.Image")));
			this.toolElipse.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolElipse.Name = "toolElipse";
			this.toolElipse.Size = new System.Drawing.Size(29, 24);
			this.toolElipse.Text = "Elipse";
			this.toolElipse.Click += new System.EventHandler(this.toolElipse_Click);
			// 
			// toolSquare
			// 
			this.toolSquare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolSquare.Image = ((System.Drawing.Image)(resources.GetObject("toolSquare.Image")));
			this.toolSquare.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolSquare.Name = "toolSquare";
			this.toolSquare.Size = new System.Drawing.Size(29, 24);
			this.toolSquare.Text = "Rectangle";
			this.toolSquare.Click += new System.EventHandler(this.toolSquare_Click);
			// 
			// toolTrash
			// 
			this.toolTrash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolTrash.Image = ((System.Drawing.Image)(resources.GetObject("toolTrash.Image")));
			this.toolTrash.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolTrash.Name = "toolTrash";
			this.toolTrash.Size = new System.Drawing.Size(29, 24);
			this.toolTrash.Text = "Clear";
			this.toolTrash.Click += new System.EventHandler(this.toolTrash_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStripLabel4
			// 
			this.toolStripLabel4.Name = "toolStripLabel4";
			this.toolStripLabel4.Size = new System.Drawing.Size(41, 24);
			this.toolStripLabel4.Text = "Lang";
			// 
			// toolEng
			// 
			this.toolEng.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolEng.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.toolEng.Image = ((System.Drawing.Image)(resources.GetObject("toolEng.Image")));
			this.toolEng.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolEng.Name = "toolEng";
			this.toolEng.Size = new System.Drawing.Size(29, 24);
			this.toolEng.Text = "EN";
			// 
			// toolPol
			// 
			this.toolPol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolPol.Image = ((System.Drawing.Image)(resources.GetObject("toolPol.Image")));
			this.toolPol.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolPol.Name = "toolPol";
			this.toolPol.Size = new System.Drawing.Size(29, 24);
			this.toolPol.Text = "ES";
			this.toolPol.Click += new System.EventHandler(this.toolPol_Click);
			// 
			// toolStripLabel5
			// 
			this.toolStripLabel5.Name = "toolStripLabel5";
			this.toolStripLabel5.Size = new System.Drawing.Size(72, 24);
			this.toolStripLabel5.Text = "thickness ";
			// 
			// ThicknessSelector
			// 
			this.ThicknessSelector.AutoToolTip = false;
			this.ThicknessSelector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ThicknessSelector.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
			this.ThicknessSelector.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ThicknessSelector.Name = "ThicknessSelector";
			this.ThicknessSelector.Size = new System.Drawing.Size(14, 24);
			this.ThicknessSelector.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
			this.toolStripMenuItem2.Text = "1";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
			this.toolStripMenuItem3.Text = "2";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
			this.toolStripMenuItem4.Text = "3";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 433);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ColorsLayoutPanel.ResumeLayout(false);
			this.ColorsLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.FlowLayoutPanel ColorsLayoutPanel;
		private System.Windows.Forms.Label labelColors;
		private System.Windows.Forms.ToolStripButton toolBrush;
		private System.Windows.Forms.ToolStripButton toolStripColorSelected;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripButton toolStripSave;
		private System.Windows.Forms.ToolStripButton toolStripLoad;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolElipse;
		private System.Windows.Forms.ToolStripButton toolSquare;
		private System.Windows.Forms.ToolStripButton toolTrash;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripLabel toolStripLabel4;
		private System.Windows.Forms.ToolStripButton toolEng;
		private System.Windows.Forms.ToolStripButton toolPol;
		private System.Windows.Forms.ToolStripLabel toolStripLabel5;
		private System.Windows.Forms.ToolStripDropDownButton ThicknessSelector;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
	}
}
