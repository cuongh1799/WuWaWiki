namespace ChangliReborn.classes.MaterialForm
{
    partial class MaterialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MatTitle = new Label();
            MatFormPic = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            BossMatLabel = new Label();
            ClassMatLabel = new Label();
            AscensionMatLabel = new Label();
            SkillMatLabel1 = new Label();
            SkillMatLabel2 = new Label();
            ((System.ComponentModel.ISupportInitialize)MatFormPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // MatTitle
            // 
            MatTitle.AutoSize = true;
            MatTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MatTitle.Location = new Point(345, 9);
            MatTitle.Name = "MatTitle";
            MatTitle.Size = new Size(221, 50);
            MatTitle.TabIndex = 0;
            MatTitle.Text = "Material List";
            // 
            // MatFormPic
            // 
            MatFormPic.Location = new Point(12, 76);
            MatFormPic.Name = "MatFormPic";
            MatFormPic.Size = new Size(339, 522);
            MatFormPic.TabIndex = 1;
            MatFormPic.TabStop = false;
            MatFormPic.Click += MatFormPic_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(383, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 184);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(383, 344);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(216, 184);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // BossMatLabel
            // 
            BossMatLabel.AutoSize = true;
            BossMatLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BossMatLabel.Location = new Point(383, 281);
            BossMatLabel.Name = "BossMatLabel";
            BossMatLabel.Size = new Size(141, 30);
            BossMatLabel.TabIndex = 4;
            BossMatLabel.Text = "BossMatLabel";
            // 
            // ClassMatLabel
            // 
            ClassMatLabel.AutoSize = true;
            ClassMatLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClassMatLabel.Location = new Point(383, 557);
            ClassMatLabel.Name = "ClassMatLabel";
            ClassMatLabel.Size = new Size(146, 30);
            ClassMatLabel.TabIndex = 5;
            ClassMatLabel.Text = "ClassMatLabel";
            // 
            // AscensionMatLabel
            // 
            AscensionMatLabel.AutoSize = true;
            AscensionMatLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AscensionMatLabel.Location = new Point(701, 281);
            AscensionMatLabel.Name = "AscensionMatLabel";
            AscensionMatLabel.Size = new Size(193, 30);
            AscensionMatLabel.TabIndex = 6;
            AscensionMatLabel.Text = "AscensionMatLabel";
            // 
            // SkillMatLabel1
            // 
            SkillMatLabel1.AutoSize = true;
            SkillMatLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SkillMatLabel1.Location = new Point(701, 557);
            SkillMatLabel1.Name = "SkillMatLabel1";
            SkillMatLabel1.Size = new Size(146, 30);
            SkillMatLabel1.TabIndex = 7;
            SkillMatLabel1.Text = "SkillMatLabel1";
            // 
            // SkillMatLabel2
            // 
            SkillMatLabel2.AutoSize = true;
            SkillMatLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SkillMatLabel2.Location = new Point(1086, 557);
            SkillMatLabel2.Name = "SkillMatLabel2";
            SkillMatLabel2.Size = new Size(146, 30);
            SkillMatLabel2.TabIndex = 8;
            SkillMatLabel2.Text = "SkillMatLabel2";
            // 
            // MaterialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 610);
            Controls.Add(SkillMatLabel2);
            Controls.Add(SkillMatLabel1);
            Controls.Add(AscensionMatLabel);
            Controls.Add(ClassMatLabel);
            Controls.Add(BossMatLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(MatTitle);
            Controls.Add(MatFormPic);
            Name = "MaterialForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Materials";
            ((System.ComponentModel.ISupportInitialize)MatFormPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MatTitle;
        private PictureBox MatFormPic;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label BossMatLabel;
        private Label ClassMatLabel;
        private Label AscensionMatLabel;
        private Label SkillMatLabel1;
        private Label SkillMatLabel2;
    }
}