using GamePicker;
using GamePickerWeb.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Xml.Serialization;

namespace GamePickerWeb.Models
{
    public static class SeedDataModel
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GamePickerWebContext(serviceProvider.GetRequiredService<DbContextOptions<GamePickerWebContext>>()))
            {
                if(context == null || context.GameModel == null)
                {
                    throw new ArgumentNullException("Game model is null");
                }

                if (context.GameModel.Any())
                {
                    GameLibrary.HoboGameLibrary = context.GameModel.ToList();
                    return;
                }

                DeserializeLibrary();
                context.GameModel.AddRange(GameLibrary.HoboGameLibrary);
                context.SaveChanges();
            }
        }

        public static void DeserializeLibrary()
        {
            XmlSerializer serializer = new XmlSerializer(GameLibrary.HoboGameLibrary.GetType());

            try
            {
                using (StreamReader reader = new StreamReader(@"c:\temp\HoboGameLibrary.xml"))
                {
                    GameLibrary.HoboGameLibrary = (List<GameModel>)serializer.Deserialize(reader);
                    GameLibrary.HoboGameLibrary.Sort();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception hit: {ex.Message}");
            }
        }
    }
}
