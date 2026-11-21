using System;
using System.Text;

namespace CampusParcelAssessment
{
    // These supplied checks are only basic examples.
    // Passing them does not show that every assessment requirement is complete.
    public static class TestHarness
    {
        public static string Run()
        {
            StringBuilder report = new StringBuilder();

            report.AppendLine("Campus Parcel Records - basic supplied checks");
            report.AppendLine("Passing these checks does not mean that the assessment is complete.");
            report.AppendLine();

            TestParcelComparisonBasic(report);
            TestBSTBasic(report);
            TestDateSelectionBasic(report);
            TestQuickSortBasic(report);

            report.AppendLine();
            report.AppendLine("Student-written tests");
            report.AppendLine("---------------------");

            // Add your own testing here.

            return report.ToString();
        }

        private static void TestParcelComparisonBasic(StringBuilder report)
        {
            try
            {
                Parcel first = new Parcel(
                    "p101", "Student A", "Library", SampleData.DispatchDate);

                Parcel second = new Parcel(
                    "P101", "Student B", "Arts", SampleData.DispatchDate);

                if (first.CompareTo(second) == 0)
                    report.AppendLine("PASS: basic TrackingId comparison ignores letter case");
                else
                    report.AppendLine("CHECK: basic TrackingId comparison did not give the expected result");
            }
            catch (NotImplementedException)
            {
                report.AppendLine("NOT IMPLEMENTED: Parcel.CompareTo");
            }
            catch (Exception exception)
            {
                report.AppendLine("ERROR in basic Parcel comparison check: "
                    + exception.Message);
            }
        }

        private static void TestBSTBasic(StringBuilder report)
        {
            try
            {
                BSTree<Parcel> tree = new BSTree<Parcel>();

                tree.InsertItem(new Parcel(
                    "P200", "Student A", "Library", SampleData.DispatchDate));

                tree.InsertItem(new Parcel(
                    "P100", "Student B", "Business School", SampleData.DispatchDate));

                string output = "";
                tree.InOrder(ref output);

                report.AppendLine("BST basic in-order output: " + output);
                report.AppendLine("CHECK: both parcels should appear in TrackingId order.");
            }
            catch (NotImplementedException)
            {
                report.AppendLine("NOT IMPLEMENTED: one or more basic BST operations");
            }
            catch (Exception exception)
            {
                report.AppendLine("ERROR in basic BST check: " + exception.Message);
            }
        }

        private static void TestDateSelectionBasic(StringBuilder report)
        {
            try
            {
                DispatchEntry[] selected = Algorithms.SelectParcelsForDate(
                    SampleData.AllParcels(), SampleData.DispatchDate);

                report.AppendLine("Date selection returned "
                    + selected.Length + " parcel(s).");

                for (int i = 0; i < selected.Length; i++)
                    report.AppendLine("  " + selected[i]);

                report.AppendLine(
                    "CHECK: every returned parcel should have the requested date.");
            }
            catch (NotImplementedException)
            {
                report.AppendLine("NOT IMPLEMENTED: SelectParcelsForDate");
            }
            catch (Exception exception)
            {
                report.AppendLine("ERROR in basic date-selection check: "
                    + exception.Message);
            }
        }

        private static void TestQuickSortBasic(StringBuilder report)
        {
            try
            {
                int[] numbers = { 4, 1, 3 };
                Algorithms.QuickSortGen(numbers);

                report.Append("QuickSort basic output: ");

                for (int i = 0; i < numbers.Length; i++)
                    report.Append(numbers[i] + " ");

                report.AppendLine();
                report.AppendLine("CHECK: the values should appear in ascending order.");
            }
            catch (NotImplementedException)
            {
                report.AppendLine("NOT IMPLEMENTED: QuickSortGen");
            }
            catch (Exception exception)
            {
                report.AppendLine("ERROR in basic QuickSort check: "
                    + exception.Message);
            }
        }
    }
}
