﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CRUD_Operations.Models;

public partial class Track
{
    public int ID { get; set; }

    public string Name { get; set; }

    public string Location { get; set; }

    public string Duration { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}