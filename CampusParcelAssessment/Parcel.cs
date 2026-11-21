using System;

namespace CampusParcelAssessment
{
    public class Parcel : IComparable
    {
        private string trackingId;
        private string recipient;
        private string destinationBuilding;
        private DateTime deliveryDeadline;

        public Parcel(string trackingId, string recipient, string destinationBuilding, DateTime deliveryDeadline)
        {
            TrackingId = trackingId;
            Recipient = recipient;
            DestinationBuilding = destinationBuilding;
            DeliveryDeadline = deliveryDeadline;
        }

        public string TrackingId
        {
            get {  return trackingId; }
            set { trackingId = value; }
        }
        public string DestinationBuilding
        {
            get { return destinationBuilding; }
            set { destinationBuilding = value; }
        }
        public DateTime DeliveryDeadline
        {
            get { return deliveryDeadline; }
            set { deliveryDeadline = value; }
        }
        public string Recipient
        {
            get { return recipient; }
            set { recipient = value; }
        }

      
        // Task A: compare TrackingId values without regard to letter case.
        public int CompareTo(object obj)
        {
            String temp = trackingId.ToLower();
            String temp2 = ((Parcel)obj).TrackingId.ToLower();
            return temp.CompareTo(temp2);
        }

        public override string ToString()
        {
            return trackingId + " (" + recipient + ", " + destinationBuilding
                + ", due " + deliveryDeadline.ToString("dd MMM HH:mm") + ")";
        }
    }
}
