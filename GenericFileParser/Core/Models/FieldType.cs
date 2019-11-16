using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public sealed class FieldType
    {
        public string Name { get; set; }
        public int StartPosition { get; set; }
        public int Length { get; set; }

        public RowType Row { get; set; }
    }
}
