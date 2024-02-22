using SeminarHub.Data.Models;
using System;

namespace SeminarHub.Models
{
    public class SeminarHubDetailViewModel
    {
        public string Lecturer { get; set; }

        public string Duration { get; set; }

        public string DateAndTime { get; set; }

        public string Category { get; set; }

        public string Topic { get; set; }

        public string Details { get; set; }

        public string Organizer { get; set; }

        public int Id { get; set; }

    }
}
 //< p class= "mb-0" >< span class= "fw-bold" > Starting Time: </ span > @Model.DateAndTime </ p >
 //           < p class= "mb-0" >< span class= "fw-bold" > Seminar Duration: </ span > @Model.Duration </ p >
 //           < p class= "mb-0" >< span class= "fw-bold" > Lecturer: </ span > @Model.Lecturer </ p >
 //           < p class= "mb-0" >< span class= "fw-bold" > Category: </ span > @Model.Category </ p >
 //           < p class= "mb-0" >< span class= "fw-bold" > Details: </ span > @Model.Details </ p >