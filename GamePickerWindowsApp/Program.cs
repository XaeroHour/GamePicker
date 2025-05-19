using GamePicker;
using HoboNightGamePicker;

namespace GamePickerWindowsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_HoboNightGamePicker());
            GameLibrary.SaveLibraryToSQL();
        }
    }
}
