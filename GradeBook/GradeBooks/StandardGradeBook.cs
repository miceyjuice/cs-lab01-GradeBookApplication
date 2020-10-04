﻿using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks 
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool condition) : base(name, condition)
        {
            Type = Enums.GradeBookType.Standard;

        }
    }
}