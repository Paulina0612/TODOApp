using TODOApp.Forms;

namespace TODOApp
{
    public class Task
    {
        public string? Name;
        public string? Description;
        public DateTime? DueDate;
        public bool? Status;
        public bool? Priority;
    }

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
            Application.Run(new Main());
        }
    }
}