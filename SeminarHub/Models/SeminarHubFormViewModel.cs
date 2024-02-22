using System.ComponentModel.DataAnnotations;
using static SeminarHub.Data.DataConstants;


namespace SeminarHub.Models
{
    public class SeminarHubFormViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(SeminarTopicMaximumLength, MinimumLength = SeminarTopicMinimumLength, 
            ErrorMessage = StringLengthErrorMessage)]
        public string Topic { get; set; } = null!;

        [Required(ErrorMessage = RequireErrorMessage)]
         [StringLength(SeminarLecturerMaximumLength, MinimumLength = SeminarLecturerMinimumLength, 
            ErrorMessage = StringLengthErrorMessage)]
        public string Lecturer { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [MaxLength(SeminarDetailsMaximumLength)]
        public string Details { get; set; } = null!;

        [Required(ErrorMessage = RequireErrorMessage)]
        public string DateAndTime { get; set; } = null!;

        [Range(30, 180)]
        public int Duration { get; set; }

        [Required(ErrorMessage = RequireErrorMessage)]
        public int CategoryId { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; } =  new List<CategoryViewModel>();
    }
}
