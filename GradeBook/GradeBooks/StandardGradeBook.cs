using System;
using System.Collections.Generic;
using System.Text;
using Enums;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            this.Type = Enums.GradeBookType.Standard;
        }
    }
}
