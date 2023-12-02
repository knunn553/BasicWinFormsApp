namespace WinFormsApp
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
            Application.Run(new Form());
        }

        // This is interesting. In the Tournament Tracker Application, we had to add an app.config file.
        // I didn't know until now that an app.config file is a xml file and should be added as such
        // We will have to go back and fix this.
    }
}