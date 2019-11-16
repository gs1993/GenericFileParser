using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public sealed class RowType
    {
        public string Name { get; set; }
        public string Header { get; set; }
        public string ConnectionString { get; set; }
        public string TableName { get; set; }

        public FileSchema File { get; set; }
        public List<FieldType> Fields { get; set; }
    }
}
 