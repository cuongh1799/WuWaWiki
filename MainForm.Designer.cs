namespace ChangliReborn
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            MaterialButton = new Button();
            BuildButton = new Button();
            addCharacterButton = new Button();
            sidebar = new FlowLayoutPanel();
            RefreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(374, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(925, 801);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(46, 43, 39);
            flowLayoutPanel1.Controls.Add(MaterialButton);
            flowLayoutPanel1.Controls.Add(BuildButton);
            flowLayoutPanel1.Location = new Point(374, 825);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(929, 133);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // MaterialButton
            // 
            MaterialButton.BackColor = Color.FromArgb(97, 86, 67);
            MaterialButton.FlatAppearance.BorderSize = 0;
            MaterialButton.FlatStyle = FlatStyle.Flat;
            MaterialButton.Font = new Font("Segoe UI", 20F);
            MaterialButton.ForeColor = SystemColors.ButtonFace;
            MaterialButton.Location = new Point(3, 4);
            MaterialButton.Margin = new Padding(3, 4, 3, 4);
            MaterialButton.Name = "MaterialButton";
            MaterialButton.Size = new Size(448, 129);
            MaterialButton.TabIndex = 0;
            MaterialButton.Text = "Material";
            MaterialButton.UseVisualStyleBackColor = false;
            MaterialButton.Click += BuildButton_Click;
            // 
            // BuildButton
            // 
            BuildButton.BackColor = Color.FromArgb(97, 86, 67);
            BuildButton.FlatAppearance.BorderSize = 0;
            BuildButton.FlatStyle = FlatStyle.Flat;
            BuildButton.Font = new Font("Segoe UI", 20F);
            BuildButton.ForeColor = SystemColors.ButtonFace;
            BuildButton.Location = new Point(457, 4);
            BuildButton.Margin = new Padding(3, 4, 3, 4);
            BuildButton.Name = "BuildButton";
            BuildButton.Size = new Size(455, 129);
            BuildButton.TabIndex = 1;
            BuildButton.Text = "Build";
            BuildButton.UseVisualStyleBackColor = false;
            // 
            // addCharacterButton
            // 
            addCharacterButton.BackColor = Color.FromArgb(97, 86, 67);
            addCharacterButton.BackgroundImageLayout = ImageLayout.Center;
            addCharacterButton.FlatAppearance.BorderSize = 0;
            addCharacterButton.FlatStyle = FlatStyle.Flat;
            addCharacterButton.Font = new Font("Sitka Display", 20F);
            addCharacterButton.ForeColor = SystemColors.ButtonFace;
            addCharacterButton.Location = new Point(3, 4);
            addCharacterButton.Margin = new Padding(3, 4, 3, 4);
            addCharacterButton.Name = "addCharacterButton";
            addCharacterButton.Size = new Size(362, 88);
            addCharacterButton.TabIndex = 7;
            addCharacterButton.Text = "Add Character";
            addCharacterButton.UseVisualStyleBackColor = false;
            addCharacterButton.Click += addCharacterButton_Click;
            // 
            // sidebar
            // 
            sidebar.AutoScroll = true;
            sidebar.BackColor = Color.FromArgb(46, 43, 39);
            sidebar.Controls.Add(addCharacterButton);
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(3, 91);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(368, 867);
            sidebar.TabIndex = 8;
            sidebar.WrapContents = false;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.FromArgb(97, 86, 67);
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.Font = new Font("Sitka Display", 20F);
            RefreshButton.ForeColor = SystemColors.ButtonFace;
            RefreshButton.Location = new Point(3, 13);
            RefreshButton.Margin = new Padding(3, 4, 3, 4);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(368, 76);
            RefreshButton.TabIndex = 9;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1303, 959);
            Controls.Add(sidebar);
            Controls.Add(RefreshButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(1319, 992);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Changli/Reborn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button MaterialButton;
        private Button BuildButton;
        private Button addCharacterButton;
        private FlowLayoutPanel sidebar;
        public PictureBox pictureBox1;
        private Button RefreshButton;
    }
}
