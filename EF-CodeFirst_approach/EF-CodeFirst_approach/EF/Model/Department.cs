﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF_CodeFirst_approach.EF.Model
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DepartmentName { get; set; }
    }
}