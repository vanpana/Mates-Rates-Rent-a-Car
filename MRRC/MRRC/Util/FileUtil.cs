using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MRRC.Util
{
    class FileUtil
    {
        private readonly static String DataFolder = "data/";
        private readonly static String FleetCSV = "fleet.csv";
        private readonly static String CustomersCSV = "customers.csv";
        private readonly static String RentalsCSV = "rentals.csv";

        // Mutex for preventing reading from files if they are being created
        private readonly static Mutex mutex = new Mutex();

        /*
         * Getters for CSV files paths.
         * */
        public static String getFleetsFile() { return DataFolder + FleetCSV; }
        public static String getCustomersFile() { return DataFolder + CustomersCSV; }
        public static String getRentalsFile() { return DataFolder + RentalsCSV; }

        /*
         * Initializes file structure.
         * If the directory isn't created, it creates it.
         * If the main CSVs aren't created, they are created empty.
         **/
        public static void InitFileStructure()
        {
            // Acquire the mutex so no thread can access the files if they are being created
            mutex.WaitOne();

            // Create directory if it doesn't exist.
            Directory.CreateDirectory(DataFolder);

            // Create the empty fleet file
            if (!File.Exists(getFleetsFile())) { File.Create(getFleetsFile()).Close(); }

            // Create the empty clients file
            if (!File.Exists(getCustomersFile())) { File.Create(getCustomersFile()).Close(); }

            // Create the empty rentals file
            if (!File.Exists(getRentalsFile())) { File.Create(getRentalsFile()).Close(); }

            // Release the mutex after the files have been created;
            mutex.ReleaseMutex();
        }

        /*
         * Get CSV as a List of array of Strings from a file. 
         * */
        public static List<String[]> ReadCSVFromFile(String pathToFile)
        {
            // Acquire mutex for reading the CSV file
            mutex.WaitOne();

            // If the mutex has been acquired, then it can be released for another thread to read
            mutex.ReleaseMutex();

            List<String[]> result = new List<string[]>();

            // Read all lines from the file at the path specified
            String[] lines = File.ReadAllLines(pathToFile);

            // Create a new list with the values separated by commas
            foreach (String line in lines)
            {
                result.Add(line.Split(','));
            }

            return result;
        }

        /*
         * Save the provided data to the provided file. If the file does not exist, it is created.
         * */
        public static void SaveDataToFile(String pathToFile, String data)
        {
            File.WriteAllText(pathToFile, data);
        }
    }
}
