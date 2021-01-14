using GamePicker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoboNightGamePicker
{
    public partial class Form_HoboNightGamePicker : Form
    {
        Game SelectedGame = null;

        public Form_HoboNightGamePicker()
        {
            InitializeComponent();

            listBox_GameLibrary.Items.AddRange(RandomGamePicker.GameList);
            UpdateTagsLists();
        }

        private void UpdateTagsLists()
        {
            checkedListBox_GameTags.Items.Clear();
            checkedListBox_GamePickerTags.Items.Clear();

            checkedListBox_GameTags.Items.AddRange(TagManager.SupportedTags.ToArray());
            checkedListBox_GamePickerTags.Items.AddRange(TagManager.SupportedTags.ToArray());
        }

        private void button_AddNewGame_Click(object sender, EventArgs e)
        {
            if(!listBox_GameLibrary.Items.Contains(textBox_NewGame.Text))
            {
                listBox_GameLibrary.Items.Add(textBox_NewGame.Text);
                RandomGamePicker.AddGame(new Game(name: textBox_NewGame.Text));
            }
        }

        private void button_PickAGame_Click(object sender, EventArgs e)
        {
            List<string> selectedPlatforms = new List<string>();
            List<string> selectedTags = new List<string>();

            if(!int.TryParse(comboBox_GamePickerPlayers.Text, out int players))
            {
                players = 2;
            }

            foreach (string selectedPlatform in checkedListBox_GamePickerPlatforms.CheckedItems)
            {
                selectedPlatforms.Add(selectedPlatform);
            }

            foreach (object selectedTag in checkedListBox_GamePickerTags.SelectedItems)
            {
                selectedTags.Add(selectedTag.ToString());
            }

            try
            {
                Game game = RandomGamePicker.SelectRandomGame(
                    players,
                    checkBox_EnforcePlayerCount.Checked,
                    Game.ConvertStringsToPlatform(selectedPlatforms.ToArray()),
                    selectedTags.ToArray());

                if (game != null)
                {
                    textBox_SelectedGame.Text = game.Name;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Exception hit: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void listBox_GameLibrary_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedGame = RandomGamePicker.FindGame(listBox_GameLibrary.Text);

            groupBox_SelectedGame.Text = SelectedGame?.Name;

            if(SelectedGame == null)
            {
                return;
            }

            for(int i = 0; i < checkedListBox_GameTags.Items.Count; i++)
            {
                checkedListBox_GameTags.SetItemCheckState(i, SelectedGame.ContainsTag(checkedListBox_GameTags.Items[i].ToString()) ? CheckState.Checked : CheckState.Unchecked);
            }

            comboBox_Players.Text = SelectedGame.SupportedPlayers.ToString();

            for(int i = 0; i < checkedListBox_Platforms.Items.Count; i++)
            {
                Platform plat = (Platform)Enum.Parse(typeof(Platform), checkedListBox_Platforms.Items[i].ToString());
                checkedListBox_Platforms.SetItemChecked(i, SelectedGame.SupportsPlatform(plat));
            }
        }

        private void comboBox_Players_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate { UpdateSelectedGameInfo(); });
        }

        private void checkedListBox_GameTags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate { UpdateSelectedGameInfo(); });
        }

        private void checkedListBox_Platforms_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate { UpdateSelectedGameInfo(); });
        }

        private void UpdateSelectedGameInfo()
        {
            List<string> selectedPlatforms = new List<string>();
            List<string> selectedTags = new List<string>();

            if (SelectedGame == null)
            {
                return;
            }

            if (!int.TryParse(comboBox_Players.Text, out int players))
            {
                players = 6;
            }

            foreach(string selectedPlatform in checkedListBox_Platforms.CheckedItems)
            {
                selectedPlatforms.Add(selectedPlatform);
            }

            foreach(string selectedTag in checkedListBox_GameTags.CheckedItems)
            {
                selectedTags.Add(selectedTag);
            }

            SelectedGame.AddTags(selectedTags.ToArray());
            SelectedGame.SupportedPlatforms = Game.ConvertStringsToPlatform(selectedPlatforms.ToArray());
            SelectedGame.SupportedPlayers = players;
        }

        private void editTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TagEditorForm tagEditor = new TagEditorForm();
            if(tagEditor.ShowDialog() == DialogResult.OK)
            {
                TagManager.SaveTags();
                UpdateTagsLists();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
