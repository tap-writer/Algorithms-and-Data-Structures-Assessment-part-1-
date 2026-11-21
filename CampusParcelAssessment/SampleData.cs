using System;

namespace CampusParcelAssessment
{
    public static class SampleData
    {
        // A fixed fictional date makes everyone's sample output the same.
        public static readonly DateTime DispatchDate = new DateTime(2026, 10, 1);

        public static Parcel[] AllParcels()
        {
            return new Parcel[]
            {
                new Parcel("P103", "A. Patel", "Library", DispatchDate.AddHours(10)),
                new Parcel("P101", "B. Chen", "Engineering", DispatchDate.AddHours(15)),
                new Parcel("P105", "C. Jones", "Business", DispatchDate.AddHours(9)),
                new Parcel("P102", "D. Smith", "Arts", DispatchDate.AddHours(12)),
                new Parcel("P104", "E. Ali", "Science", DispatchDate.AddHours(10)),
                new Parcel("P106", "F. Brown", "Sports Centre", DispatchDate.AddDays(1).AddHours(9))
            };
        }

        public static CustomQueue<Parcel> ArrivalQueue()
        {
            CustomQueue<Parcel> queue = new CustomQueue<Parcel>();
            foreach (Parcel parcel in AllParcels())
                queue.Enqueue(parcel);
            return queue;
        }

        public static string[] RotationNames()
        {
            return new string[] { "Right-single", "Left-single", "Left-right", "Right-left" };
        }

        public static string[][] RotationIds()
        {
            return new string[][]
            {
                new string[] { "P030", "P020", "P010" },
                new string[] { "P010", "P020", "P030" },
                new string[] { "P030", "P010", "P020" },
                new string[] { "P010", "P030", "P020" }
            };
        }
    }
}
