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
        public static Main mainForm = new Main();

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(mainForm);
        }
    }
}