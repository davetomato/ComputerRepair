using FixFlow.Forms;
using FixFlow.Services;

namespace FixFlow
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //try { new AuthService().ReplacePlaceholderPasswords("Fix@1234"); }
            //catch (Exception ex) { MessageBox.Show(ex.Message, "Setup"); }

            Application.Run(new LandingForm());
        }
    }
}