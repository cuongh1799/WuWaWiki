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
            MaterialPanel = new RichTextBox();
            addCharacterButton = new Button();
            sidebar = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(347, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(789, 533);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
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
            // addCharacterButton
            // 
            addCharacterButton.Location = new Point(3, 3);
            addCharacterButton.Name = "addCharacterButton";
            addCharacterButton.Size = new Size(309, 62);
            addCharacterButton.TabIndex = 7;
            addCharacterButton.Text = "Add Character";
            addCharacterButton.UseVisualStyleBackColor = true;
            addCharacterButton.Click += addCharacterButton_Click;
            // 
            // sidebar
            // 
            sidebar.AutoScroll = true;
            sidebar.BorderStyle = BorderStyle.Fixed3D;
            sidebar.Controls.Add(addCharacterButton);
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(12, 12);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(319, 695);
            sidebar.TabIndex = 8;
            sidebar.WrapContents = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 719);
            Controls.Add(sidebar);
            Controls.Add(MaterialPanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimumSize = new Size(1156, 756);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Changli/Reborn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button MaterialButton;
        private Button BuildButton;
        private RichTextBox MaterialPanel;
        private Button addCharacterButton;
        private FlowLayoutPanel sidebar;
    }
}
