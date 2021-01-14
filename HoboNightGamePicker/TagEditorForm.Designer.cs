
namespace HoboNightGamePicker
{
    partial class TagEditorForm
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
            this.listBox_Tags = new System.Windows.Forms.ListBox();
            this.label_Tags = new System.Windows.Forms.Label();
            this.textBox_AddTag = new System.Windows.Forms.TextBox();
            this.button_AddTag = new System.Windows.Forms.Button();
            this.button_RemoveTag = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Tags
            // 
            this.listBox_Tags.FormattingEnabled = true;
            this.listBox_Tags.ItemHeight = 20;
            this.listBox_Tags.Location = new System.Drawing.Point(12, 32);
            this.listBox_Tags.Name = "listBox_Tags";
            this.listBox_Tags.Size = new System.Drawing.Size(166, 224);
            this.listBox_Tags.TabIndex = 0;
            // 
            // label_Tags
            // 
            this.label_Tags.AutoSize = true;
            this.label_Tags.Location = new System.Drawing.Point(12, 9);
            this.label_Tags.Name = "label_Tags";
            this.label_Tags.Size = new System.Drawing.Size(44, 20);
            this.label_Tags.TabIndex = 1;
            this.label_Tags.Text = "Tags";
            // 
            // textBox_AddTag
            // 
            this.textBox_AddTag.Location = new System.Drawing.Point(184, 32);
            this.textBox_AddTag.Name = "textBox_AddTag";
            this.textBox_AddTag.Size = new System.Drawing.Size(162, 26);
            this.textBox_AddTag.TabIndex = 2;
            // 
            // button_AddTag
            // 
            this.button_AddTag.Location = new System.Drawing.Point(184, 64);
            this.button_AddTag.Name = "button_AddTag";
            this.button_AddTag.Size = new System.Drawing.Size(162, 43);
            this.button_AddTag.TabIndex = 3;
            this.button_AddTag.Text = "Add Tag";
            this.button_AddTag.UseVisualStyleBackColor = true;
            this.button_AddTag.Click += new System.EventHandler(this.button_AddTag_Click);
            // 
            // button_RemoveTag
            // 
            this.button_RemoveTag.Location = new System.Drawing.Point(184, 212);
            this.button_RemoveTag.Name = "button_RemoveTag";
            this.button_RemoveTag.Size = new System.Drawing.Size(161, 48);
            this.button_RemoveTag.TabIndex = 4;
            this.button_RemoveTag.Text = "Remove Tag";
            this.button_RemoveTag.UseVisualStyleBackColor = true;
            this.button_RemoveTag.Click += new System.EventHandler(this.button_RemoveTag_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(103, 262);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 41);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // TagEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 336);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_RemoveTag);
            this.Controls.Add(this.button_AddTag);
            this.Controls.Add(this.textBox_AddTag);
            this.Controls.Add(this.label_Tags);
            this.Controls.Add(this.listBox_Tags);
            this.Name = "TagEditorForm";
            this.Text = "Tag Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Tags;
        private System.Windows.Forms.Label label_Tags;
        private System.Windows.Forms.TextBox textBox_AddTag;
        private System.Windows.Forms.Button button_AddTag;
        private System.Windows.Forms.Button button_RemoveTag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Cancel;
    }
}