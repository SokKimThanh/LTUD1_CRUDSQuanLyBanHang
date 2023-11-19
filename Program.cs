using WinFormsApp2.StoreProcedure.product;

namespace WinFormsApp2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FormProduct());
            MergeSQLFile.MergeSQLFiles(@"C:\SQLFiles", "newfile.sql");

            //MergeSQLFile.MergeSQLFiles(@"F:\TDC_HK3\LTUD1_LETHO\WinFormsApp2\StoreProcedure\product", "ss.sql");
        }
    }
}