using System;

namespace CampusParcelAssessment
{
    public class DispatchEntry : IComparable
    {
        private Parcel parcel;

        public DispatchEntry(Parcel parcel)
        {
            Parcel = parcel;
        }

        public Parcel Parcel
        {
            get { return parcel; }
            set { parcel = value; }
        }

        public DateTime GetDeliveryDeadline() 
        { 
            return parcel.DeliveryDeadline; 
        }

        // Task C: compare by deadline
        public int CompareTo(object obj)
        {
            throw new NotImplementedException("Task C: implement DispatchEntry.CompareTo.");
        }

        public override string ToString()
        {
            return GetDeliveryDeadline().ToString("dd MMM HH:mm") + " - "
                + parcel.TrackingId + " to " + parcel.DestinationBuilding;
        }
    }
}
