using System.ComponentModel.DataAnnotations;

namespace GamePickerWeb.Models
{
    public class PickedGameModel
    {
        public int Id { get; set; } = 0;

        public string GameName { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DateTimePicked { get; set; } = DateTime.MinValue;
    }
}
