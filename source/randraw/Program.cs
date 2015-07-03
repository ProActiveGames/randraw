using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randraw
{
    static class Program
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {
            var args = Environment.GetCommandLineArgs();

            if (args.Length < 2)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                return;
            }

            AllocConsole();
            var help = new StringBuilder("Usage:");
            help.AppendLine();
            help.AppendLine();
            help.AppendLine("randraw apikey input.csv output.csv numdraws /nh");
            help.AppendLine();
            help.AppendLine("- apikey           Your API key to use random.org");
            help.AppendLine("- input.csv        input file (CSV format)");
            help.AppendLine("- output.csv       output file (CSV format) of randomly selected rows");
            help.AppendLine("- numdraws         number for rows to randomly select and output");
            help.AppendLine("- /nh              No Header (optional), specify if csv file does not have a header");
            help.AppendLine();
            help.AppendLine("eg: randraw 9c8c0d38-669f-4524-b03d-fe3309612c86 consumers.csv winners.csv 100");
            
            if (args.Length < 5)
            {
                Console.WriteLine(help);
                Console.ReadLine();
                return;
            }

            var key = args[1];
            var infile = args[2];
            var outfile = args[3];
            var numdraws = Convert.ToInt32(args[4]);
            var noheader = false;
            if (args.Length > 5)
            {
                if (!args[5].Equals("/nh", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Invalid switch '" + args[5] + "'.");
                    Console.WriteLine();
                    Console.WriteLine(help);
                    return;
                }
                noheader = true;
            }
            
            // make sure output path if just a file, saves to executable's folder
            if (outfile.Contains("\\"))
            {
                var thisDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                outfile = System.IO.Path.Combine(thisDir ?? "", System.IO.Path.GetFileName(outfile));
            }

            var random = new RandomDraw();
            random.Run(key, infile, outfile, noheader, numdraws);
            Console.ReadLine();
        }
    }
}
