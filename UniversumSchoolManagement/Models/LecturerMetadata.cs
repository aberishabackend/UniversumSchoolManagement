using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace UniversumSchoolManagement.Data
{
    public class LecturerMetadata
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;
    }

    [ModelMetadataType(typeof(LecturerMetadata))]
    public partial class Lecturer { }
}
