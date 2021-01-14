
namespace HoboNightGamePicker
{
    partial class Form_HoboNightGamePicker
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
            this.listBox_GameLibrary = new System.Windows.Forms.ListBox();
            this.label_GameLibrary = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_NewGame = new System.Windows.Forms.TextBox();
            this.button_AddNewGame = new System.Windows.Forms.Button();
            this.label_NewGame = new System.Windows.Forms.Label();
            this.groupBox_GamePicker = new System.Windows.Forms.GroupBox();
            this.checkedListBox_GamePickerTags = new System.Windows.Forms.CheckedListBox();
            this.checkBox_EnforcePlayerCount = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_GamePickerPlayers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox_GamePickerPlatforms = new System.Windows.Forms.CheckedListBox();
            this.button_PickAGame = new System.Windows.Forms.Button();
            this.label_SelectedGame = new System.Windows.Forms.Label();
            this.textBox_SelectedGame = new System.Windows.Forms.TextBox();
            this.groupBox_SelectedGame = new System.Windows.Forms.GroupBox();
            this.checkedListBox_GameTags = new System.Windows.Forms.CheckedListBox();
            this.label_Players = new System.Windows.Forms.Label();
            this.comboBox_Players = new System.Windows.Forms.ComboBox();
            this.label_Platforms = new System.Windows.Forms.Label();
            this.label_Tags = new System.Windows.Forms.Label();
            this.checkedListBox_Platforms = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox_GamePicker.SuspendLayout();
            this.groupBox_SelectedGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_GameLibrary
            // 
            this.listBox_GameLibrary.FormattingEnabled = true;
            this.listBox_GameLibrary.ItemHeight = 20;
            this.listBox_GameLibrary.Location = new System.Drawing.Point(12, 71);
            this.listBox_GameLibrary.Name = "listBox_GameLibrary";
            this.listBox_GameLibrary.Size = new System.Drawing.Size(426, 384);
            this.listBox_GameLibrary.TabIndex = 0;
            this.listBox_GameLibrary.SelectedValueChanged += new System.EventHandler(this.listBox_GameLibrary_SelectedValueChanged);
            // 
            // label_GameLibrary
            // 
            this.label_GameLibrary.AutoSize = true;
            this.label_GameLibrary.Location = new System.Drawing.Point(20, 48);
            this.label_GameLibrary.Name = "label_GameLibrary";
            this.label_GameLibrary.Size = new System.Drawing.Size(104, 20);
            this.label_GameLibrary.TabIndex = 1;
            this.label_GameLibrary.Text = "Game Library";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tagsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTagsToolStripMenuItem});
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.tagsToolStripMenuItem.Text = "&Tags";
            // 
            // editTagsToolStripMenuItem
            // 
            this.editTagsToolStripMenuItem.Name = "editTagsToolStripMenuItem";
            this.editTagsToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.editTagsToolStripMenuItem.Text = "&Edit Tags";
            this.editTagsToolStripMenuItem.Click += new System.EventHandler(this.editTagsToolStripMenuItem_Click);
            // 
            // textBox_NewGame
            // 
            this.textBox_NewGame.Location = new System.Drawing.Point(12, 498);
            this.textBox_NewGame.Name = "textBox_NewGame";
            this.textBox_NewGame.Size = new System.Drawing.Size(414, 26);
            this.textBox_NewGame.TabIndex = 10;
            // 
            // button_AddNewGame
            // 
            this.button_AddNewGame.Location = new System.Drawing.Point(12, 530);
            this.button_AddNewGame.Name = "button_AddNewGame";
            this.button_AddNewGame.Size = new System.Drawing.Size(112, 46);
            this.button_AddNewGame.TabIndex = 11;
            this.button_AddNewGame.Text = "Add Game";
            this.button_AddNewGame.UseVisualStyleBackColor = true;
            this.button_AddNewGame.Click += new System.EventHandler(this.button_AddNewGame_Click);
            // 
            // label_NewGame
            // 
            this.label_NewGame.AutoSize = true;
            this.label_NewGame.Location = new System.Drawing.Point(8, 475);
            this.label_NewGame.Name = "label_NewGame";
            this.label_NewGame.Size = new System.Drawing.Size(84, 20);
            this.label_NewGame.TabIndex = 12;
            this.label_NewGame.Text = "NewGame";
            // 
            // groupBox_GamePicker
            // 
            this.groupBox_GamePicker.Controls.Add(this.checkedListBox_GamePickerTags);
            this.groupBox_GamePicker.Controls.Add(this.checkBox_EnforcePlayerCount);
            this.groupBox_GamePicker.Controls.Add(this.label1);
            this.groupBox_GamePicker.Controls.Add(this.comboBox_GamePickerPlayers);
            this.groupBox_GamePicker.Controls.Add(this.label2);
            this.groupBox_GamePicker.Controls.Add(this.label3);
            this.groupBox_GamePicker.Controls.Add(this.checkedListBox_GamePickerPlatforms);
            this.groupBox_GamePicker.Controls.Add(this.button_PickAGame);
            this.groupBox_GamePicker.Controls.Add(this.label_SelectedGame);
            this.groupBox_GamePicker.Controls.Add(this.textBox_SelectedGame);
            this.groupBox_GamePicker.Location = new System.Drawing.Point(17, 701);
            this.groupBox_GamePicker.Name = "groupBox_GamePicker";
            this.groupBox_GamePicker.Size = new System.Drawing.Size(951, 602);
            this.groupBox_GamePicker.TabIndex = 13;
            this.groupBox_GamePicker.TabStop = false;
            this.groupBox_GamePicker.Text = "GamePicker";
            // 
            // checkedListBox_GamePickerTags
            // 
            this.checkedListBox_GamePickerTags.FormattingEnabled = true;
            this.checkedListBox_GamePickerTags.Location = new System.Drawing.Point(16, 51);
            this.checkedListBox_GamePickerTags.Name = "checkedListBox_GamePickerTags";
            this.checkedListBox_GamePickerTags.Size = new System.Drawing.Size(351, 372);
            this.checkedListBox_GamePickerTags.TabIndex = 33;
            // 
            // checkBox_EnforcePlayerCount
            // 
            this.checkBox_EnforcePlayerCount.AutoSize = true;
            this.checkBox_EnforcePlayerCount.Location = new System.Drawing.Point(373, 305);
            this.checkBox_EnforcePlayerCount.Name = "checkBox_EnforcePlayerCount";
            this.checkBox_EnforcePlayerCount.Size = new System.Drawing.Size(185, 24);
            this.checkBox_EnforcePlayerCount.TabIndex = 32;
            this.checkBox_EnforcePlayerCount.Text = "Enforce Player Count";
            this.checkBox_EnforcePlayerCount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Players";
            // 
            // comboBox_GamePickerPlayers
            // 
            this.comboBox_GamePickerPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GamePickerPlayers.FormattingEnabled = true;
            this.comboBox_GamePickerPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_GamePickerPlayers.Location = new System.Drawing.Point(373, 271);
            this.comboBox_GamePickerPlayers.Name = "comboBox_GamePickerPlayers";
            this.comboBox_GamePickerPlayers.Size = new System.Drawing.Size(121, 28);
            this.comboBox_GamePickerPlayers.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Platforms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tags";
            // 
            // checkedListBox_GamePickerPlatforms
            // 
            this.checkedListBox_GamePickerPlatforms.FormattingEnabled = true;
            this.checkedListBox_GamePickerPlatforms.Items.AddRange(new object[] {
            "Xbox",
            "PlayStation",
            "Switch",
            "PC",
            "Mobile"});
            this.checkedListBox_GamePickerPlatforms.Location = new System.Drawing.Point(373, 45);
            this.checkedListBox_GamePickerPlatforms.Name = "checkedListBox_GamePickerPlatforms";
            this.checkedListBox_GamePickerPlatforms.Size = new System.Drawing.Size(152, 165);
            this.checkedListBox_GamePickerPlatforms.TabIndex = 26;
            // 
            // button_PickAGame
            // 
            this.button_PickAGame.Location = new System.Drawing.Point(0, 525);
            this.button_PickAGame.Name = "button_PickAGame";
            this.button_PickAGame.Size = new System.Drawing.Size(967, 35);
            this.button_PickAGame.TabIndex = 24;
            this.button_PickAGame.Text = "Pick A Game!!";
            this.button_PickAGame.UseVisualStyleBackColor = true;
            this.button_PickAGame.Click += new System.EventHandler(this.button_PickAGame_Click);
            // 
            // label_SelectedGame
            // 
            this.label_SelectedGame.AutoSize = true;
            this.label_SelectedGame.Location = new System.Drawing.Point(435, 470);
            this.label_SelectedGame.Name = "label_SelectedGame";
            this.label_SelectedGame.Size = new System.Drawing.Size(120, 20);
            this.label_SelectedGame.TabIndex = 23;
            this.label_SelectedGame.Text = "Selected Game";
            // 
            // textBox_SelectedGame
            // 
            this.textBox_SelectedGame.Location = new System.Drawing.Point(-2, 493);
            this.textBox_SelectedGame.Name = "textBox_SelectedGame";
            this.textBox_SelectedGame.ReadOnly = true;
            this.textBox_SelectedGame.Size = new System.Drawing.Size(967, 26);
            this.textBox_SelectedGame.TabIndex = 22;
            this.textBox_SelectedGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox_SelectedGame
            // 
            this.groupBox_SelectedGame.Controls.Add(this.checkedListBox_GameTags);
            this.groupBox_SelectedGame.Controls.Add(this.label_Players);
            this.groupBox_SelectedGame.Controls.Add(this.comboBox_Players);
            this.groupBox_SelectedGame.Controls.Add(this.label_Platforms);
            this.groupBox_SelectedGame.Controls.Add(this.label_Tags);
            this.groupBox_SelectedGame.Controls.Add(this.checkedListBox_Platforms);
            this.groupBox_SelectedGame.Location = new System.Drawing.Point(473, 55);
            this.groupBox_SelectedGame.Name = "groupBox_SelectedGame";
            this.groupBox_SelectedGame.Size = new System.Drawing.Size(494, 440);
            this.groupBox_SelectedGame.TabIndex = 14;
            this.groupBox_SelectedGame.TabStop = false;
            // 
            // checkedListBox_GameTags
            // 
            this.checkedListBox_GameTags.FormattingEnabled = true;
            this.checkedListBox_GameTags.Location = new System.Drawing.Point(37, 52);
            this.checkedListBox_GameTags.Name = "checkedListBox_GameTags";
            this.checkedListBox_GameTags.Size = new System.Drawing.Size(211, 326);
            this.checkedListBox_GameTags.TabIndex = 16;
            this.checkedListBox_GameTags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_GameTags_ItemCheck);
            // 
            // label_Players
            // 
            this.label_Players.AutoSize = true;
            this.label_Players.Location = new System.Drawing.Point(262, 248);
            this.label_Players.Name = "label_Players";
            this.label_Players.Size = new System.Drawing.Size(60, 20);
            this.label_Players.TabIndex = 15;
            this.label_Players.Text = "Players";
            // 
            // comboBox_Players
            // 
            this.comboBox_Players.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Players.FormattingEnabled = true;
            this.comboBox_Players.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_Players.Location = new System.Drawing.Point(266, 271);
            this.comboBox_Players.Name = "comboBox_Players";
            this.comboBox_Players.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Players.TabIndex = 14;
            this.comboBox_Players.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Players_SelectionChangeCommitted);
            // 
            // label_Platforms
            // 
            this.label_Platforms.AutoSize = true;
            this.label_Platforms.Location = new System.Drawing.Point(262, 22);
            this.label_Platforms.Name = "label_Platforms";
            this.label_Platforms.Size = new System.Drawing.Size(76, 20);
            this.label_Platforms.TabIndex = 13;
            this.label_Platforms.Text = "Platforms";
            // 
            // label_Tags
            // 
            this.label_Tags.AutoSize = true;
            this.label_Tags.Location = new System.Drawing.Point(25, 22);
            this.label_Tags.Name = "label_Tags";
            this.label_Tags.Size = new System.Drawing.Size(44, 20);
            this.label_Tags.TabIndex = 12;
            this.label_Tags.Text = "Tags";
            // 
            // checkedListBox_Platforms
            // 
            this.checkedListBox_Platforms.FormattingEnabled = true;
            this.checkedListBox_Platforms.Items.AddRange(new object[] {
            "Xbox",
            "PlayStation",
            "Switch",
            "PC",
            "Mobile"});
            this.checkedListBox_Platforms.Location = new System.Drawing.Point(266, 45);
            this.checkedListBox_Platforms.Name = "checkedListBox_Platforms";
            this.checkedListBox_Platforms.Size = new System.Drawing.Size(152, 165);
            this.checkedListBox_Platforms.TabIndex = 11;
            this.checkedListBox_Platforms.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_Platforms_ItemCheck);
            // 
            // Form_HoboNightGamePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 1315);
            this.Controls.Add(this.groupBox_SelectedGame);
            this.Controls.Add(this.groupBox_GamePicker);
            this.Controls.Add(this.label_NewGame);
            this.Controls.Add(this.button_AddNewGame);
            this.Controls.Add(this.textBox_NewGame);
            this.Controls.Add(this.label_GameLibrary);
            this.Controls.Add(this.listBox_GameLibrary);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_HoboNightGamePicker";
            this.Text = "Hobo Night Game Picker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_GamePicker.ResumeLayout(false);
            this.groupBox_GamePicker.PerformLayout();
            this.groupBox_SelectedGame.ResumeLayout(false);
            this.groupBox_SelectedGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_GameLibrary;
        private System.Windows.Forms.Label label_GameLibrary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_NewGame;
        private System.Windows.Forms.Button button_AddNewGame;
        private System.Windows.Forms.Label label_NewGame;
        private System.Windows.Forms.GroupBox groupBox_GamePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_GamePickerPlayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox_GamePickerPlatforms;
        private System.Windows.Forms.Button button_PickAGame;
        private System.Windows.Forms.Label label_SelectedGame;
        private System.Windows.Forms.TextBox textBox_SelectedGame;
        private System.Windows.Forms.GroupBox groupBox_SelectedGame;
        private System.Windows.Forms.Label label_Players;
        private System.Windows.Forms.ComboBox comboBox_Players;
        private System.Windows.Forms.Label label_Platforms;
        private System.Windows.Forms.Label label_Tags;
        private System.Windows.Forms.CheckedListBox checkedListBox_Platforms;
        private System.Windows.Forms.CheckBox checkBox_EnforcePlayerCount;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTagsToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox checkedListBox_GameTags;
        private System.Windows.Forms.CheckedListBox checkedListBox_GamePickerTags;
    }
}

