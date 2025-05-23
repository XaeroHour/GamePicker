﻿
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
            this.button_Lock = new System.Windows.Forms.Button();
            this.label_Hat = new System.Windows.Forms.Label();
            this.button_PickAGameFromTheHat = new System.Windows.Forms.Button();
            this.checkedListBox_GamePickerGameHat = new System.Windows.Forms.CheckedListBox();
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
            this.checkBox_WeightedPick = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox_GamePicker.SuspendLayout();
            this.groupBox_SelectedGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_GameLibrary
            // 
            this.listBox_GameLibrary.FormattingEnabled = true;
            this.listBox_GameLibrary.Location = new System.Drawing.Point(8, 46);
            this.listBox_GameLibrary.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_GameLibrary.Name = "listBox_GameLibrary";
            this.listBox_GameLibrary.Size = new System.Drawing.Size(285, 251);
            this.listBox_GameLibrary.TabIndex = 0;
            this.listBox_GameLibrary.SelectedValueChanged += new System.EventHandler(this.ListBox_GameLibrary_SelectedValueChanged);
            // 
            // label_GameLibrary
            // 
            this.label_GameLibrary.AutoSize = true;
            this.label_GameLibrary.Location = new System.Drawing.Point(13, 31);
            this.label_GameLibrary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_GameLibrary.Name = "label_GameLibrary";
            this.label_GameLibrary.Size = new System.Drawing.Size(69, 13);
            this.label_GameLibrary.TabIndex = 1;
            this.label_GameLibrary.Text = "Game Library";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tagsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTagsToolStripMenuItem});
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(42, 22);
            this.tagsToolStripMenuItem.Text = "&Tags";
            // 
            // editTagsToolStripMenuItem
            // 
            this.editTagsToolStripMenuItem.Name = "editTagsToolStripMenuItem";
            this.editTagsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.editTagsToolStripMenuItem.Text = "&Edit Tags";
            this.editTagsToolStripMenuItem.Click += new System.EventHandler(this.EditTagsToolStripMenuItem_Click);
            // 
            // textBox_NewGame
            // 
            this.textBox_NewGame.Location = new System.Drawing.Point(8, 324);
            this.textBox_NewGame.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NewGame.Name = "textBox_NewGame";
            this.textBox_NewGame.Size = new System.Drawing.Size(277, 20);
            this.textBox_NewGame.TabIndex = 10;
            // 
            // button_AddNewGame
            // 
            this.button_AddNewGame.Location = new System.Drawing.Point(8, 344);
            this.button_AddNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddNewGame.Name = "button_AddNewGame";
            this.button_AddNewGame.Size = new System.Drawing.Size(75, 30);
            this.button_AddNewGame.TabIndex = 11;
            this.button_AddNewGame.Text = "Add Game";
            this.button_AddNewGame.UseVisualStyleBackColor = true;
            this.button_AddNewGame.Click += new System.EventHandler(this.Button_AddNewGame_Click);
            // 
            // label_NewGame
            // 
            this.label_NewGame.AutoSize = true;
            this.label_NewGame.Location = new System.Drawing.Point(5, 309);
            this.label_NewGame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NewGame.Name = "label_NewGame";
            this.label_NewGame.Size = new System.Drawing.Size(57, 13);
            this.label_NewGame.TabIndex = 12;
            this.label_NewGame.Text = "NewGame";
            // 
            // groupBox_GamePicker
            // 
            this.groupBox_GamePicker.Controls.Add(this.checkBox_WeightedPick);
            this.groupBox_GamePicker.Controls.Add(this.button_Lock);
            this.groupBox_GamePicker.Controls.Add(this.label_Hat);
            this.groupBox_GamePicker.Controls.Add(this.button_PickAGameFromTheHat);
            this.groupBox_GamePicker.Controls.Add(this.checkedListBox_GamePickerGameHat);
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
            this.groupBox_GamePicker.Location = new System.Drawing.Point(11, 456);
            this.groupBox_GamePicker.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_GamePicker.Name = "groupBox_GamePicker";
            this.groupBox_GamePicker.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_GamePicker.Size = new System.Drawing.Size(634, 409);
            this.groupBox_GamePicker.TabIndex = 13;
            this.groupBox_GamePicker.TabStop = false;
            this.groupBox_GamePicker.Text = "GamePicker";
            // 
            // button_Lock
            // 
            this.button_Lock.Location = new System.Drawing.Point(249, 376);
            this.button_Lock.Margin = new System.Windows.Forms.Padding(2);
            this.button_Lock.Name = "button_Lock";
            this.button_Lock.Size = new System.Drawing.Size(139, 26);
            this.button_Lock.TabIndex = 37;
            this.button_Lock.Text = "Lock!";
            this.button_Lock.UseVisualStyleBackColor = true;
            this.button_Lock.Click += new System.EventHandler(this.Button_Lock_Click);
            // 
            // label_Hat
            // 
            this.label_Hat.AutoSize = true;
            this.label_Hat.Location = new System.Drawing.Point(400, 18);
            this.label_Hat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Hat.Name = "label_Hat";
            this.label_Hat.Size = new System.Drawing.Size(46, 13);
            this.label_Hat.TabIndex = 36;
            this.label_Hat.Text = "The Hat";
            // 
            // button_PickAGameFromTheHat
            // 
            this.button_PickAGameFromTheHat.Location = new System.Drawing.Point(389, 341);
            this.button_PickAGameFromTheHat.Margin = new System.Windows.Forms.Padding(2);
            this.button_PickAGameFromTheHat.Name = "button_PickAGameFromTheHat";
            this.button_PickAGameFromTheHat.Size = new System.Drawing.Size(245, 23);
            this.button_PickAGameFromTheHat.TabIndex = 35;
            this.button_PickAGameFromTheHat.Text = "Pick a Game From the hat!!";
            this.button_PickAGameFromTheHat.UseVisualStyleBackColor = true;
            this.button_PickAGameFromTheHat.Click += new System.EventHandler(this.Button_PickAGameFromTheHat_Click);
            // 
            // checkedListBox_GamePickerGameHat
            // 
            this.checkedListBox_GamePickerGameHat.CheckOnClick = true;
            this.checkedListBox_GamePickerGameHat.FormattingEnabled = true;
            this.checkedListBox_GamePickerGameHat.Location = new System.Drawing.Point(396, 33);
            this.checkedListBox_GamePickerGameHat.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_GamePickerGameHat.Name = "checkedListBox_GamePickerGameHat";
            this.checkedListBox_GamePickerGameHat.Size = new System.Drawing.Size(235, 229);
            this.checkedListBox_GamePickerGameHat.TabIndex = 34;
            // 
            // checkedListBox_GamePickerTags
            // 
            this.checkedListBox_GamePickerTags.CheckOnClick = true;
            this.checkedListBox_GamePickerTags.FormattingEnabled = true;
            this.checkedListBox_GamePickerTags.Location = new System.Drawing.Point(11, 33);
            this.checkedListBox_GamePickerTags.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_GamePickerTags.Name = "checkedListBox_GamePickerTags";
            this.checkedListBox_GamePickerTags.Size = new System.Drawing.Size(235, 229);
            this.checkedListBox_GamePickerTags.TabIndex = 33;
            // 
            // checkBox_EnforcePlayerCount
            // 
            this.checkBox_EnforcePlayerCount.AutoSize = true;
            this.checkBox_EnforcePlayerCount.Location = new System.Drawing.Point(249, 198);
            this.checkBox_EnforcePlayerCount.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_EnforcePlayerCount.Name = "checkBox_EnforcePlayerCount";
            this.checkBox_EnforcePlayerCount.Size = new System.Drawing.Size(126, 17);
            this.checkBox_EnforcePlayerCount.TabIndex = 32;
            this.checkBox_EnforcePlayerCount.Text = "Enforce Player Count";
            this.checkBox_EnforcePlayerCount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
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
            this.comboBox_GamePickerPlayers.Location = new System.Drawing.Point(249, 176);
            this.comboBox_GamePickerPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_GamePickerPlayers.Name = "comboBox_GamePickerPlayers";
            this.comboBox_GamePickerPlayers.Size = new System.Drawing.Size(82, 21);
            this.comboBox_GamePickerPlayers.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Platforms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tags";
            // 
            // checkedListBox_GamePickerPlatforms
            // 
            this.checkedListBox_GamePickerPlatforms.CheckOnClick = true;
            this.checkedListBox_GamePickerPlatforms.FormattingEnabled = true;
            this.checkedListBox_GamePickerPlatforms.Items.AddRange(new object[] {
            "Xbox",
            "PlayStation",
            "Switch",
            "PC",
            "Mobile"});
            this.checkedListBox_GamePickerPlatforms.Location = new System.Drawing.Point(249, 33);
            this.checkedListBox_GamePickerPlatforms.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_GamePickerPlatforms.Name = "checkedListBox_GamePickerPlatforms";
            this.checkedListBox_GamePickerPlatforms.Size = new System.Drawing.Size(103, 109);
            this.checkedListBox_GamePickerPlatforms.TabIndex = 26;
            // 
            // button_PickAGame
            // 
            this.button_PickAGame.Location = new System.Drawing.Point(0, 341);
            this.button_PickAGame.Margin = new System.Windows.Forms.Padding(2);
            this.button_PickAGame.Name = "button_PickAGame";
            this.button_PickAGame.Size = new System.Drawing.Size(245, 23);
            this.button_PickAGame.TabIndex = 24;
            this.button_PickAGame.Text = "Pick A Game from the tags!!";
            this.button_PickAGame.UseVisualStyleBackColor = true;
            this.button_PickAGame.Click += new System.EventHandler(this.Button_PickAGame_Click);
            // 
            // label_SelectedGame
            // 
            this.label_SelectedGame.AutoSize = true;
            this.label_SelectedGame.Location = new System.Drawing.Point(290, 305);
            this.label_SelectedGame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SelectedGame.Name = "label_SelectedGame";
            this.label_SelectedGame.Size = new System.Drawing.Size(80, 13);
            this.label_SelectedGame.TabIndex = 23;
            this.label_SelectedGame.Text = "Selected Game";
            // 
            // textBox_SelectedGame
            // 
            this.textBox_SelectedGame.Location = new System.Drawing.Point(-1, 320);
            this.textBox_SelectedGame.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_SelectedGame.Name = "textBox_SelectedGame";
            this.textBox_SelectedGame.ReadOnly = true;
            this.textBox_SelectedGame.Size = new System.Drawing.Size(646, 20);
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
            this.groupBox_SelectedGame.Location = new System.Drawing.Point(315, 36);
            this.groupBox_SelectedGame.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_SelectedGame.Name = "groupBox_SelectedGame";
            this.groupBox_SelectedGame.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_SelectedGame.Size = new System.Drawing.Size(329, 286);
            this.groupBox_SelectedGame.TabIndex = 14;
            this.groupBox_SelectedGame.TabStop = false;
            // 
            // checkedListBox_GameTags
            // 
            this.checkedListBox_GameTags.CheckOnClick = true;
            this.checkedListBox_GameTags.FormattingEnabled = true;
            this.checkedListBox_GameTags.Location = new System.Drawing.Point(25, 34);
            this.checkedListBox_GameTags.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_GameTags.Name = "checkedListBox_GameTags";
            this.checkedListBox_GameTags.Size = new System.Drawing.Size(142, 199);
            this.checkedListBox_GameTags.TabIndex = 16;
            this.checkedListBox_GameTags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox_GameTags_ItemCheck);
            // 
            // label_Players
            // 
            this.label_Players.AutoSize = true;
            this.label_Players.Location = new System.Drawing.Point(175, 161);
            this.label_Players.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Players.Name = "label_Players";
            this.label_Players.Size = new System.Drawing.Size(41, 13);
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
            this.comboBox_Players.Location = new System.Drawing.Point(177, 176);
            this.comboBox_Players.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Players.Name = "comboBox_Players";
            this.comboBox_Players.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Players.TabIndex = 14;
            this.comboBox_Players.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_Players_SelectionChangeCommitted);
            // 
            // label_Platforms
            // 
            this.label_Platforms.AutoSize = true;
            this.label_Platforms.Location = new System.Drawing.Point(175, 14);
            this.label_Platforms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Platforms.Name = "label_Platforms";
            this.label_Platforms.Size = new System.Drawing.Size(50, 13);
            this.label_Platforms.TabIndex = 13;
            this.label_Platforms.Text = "Platforms";
            // 
            // label_Tags
            // 
            this.label_Tags.AutoSize = true;
            this.label_Tags.Location = new System.Drawing.Point(17, 14);
            this.label_Tags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Tags.Name = "label_Tags";
            this.label_Tags.Size = new System.Drawing.Size(31, 13);
            this.label_Tags.TabIndex = 12;
            this.label_Tags.Text = "Tags";
            // 
            // checkedListBox_Platforms
            // 
            this.checkedListBox_Platforms.CheckOnClick = true;
            this.checkedListBox_Platforms.FormattingEnabled = true;
            this.checkedListBox_Platforms.Items.AddRange(new object[] {
            "Xbox",
            "PlayStation",
            "Switch",
            "PC",
            "Mobile"});
            this.checkedListBox_Platforms.Location = new System.Drawing.Point(177, 29);
            this.checkedListBox_Platforms.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_Platforms.Name = "checkedListBox_Platforms";
            this.checkedListBox_Platforms.Size = new System.Drawing.Size(103, 109);
            this.checkedListBox_Platforms.TabIndex = 11;
            this.checkedListBox_Platforms.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox_Platforms_ItemCheck);
            // 
            // checkBox_WeightedPick
            // 
            this.checkBox_WeightedPick.AutoSize = true;
            this.checkBox_WeightedPick.Checked = true;
            this.checkBox_WeightedPick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_WeightedPick.Location = new System.Drawing.Point(274, 345);
            this.checkBox_WeightedPick.Name = "checkBox_WeightedPick";
            this.checkBox_WeightedPick.Size = new System.Drawing.Size(96, 17);
            this.checkBox_WeightedPick.TabIndex = 38;
            this.checkBox_WeightedPick.Text = "Weighted Pick";
            this.checkBox_WeightedPick.UseVisualStyleBackColor = true;
            // 
            // Form_HoboNightGamePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 869);
            this.Controls.Add(this.groupBox_SelectedGame);
            this.Controls.Add(this.groupBox_GamePicker);
            this.Controls.Add(this.label_NewGame);
            this.Controls.Add(this.button_AddNewGame);
            this.Controls.Add(this.textBox_NewGame);
            this.Controls.Add(this.label_GameLibrary);
            this.Controls.Add(this.listBox_GameLibrary);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button button_PickAGameFromTheHat;
        private System.Windows.Forms.CheckedListBox checkedListBox_GamePickerGameHat;
        private System.Windows.Forms.Label label_Hat;
        private System.Windows.Forms.Button button_Lock;
        private System.Windows.Forms.CheckBox checkBox_WeightedPick;
    }
}

