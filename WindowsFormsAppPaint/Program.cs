using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Jokedst.GetOpt;
using WindowsFormsAppPaint;

namespace WindowsFormsAppPaint
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 myForm = new Form1();
            // For the sake of this example, we're just printing the arguments to the console.

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("args[{0}] == {1}", i, args[i]);
            }
            // Tim hieu va phan tich bang GetOpt
           
            string paramFileName = string.Empty;
            var opt = new GetOpt("Chuong trinh ky ten",
            new[] {
                 new CommandLineOption('s', "save", "Luu file voi ten da duoc quy uoc", ParameterType.String, o => paramFileName = (string)o),
            });
            myForm.DestinationFileName = paramFileName;            
             Application.Run(myForm);
        }
    }
}
