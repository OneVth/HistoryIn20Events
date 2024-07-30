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
        string name;
        string description;
        string extraDescription;

        public string Year { get { return year; } private set { year = value; } }
        public string Name { get { return name; } private set { name = value; } }
        public string Description { get { return description; } private set { description = value; } }
        public string ExtraDescription { get { return extraDescription; } private set { extraDescription = value; } }

        public HistoricalEvent(string year, string name, string description)
        {
            Year = year;
            Name = name;
            Description = description;
            ExtraDescription = null;
        }

        public HistoricalEvent(string year, string name, string description, string extraDescription)
        {
            Year = year;
            Name = name;
            Description = description;
            ExtraDescription = extraDescription;
        }

        public bool ContainsExtraDescription() => !string.IsNullOrEmpty(ExtraDescription);
    }
}
