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
            SideBarCollapseButton = new PictureBox();
            JinhsiIconSide = new PictureBox();
            ChangliIconSide = new PictureBox();
            ChangliSelect = new Button();
            JinhsiSelect = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            MaterialButton = new Button();
            BuildButton = new Button();
            MaterialPanel = new RichTextBox();
            vScrollBar1 = new VScrollBar();
            panel1 = new Panel();
            addCharacterButton = new Button();
            ((System.ComponentModel.ISupportInitialize)SideBarCollapseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)JinhsiIconSide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChangliIconSide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SideBarCollapseButton
            // 
            SideBarCollapseButton.Cursor = Cursors.Hand;
            SideBarCollapseButton.Image = (Image)resources.GetObject("SideBarCollapseButton.Image");
            SideBarCollapseButton.Location = new Point(340, 344);
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
            JinhsiIconSide.Location = new Point(337, 235);
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
            ChangliIconSide.Location = new Point(340, 130);
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
            ChangliSelect.Location = new Point(0, 141);
            ChangliSelect.Name = "ChangliSelect";
            ChangliSelect.Size = new Size(293, 79);
            ChangliSelect.TabIndex = 0;
            ChangliSelect.UseVisualStyleBackColor = true;
            ChangliSelect.Click += ChangliSelect_Click;
            // 
            // JinhsiSelect
            // 
            JinhsiSelect.Image = (Image)resources.GetObject("JinhsiSelect.Image");
            JinhsiSelect.Location = new Point(0, 226);
            JinhsiSelect.Name = "JinhsiSelect";
            JinhsiSelect.Size = new Size(293, 67);
            JinhsiSelect.TabIndex = 1;
            JinhsiSelect.Text = "Jinhsi";
            JinhsiSelect.UseVisualStyleBackColor = true;
            JinhsiSelect.Click += JinhsiSelect_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(519, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 421);
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
            flowLayoutPanel1.Controls.Add(MaterialButton);
            flowLayoutPanel1.Controls.Add(BuildButton);
            flowLayoutPanel1.Location = new Point(337, 619);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(803, 100);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // MaterialButton
            // 
            MaterialButton.Location = new Point(3, 3);
            MaterialButton.Name = "MaterialButton";
            MaterialButton.Size = new Size(392, 97);
            MaterialButton.TabIndex = 0;
            MaterialButton.Text = "Material";
            MaterialButton.UseVisualStyleBackColor = true;
            MaterialButton.Click += BuildButton_Click;
            // 
            // BuildButton
            // 
            BuildButton.Location = new Point(401, 3);
            BuildButton.Name = "BuildButton";
            BuildButton.Size = new Size(398, 97);
            BuildButton.TabIndex = 1;
            BuildButton.Text = "Build";
            BuildButton.UseVisualStyleBackColor = true;
            // 
            // MaterialPanel
            // 
            MaterialPanel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaterialPanel.Location = new Point(641, 22);
            MaterialPanel.Name = "MaterialPanel";
            MaterialPanel.ReadOnly = true;
            MaterialPanel.Size = new Size(487, 355);
            MaterialPanel.TabIndex = 3;
            MaterialPanel.Text = "";
            MaterialPanel.Visible = false;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(309, 12);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(25, 701);
            vScrollBar1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(addCharacterButton);
            panel1.Controls.Add(ChangliSelect);
            panel1.Controls.Add(JinhsiSelect);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 701);
            panel1.TabIndex = 6;
            // 
            // addCharacterButton
            // 
            addCharacterButton.Location = new Point(3, 13);
            addCharacterButton.Name = "addCharacterButton";
            addCharacterButton.Size = new Size(290, 62);
            addCharacterButton.TabIndex = 7;
            addCharacterButton.Text = "Add Character";
            addCharacterButton.UseVisualStyleBackColor = true;
            addCharacterButton.Click += addCharacterButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 719);
            Controls.Add(panel1);
            Controls.Add(vScrollBar1);
            Controls.Add(SideBarCollapseButton);
            Controls.Add(MaterialPanel);
            Controls.Add(JinhsiIconSide);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ChangliIconSide);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimumSize = new Size(1156, 756);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Changli/Reborn";
            ((System.ComponentModel.ISupportInitialize)SideBarCollapseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)JinhsiIconSide).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChangliIconSide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button ChangliSelect;
        private PictureBox pictureBox1;
        private Button JinhsiSelect;
        private PictureBox ChangliIconSide;
        private PictureBox JinhsiIconSide;
        private PictureBox SideBarCollapseButton;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button MaterialButton;
        private Button BuildButton;
        private RichTextBox MaterialPanel;
        private VScrollBar vScrollBar1;
        private Panel panel1;
        private Button addCharacterButton;
    }
}
