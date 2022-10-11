using GamePicker;
using System;
using System.Windows.Forms;

namespace HoboNightGamePicker
{
    public partial class TagEditorForm : Form
    {
        public TagEditorForm()
        {
            InitializeComponent();

            listBox_Tags.Items.AddRange(TagManager.SupportedTags.ToArray());
        }

        private void button_AddTag_Click(object sender, EventArgs e)
        {
            if (TagManager.AddTags(textBox_AddTag.Text))
            {
                listBox_Tags.Items.Add(textBox_AddTag.Text);
                textBox_AddTag.Clear();
            }
        }

        private void button_RemoveTag_Click(object sender, EventArgs e)
        {
            if (listBox_Tags.SelectedItem != null)
            {
                TagManager.RemoveTags(listBox_Tags.SelectedItem.ToString());
                listBox_Tags.Items.Remove(listBox_Tags.SelectedItem);
            }
        }
    }
}
