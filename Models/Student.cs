using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web_api_crud.Models;

public partial class Student
{
    /// <summary>
    /// Student Id Enter as String (Limit 10) Sample Format => "STDN00001"
    /// </summary>
    [Required(ErrorMessage = "ID is Required")]
    public string StudentId { get; set; } = null!;
    /// <summary>
    /// Student Gender  Enter as Char (Limit 1) Sample Format => "M/F"
    /// </summary>
    public string? Gender { get; set; }
    /// <summary>
    /// Student Nationality Enter as String (Limit 50) Sample Format => "IN/KW"
    /// </summary>

    public string? NationalIty { get; set; }
    /// <summary>
    /// Student PlaceOfBirth Enter as String (Limit 50) Sample Format => "India/Russia"
    /// </summary>

    public string? PlaceofBirth { get; set; }
    /// <summary>
    /// Student StageId Enter as String (Limit 20) Sample Format => "Lower/Level"
    /// </summary>

    public string? StageId { get; set; }
    /// <summary>
    /// Student GradeId Enter as String (Limit 10) Sample Format => "G-04"
    /// </summary>

    public string? GradeId { get; set; }
    /// <summary>
    /// Student SectionId Enter as Char (Limit 1) Sample Format => "G-04"
    /// </summary>

    public string? SectionId { get; set; }
    /// <summary>
    /// Student Topic Enter as Char (Limit 1) SSample Format => "A/B"
    /// </summary>

    public string? Topic { get; set; }
    /// <summary>
    /// Student Topic Enter as String (Limit 50) Sample Format => "French/Science"
    /// </summary>

    public string? Semester { get; set; }
    /// <summary>
    /// Student Semester Enter as Char (Limit 1) Sample Format => "S/F"
    /// </summary>


    public string? Relation { get; set; }
    /// <summary>
    /// Student Relation Enter as String (Limit 20) Sample Format => "Mother/Father"
    /// </summary>


    public int? Raisedhands { get; set; }
    /// <summary>
    /// Raisedhands Enter as Int  Sample Format => "90"
    /// </summary>


    public int? VisItedResources { get; set; }
    /// <summary>
    /// VisItedResources  Enter as Int  Sample Format => "80"
    /// </summary>


    public int? AnnouncementsView { get; set; }
    /// <summary>
    /// AnnouncementsView Enter as Int  Sample Format => "97"
    /// </summary>


    public int? Discussion { get; set; }
    /// <summary>
    /// Student Discussion Enter as Int  Sample Format => "70"
    /// </summary>


    public string? ParentAnsweringSurvey { get; set; }
    /// <summary>
    /// ParentAnsweringSurvey Enter as String (Limit 3) SSample Format => "Yes/No"
    /// </summary>


    public string? ParentschoolSatisfaction { get; set; }
    /// <summary>
    /// ParentSchoolSatisfaction  Enter as Stringb  (Limit 10) Sample Format => "Good/Bad"
    /// </summary>


    public string? StudentAbsenceDays { get; set; }
    /// <summary>
    /// Student AbsenceDays Enter as String (Limit 10) Sample Format => "Under-10"
    /// </summary>

    [Range(0,99)]
    public int? StudentMarks { get; set; }
    /// <summary>
    /// Student Marks Enter as Int  Sample Format => "93"
    /// </summary>

    
    public string? Class { get; set; }
    /// <summary>
    /// Student SectionId Enter as Int  Sample Format => ""
    /// </summary>

}
