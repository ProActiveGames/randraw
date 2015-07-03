using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randraw
{
    class Program
    {
        static void Main(string[] args)
        {
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
            help.AppendLine("eg: randraw consumers.csv winners.csv 100");
            
            if (args.Length < 4)
            {
                Console.WriteLine(help);
                return;
            }

            var key = args[0];
            var infile = args[1];
            var outfile = args[2];
            var numdraws = Convert.ToInt32(args[3]);
            var noheader = false;
            if (args.Length > 4)
            {
                if (!args[4].Equals("/nh", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Invalid switch '" + args[4] + "'.");
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
        }
    }
}
