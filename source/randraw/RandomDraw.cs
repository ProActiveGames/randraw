using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randraw
{
    class RandomDraw
    {
        public void Run(
            string key, string inpath, string outpath, 
            bool noHeader, int numRowsToSelect)
        {
            // load into list
            var rows = new List<string>();
            using (var rdr = new StreamReader(File.OpenRead(inpath)))
            {
                while (!rdr.EndOfStream)
                {
                    rows.Add(rdr.ReadLine());
                }
            }
            Console.WriteLine("Loaded " + rows.Count + " rows.");

            // determine row limits
            var rowMin = 1;
            var rowMax = rows.Count;
            if (!noHeader) rowMin++;
            if (numRowsToSelect > rowMax - rowMin + 1) numRowsToSelect = rowMax - rowMin + 1;
            Console.WriteLine("Retrieving random " + numRowsToSelect + " rows between "
                + rowMin + " and " + rowMax + ".");

            // get randoms
            var rclient = new Demot.RandomOrgApi.RandomOrgApiClient(key);
            var rs = rclient.GenerateIntegers(numRowsToSelect, rowMin, rowMax, false);
            var randomRows = rs.Integers.ToList();

            // output
            using (TextWriter writer = File.CreateText(outpath))
            {
                if (!noHeader) writer.WriteLine(rows[0]);
                foreach (var randomi in randomRows)
                {
                    var line = rows.ElementAtOrDefault(randomi - 1);
                    if (line != null) writer.WriteLine(line);
                }
            }
            Console.WriteLine("Output to " + outpath + " completed.");
        }
    }
}
