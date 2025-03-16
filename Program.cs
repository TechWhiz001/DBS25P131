namespace DBS25P131
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
            //Application.Run(new loginForm());
            //Application.Run(new DBS25P131.HeadDepartment());
            //Application.Run(new DBS25P131.HeadDepart());

            Application.Run(new DBS25P131.signUp());

        }
    }
}