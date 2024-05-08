using System.Globalization;

namespace AwesomeDevEventsApi.Entities
{
    public class DevEventSpeaker
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public String TalkTitle { get; set; }
        public string TalkDescription { get; set;}
        public string LinkedInProfile { get; set; }
    }
}