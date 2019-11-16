using Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public sealed class FileSchema
    {
        public string Name { get; set; }
        public string Exstension { get; set; }
        public FileSchemaFormatType Format { get; set; }

        public List<RowType> Rows { get; set; }

    }
}
