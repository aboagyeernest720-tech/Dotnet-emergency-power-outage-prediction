using SmartPowerOutageSystem.Data;
namespace SmartPowerOutageSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Fix for high-resolution screens and scaling (125%+)
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Global Exception Handling
            Application.ThreadException += (s, e) => MessageBox.Show(e.Exception.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Initialize database tables
            DatabaseHelper.InitializeDatabase();

            ApplicationConfiguration.Initialize();
            Application.Run(new SmartPowerOutageSystem.Forms.LoginForm());
        }
    }
}