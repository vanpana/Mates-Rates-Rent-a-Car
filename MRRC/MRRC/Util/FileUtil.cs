using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Util
{
    class FileUtil
    {
        private readonly static String DataFolder = "data/";
        private readonly static String FleetCSV = "fleet.csv";
        private readonly static String ClientsCSV = "clients.csv";
        private readonly static String RentalsCSV = "rentals.csv";
        
        /*
         * Getters for CSV files paths.
         * */
        public static String getFleetsFile() { return DataFolder + FleetCSV; }
        public static String getClientsFile() { return DataFolder + ClientsCSV; }
        public static String getRentalsFile() { return DataFolder + RentalsCSV; }

        /*
         * Initializes file structure.
         * If the directory isn't created, it creates it.
         * If the main CSVs aren't created, they are created empty.
         **/
        private static void InitFileStructure()
        {
            // Create directory if it doesn't exist.
            System.IO.Directory.CreateDirectory(DataFolder);

            // Create the empty fleet file
            if (!File.Exists(getFleetsFile())) { File.Create(getFleetsFile()); }

            // Create the empty clients file
            if (!File.Exists(getClientsFile())) { File.Create(getClientsFile()); }

            // Create the empty rentals file
            if (!File.Exists(getRentalsFile())) { File.Create(getRentalsFile()); }
        }

        public static List<String[]> ReadCSVFromFile(String pathToFile)
        {
            List<String[]> result = new List<string[]>();
            String[] lines = File.ReadAllLines(pathToFile);

            foreach (String line in lines)
            {
                result.Add(line.Split(','));
            }

            return result;
        }
    }
}
