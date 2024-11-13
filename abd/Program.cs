using Student.AO.forme;

namespace Student.AO
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                Application.Run(new frmPocetna());
            }
            catch (Exception ex)
            {
                File.WriteAllText("error_log.txt", $"Exception: {ex.Message}\nStackTrace: {ex.StackTrace}");
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
    }
}