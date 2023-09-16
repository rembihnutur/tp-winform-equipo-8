using System.Globalization;

namespace TP2
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

            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.NumberFormat.NumberDecimalSeparator = "."; //Forzamos a utilizar el . en lugar de la , para evitar problemas entre las distintas regiones que puede tomar Windows.
            culture.NumberFormat.CurrencyDecimalSeparator = ".";
            culture.NumberFormat.NumberDecimalDigits = 2;
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;

            Application.Run(new Form1());
        }
    }
}