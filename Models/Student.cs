using System;
using System.Collections.Generic;

namespace web_api_crud.Models;

public partial class Student
{
    public string StudentId { get; set; } = null!;

    public string? Gender { get; set; }

    public string? NationalIty { get; set; }

    public string? PlaceofBirth { get; set; }

    public string? StageId { get; set; }

    public string? GradeId { get; set; }

    public string? SectionId { get; set; }

    public string? Topic { get; set; }

    public string? Semester { get; set; }

    public string? Relation { get; set; }

    public int? Raisedhands { get; set; }

    public int? VisItedResources { get; set; }

    public int? AnnouncementsView { get; set; }

    public int? Discussion { get; set; }

    public string? ParentAnsweringSurvey { get; set; }

    public string? ParentschoolSatisfaction { get; set; }

    public string? StudentAbsenceDays { get; set; }

    public int? StudentMarks { get; set; }

    public string? Class { get; set; }
}
