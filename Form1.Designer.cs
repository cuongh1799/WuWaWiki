namespace ChangliReborn
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SideBar = new FlowLayoutPanel();
            SideBarCollapseButton = new PictureBox();
            JinhsiIconSide = new PictureBox();
            ChangliIconSide = new PictureBox();
            ChangliSelect = new Button();
            JinhsiSelect = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            BuildButton = new Button();
            MaterialButton = new Button();
            BuildPanel = new RichTextBox();
            SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SideBarCollapseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)JinhsiIconSide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChangliIconSide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.WhiteSmoke;
            SideBar.Controls.Add(SideBarCollapseButton);
            SideBar.Controls.Add(JinhsiIconSide);
            SideBar.Controls.Add(ChangliIconSide);
            SideBar.Controls.Add(ChangliSelect);
            SideBar.Controls.Add(JinhsiSelect);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(341, 719);
            SideBar.TabIndex = 0;
            // 
            // SideBarCollapseButton
            // 
            SideBarCollapseButton.Cursor = Cursors.Hand;
            SideBarCollapseButton.Image = (Image)resources.GetObject("SideBarCollapseButton.Image");
            SideBarCollapseButton.Location = new Point(3, 3);
            SideBarCollapseButton.Name = "SideBarCollapseButton";
            SideBarCollapseButton.Size = new Size(90, 90);
            SideBarCollapseButton.SizeMode = PictureBoxSizeMode.Zoom;
            SideBarCollapseButton.TabIndex = 4;
            SideBarCollapseButton.TabStop = false;
            SideBarCollapseButton.Click += SideBarCollapseButton_Click;
            // 
            // JinhsiIconSide
            // 
            JinhsiIconSide.BackColor = Color.LightGray;
            JinhsiIconSide.BorderStyle = BorderStyle.FixedSingle;
            JinhsiIconSide.Cursor = Cursors.Hand;
            JinhsiIconSide.Image = (Image)resources.GetObject("JinhsiIconSide.Image");
            JinhsiIconSide.Location = new Point(99, 3);
            JinhsiIconSide.Name = "JinhsiIconSide";
            JinhsiIconSide.Size = new Size(90, 90);
            JinhsiIconSide.SizeMode = PictureBoxSizeMode.Zoom;
            JinhsiIconSide.TabIndex = 3;
            JinhsiIconSide.TabStop = false;
            JinhsiIconSide.Visible = false;
            JinhsiIconSide.Click += JinhsiIconSide_Click;
            // 
            // ChangliIconSide
            // 
            ChangliIconSide.BackColor = Color.LightGray;
            ChangliIconSide.BackgroundImageLayout = ImageLayout.Center;
            ChangliIconSide.BorderStyle = BorderStyle.FixedSingle;
            ChangliIconSide.Cursor = Cursors.Hand;
            ChangliIconSide.Image = (Image)resources.GetObject("ChangliIconSide.Image");
            ChangliIconSide.Location = new Point(195, 3);
            ChangliIconSide.Name = "ChangliIconSide";
            ChangliIconSide.Size = new Size(90, 90);
            ChangliIconSide.SizeMode = PictureBoxSizeMode.Zoom;
            ChangliIconSide.TabIndex = 2;
            ChangliIconSide.TabStop = false;
            ChangliIconSide.Visible = false;
            ChangliIconSide.Click += ChangliIconSide_Click;
            // 
            // ChangliSelect
            // 
            ChangliSelect.Image = (Image)resources.GetObject("ChangliSelect.Image");
            ChangliSelect.Location = new Point(3, 99);
            ChangliSelect.Name = "ChangliSelect";
            ChangliSelect.Size = new Size(338, 90);
            ChangliSelect.TabIndex = 0;
            ChangliSelect.UseVisualStyleBackColor = true;
            ChangliSelect.Click += ChangliSelect_Click;
            // 
            // JinhsiSelect
            // 
            JinhsiSelect.Image = (Image)resources.GetObject("JinhsiSelect.Image");
            JinhsiSelect.Location = new Point(3, 195);
            JinhsiSelect.Name = "JinhsiSelect";
            JinhsiSelect.Size = new Size(338, 90);
            JinhsiSelect.TabIndex = 1;
            JinhsiSelect.Text = "Jinhsi";
            JinhsiSelect.UseVisualStyleBackColor = true;
            JinhsiSelect.Click += JinhsiSelect_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(337, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 615);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 25;
            timer1.Tick += timer1_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(BuildButton);
            flowLayoutPanel1.Controls.Add(MaterialButton);
            flowLayoutPanel1.Location = new Point(337, 619);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(803, 100);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // BuildButton
            // 
            BuildButton.Location = new Point(3, 3);
            BuildButton.Name = "BuildButton";
            BuildButton.Size = new Size(392, 97);
            BuildButton.TabIndex = 0;
            BuildButton.Text = "Build";
            BuildButton.UseVisualStyleBackColor = true;
            BuildButton.Click += BuildButton_Click;
            // 
            // MaterialButton
            // 
            MaterialButton.Location = new Point(401, 3);
            MaterialButton.Name = "MaterialButton";
            MaterialButton.Size = new Size(398, 97);
            MaterialButton.TabIndex = 1;
            MaterialButton.Text = "Materials";
            MaterialButton.UseVisualStyleBackColor = true;
            MaterialButton.Click += MaterialButton_Click;
            // 
            // BuildPanel
            // 
            BuildPanel.Location = new Point(391, 26);
            BuildPanel.Name = "BuildPanel";
            BuildPanel.ReadOnly = true;
            BuildPanel.Size = new Size(704, 561);
            BuildPanel.TabIndex = 3;
            BuildPanel.Text = "";
            BuildPanel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1140, 719);
            Controls.Add(BuildPanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(SideBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimumSize = new Size(1156, 758);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Changli/Reborn";
            SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SideBarCollapseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)JinhsiIconSide).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChangliIconSide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel SideBar;
        private Button ChangliSelect;
        private PictureBox pictureBox1;
        private Button JinhsiSelect;
        private PictureBox ChangliIconSide;
        private PictureBox JinhsiIconSide;
        private PictureBox SideBarCollapseButton;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BuildButton;
        private Button MaterialButton;
        private RichTextBox BuildPanel;
    }
}
