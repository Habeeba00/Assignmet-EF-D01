﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Assignmet_EF_D01.Models;

public partial class Ins_Course
{
    public int Ins_Id { get; set; }

    public int Crs_Id { get; set; }

    public string Evaluation { get; set; }

    public virtual Course Crs { get; set; }

    public virtual Instructor Ins { get; set; }
}