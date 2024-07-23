using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryIn20Events
{
    internal class HistoricalEvent
    {
        string year;
        string @event;
        string description;
        string extraDescription;

        public string Year { get { return year; } private set { year = value; } }
        public string Event { get { return @event; } private set { @event = value; } }
        public string Description { get { return description; } private set { description = value; } }
        public string ExtraDescription { get { return extraDescription; } private set { extraDescription = value; } }

        public HistoricalEvent(string year, string @event, string description)
        {
            Year = year;
            Event = @event;
            Description = description;
            ExtraDescription = null;
        }

        public HistoricalEvent(string year, string @event, string description, string extraDescription)
        {
            Year = year;
            Event = @event;
            Description = description;
            ExtraDescription = extraDescription;
        }

        public bool ContainsExtraDescription() => !string.IsNullOrEmpty(ExtraDescription);
    }
}
