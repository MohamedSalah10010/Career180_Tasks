﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CRUD_Operations.Models;

public partial class Student
{
    public int ID { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public string City { get; set; }

    public int? TrackID { get; set; }

    public virtual Track Track { get; set; }
}