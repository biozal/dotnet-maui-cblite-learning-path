using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couchbase.Maui.Inventory.Models
{
    internal record Project
    {
        public string ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isComplete { get; set; }
        public string DocumentType { get; set; } = "project";
        public DateTime DueDate { get; set; }
        public Warehouse? Warehouse { get; set; }
        public string Team { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
