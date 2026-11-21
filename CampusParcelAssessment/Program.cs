using System;
using System.IO;

namespace CampusParcelAssessment
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Campus Parcel Records - Assessment 1 starter");
            Console.WriteLine("All supplied parcels:");
            foreach (Parcel parcel in SampleData.AllParcels())
                Console.WriteLine("  " + parcel);

            Console.WriteLine();
            string report = TestHarness.Run();
            Console.Write(report);

            string outputPath = Path.Combine(Environment.CurrentDirectory, "output.txt");
            File.WriteAllText(outputPath, report);
            Console.WriteLine("Report saved to " + outputPath);
        }
    }
}
