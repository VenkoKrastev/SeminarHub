using SeminarHub.Data;

namespace SeminarHub.Models
{
    public class SeminarInfoViewModel
    {
        public SeminarInfoViewModel(int id, string topic, string lecturer, int category, DateTime dateAndTime, string organizer)
        {
            Id = id;
            Topic = topic;
            Lecturer = lecturer;
            Category = category;
            Organizer = organizer;
            DateAndTime = dateAndTime.ToString(DataConstants.DateFormat);
        }

        public int Id { get; set; }

        public string Topic { get; set; }

        public string Lecturer { get; set; }

        public int Category { get; set; }

        public string DateAndTime { get; set; } = null!;

        public string Organizer { get; set; }
    }
}
