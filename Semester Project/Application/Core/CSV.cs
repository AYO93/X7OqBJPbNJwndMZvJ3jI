/**
 * Regent University College of Science and Technology
 * ---------------------------------------------------
 * Course: Application Programming with C#
 * Student: Tobias Manuel Poganiuch
 * ---------------------------------------------------
 * Class: CSV
 * Date: 2013-12-05
 * Version: 1.0
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PointOfSale
{
    class CSV
    {
        public List<String[]> read(String path)
        {
            String[] lines = null;
            List<String[]> data = new List<String[]>();
            StreamReader streamReader = new StreamReader(path); // Open StreamReader

            // Read the data from the file and split it at the end of each line
            lines = streamReader.ReadToEnd().Split('\n');

            // Split every line into columns and add them to the data list
            foreach (String line in lines)
                if (line.Trim() != "")
                    data.Add(line.Split(';'));

            streamReader.Close();

            return data;
        } // read : method

        public void write(String path, List<String[]> data)
        {
            String line = null;

            // Clear file
            File.WriteAllText(path, string.Empty);

            // Open StreamWriter
            StreamWriter streamWriter = new StreamWriter(path);

            foreach (String[] row in data)
            {
                // Put the columns together to one line
                line = row[0] + ";" + row[1] + ";" + row[2] + ";" + row[3].TrimEnd('\r', '\n');
                // Write the line to the file
                streamWriter.WriteLine(line);
            }

            streamWriter.Close();
        } // write : method

    } // CSV : class
} // namespace
