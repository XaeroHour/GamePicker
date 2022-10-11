namespace GamePickerWeb.Models
{
	public class RandomGameParameters
	{
		public uint SupportedPlayers { get; set; } = 1;

		public bool EnforcePlayerCount { get; set; } = false;

		public int SupportedPlatforms { get; set; } = 0;

		public string RequriedTags { get; set; } = string.Empty;
	}
}
