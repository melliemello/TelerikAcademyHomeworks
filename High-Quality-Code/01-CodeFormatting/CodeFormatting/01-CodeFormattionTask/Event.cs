namespace CodeFormattionTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;

    internal class Event : IComparable
    {
        public DateTime Date;
        public string Title;
        public string Location;

        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int compareByDate = this.Date.CompareTo(other.Date);
            int compareByTitle = this.Title.CompareTo(other.Title);
            int compareByLocation = this.Location.CompareTo(other.Location);

            if (compareByDate == 0)
            {
                if (compareByTitle == 0)
                {
                    return compareByLocation;
                }
                else
                {
                    return compareByTitle;
                }
            }
            else
            {
                return compareByDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(this.Date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.Title);

            if (this.Location != null && this.Location != string.Empty)
            {
                toString.Append(" | " + this.Location);
            }

            return toString.ToString();
        }
    }
}