namespace ChangliReborn
{
    partial class AddCharacterForm
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
            AddCharacterJSON = new Button();
            InputCharacterName = new TextBox();
            labelName = new Label();
            MaterialT0 = new Label();
            AscensionMatInput = new TextBox();
            CharacterBannerLabel = new Label();
            CharacterIconLabel = new Label();
            ClassMaterialLabel = new Label();
            ClassMatNameInput = new TextBox();
            BossMatLabel = new Label();
            BossMatInput = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            ChooseCharBanner = new Button();
            ChooseCharIcon = new Button();
            CharBannerURL = new TextBox();
            CharIconURL = new TextBox();
            label1 = new Label();
            SkillMatInput = new TextBox();
            label2 = new Label();
            FlowerTypeInput = new TextBox();
            SuspendLayout();
            // 
            // AddCharacterJSON
            // 
            AddCharacterJSON.Location = new Point(596, 391);
            AddCharacterJSON.Name = "AddCharacterJSON";
            AddCharacterJSON.Size = new Size(192, 47);
            AddCharacterJSON.TabIndex = 0;
            AddCharacterJSON.Text = "Add Character";
            AddCharacterJSON.UseVisualStyleBackColor = true;
            AddCharacterJSON.Click += AddCharacterJSON_Click;
            // 
            // InputCharacterName
            // 
            InputCharacterName.Location = new Point(154, 30);
            InputCharacterName.Name = "InputCharacterName";
            InputCharacterName.Size = new Size(100, 23);
            InputCharacterName.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(40, 38);
            labelName.Name = "labelName";
            labelName.Size = new Size(97, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Character name :";
            // 
            // MaterialT0
            // 
            MaterialT0.AutoSize = true;
            MaterialT0.Location = new Point(18, 83);
            MaterialT0.Name = "MaterialT0";
            MaterialT0.Size = new Size(119, 15);
            MaterialT0.TabIndex = 4;
            MaterialT0.Text = "Ascension material  : ";
            // 
            // AscensionMatInput
            // 
            AscensionMatInput.Location = new Point(154, 75);
            AscensionMatInput.Name = "AscensionMatInput";
            AscensionMatInput.Size = new Size(216, 23);
            AscensionMatInput.TabIndex = 3;
            // 
            // CharacterBannerLabel
            // 
            CharacterBannerLabel.AutoSize = true;
            CharacterBannerLabel.Location = new Point(24, 310);
            CharacterBannerLabel.Name = "CharacterBannerLabel";
            CharacterBannerLabel.Size = new Size(107, 15);
            CharacterBannerLabel.TabIndex = 6;
            CharacterBannerLabel.Text = "Character Banner : ";
            // 
            // CharacterIconLabel
            // 
            CharacterIconLabel.AutoSize = true;
            CharacterIconLabel.Location = new Point(35, 353);
            CharacterIconLabel.Name = "CharacterIconLabel";
            CharacterIconLabel.Size = new Size(93, 15);
            CharacterIconLabel.TabIndex = 7;
            CharacterIconLabel.Text = "Character Icon : ";
            // 
            // ClassMaterialLabel
            // 
            ClassMaterialLabel.AutoSize = true;
            ClassMaterialLabel.Location = new Point(51, 131);
            ClassMaterialLabel.Name = "ClassMaterialLabel";
            ClassMaterialLabel.Size = new Size(86, 15);
            ClassMaterialLabel.TabIndex = 9;
            ClassMaterialLabel.Text = "Class material :";
            // 
            // ClassMatNameInput
            // 
            ClassMatNameInput.Location = new Point(154, 123);
            ClassMatNameInput.Name = "ClassMatNameInput";
            ClassMatNameInput.Size = new Size(216, 23);
            ClassMatNameInput.TabIndex = 8;
            // 
            // BossMatLabel
            // 
            BossMatLabel.AutoSize = true;
            BossMatLabel.Location = new Point(51, 172);
            BossMatLabel.Name = "BossMatLabel";
            BossMatLabel.Size = new Size(83, 15);
            BossMatLabel.TabIndex = 11;
            BossMatLabel.Text = "Boss material :";
            // 
            // BossMatInput
            // 
            BossMatInput.Location = new Point(154, 164);
            BossMatInput.Name = "BossMatInput";
            BossMatInput.Size = new Size(216, 23);
            BossMatInput.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // ChooseCharBanner
            // 
            ChooseCharBanner.Location = new Point(148, 302);
            ChooseCharBanner.Name = "ChooseCharBanner";
            ChooseCharBanner.Size = new Size(75, 23);
            ChooseCharBanner.TabIndex = 12;
            ChooseCharBanner.Text = "Browse";
            ChooseCharBanner.UseVisualStyleBackColor = true;
            ChooseCharBanner.Click += ChooseCharBanner_Click;
            // 
            // ChooseCharIcon
            // 
            ChooseCharIcon.Location = new Point(148, 349);
            ChooseCharIcon.Name = "ChooseCharIcon";
            ChooseCharIcon.Size = new Size(75, 23);
            ChooseCharIcon.TabIndex = 13;
            ChooseCharIcon.Text = "Browse";
            ChooseCharIcon.UseVisualStyleBackColor = true;
            ChooseCharIcon.Click += ChooseCharIcon_Click;
            // 
            // CharBannerURL
            // 
            CharBannerURL.Location = new Point(239, 302);
            CharBannerURL.Name = "CharBannerURL";
            CharBannerURL.Size = new Size(216, 23);
            CharBannerURL.TabIndex = 14;
            // 
            // CharIconURL
            // 
            CharIconURL.Location = new Point(239, 349);
            CharIconURL.Name = "CharIconURL";
            CharIconURL.Size = new Size(216, 23);
            CharIconURL.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 260);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 17;
            label1.Text = "Skill material :";
            // 
            // SkillMatInput
            // 
            SkillMatInput.Location = new Point(154, 252);
            SkillMatInput.Name = "SkillMatInput";
            SkillMatInput.Size = new Size(216, 23);
            SkillMatInput.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 211);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 19;
            label2.Text = "Flower type:";
            // 
            // FlowerTypeInput
            // 
            FlowerTypeInput.Location = new Point(154, 203);
            FlowerTypeInput.Name = "FlowerTypeInput";
            FlowerTypeInput.Size = new Size(216, 23);
            FlowerTypeInput.TabIndex = 18;
            // 
            // AddCharacterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(FlowerTypeInput);
            Controls.Add(label1);
            Controls.Add(SkillMatInput);
            Controls.Add(CharIconURL);
            Controls.Add(CharBannerURL);
            Controls.Add(ChooseCharIcon);
            Controls.Add(ChooseCharBanner);
            Controls.Add(BossMatLabel);
            Controls.Add(BossMatInput);
            Controls.Add(ClassMaterialLabel);
            Controls.Add(ClassMatNameInput);
            Controls.Add(CharacterIconLabel);
            Controls.Add(CharacterBannerLabel);
            Controls.Add(MaterialT0);
            Controls.Add(AscensionMatInput);
            Controls.Add(labelName);
            Controls.Add(InputCharacterName);
            Controls.Add(AddCharacterJSON);
            Name = "AddCharacterForm";
            Text = "Add Character Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddCharacterJSON;
        private TextBox InputCharacterName;
        private Label labelName;
        private Label MaterialT0;
        private TextBox AscensionMatInput;
        private Label CharacterBannerLabel;
        private Label CharacterIconLabel;
        private Label ClassMaterialLabel;
        private TextBox ClassMatNameInput;
        private Label BossMatLabel;
        private TextBox BossMatInput;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Button ChooseCharBanner;
        private Button ChooseCharIcon;
        private TextBox CharBannerURL;
        private TextBox CharIconURL;
        private Label label1;
        private TextBox SkillMatInput;
        private Label label2;
        private TextBox FlowerTypeInput;
    }
}