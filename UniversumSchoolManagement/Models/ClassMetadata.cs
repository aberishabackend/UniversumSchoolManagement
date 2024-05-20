using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace UniversumSchoolManagement.Data;

public class ClassMetadata
{
    [Display(Name = "Lecturer")]
    public int LecturerId { get; set; }

    [Display(Name = "Course")]
    public int CourseId { get; set; }
}

[ModelMetadataType(typeof(ClassMetadata))]
public partial class Class { }
