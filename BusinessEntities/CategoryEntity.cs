using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessEntities
{
   public class CategoryEntity
    {
        public System.Guid catID { get; set; }
        public string catName { get; set; }
        public string catDescription { get; set; }
        public Nullable<System.DateTime> catCreatedOn { get; set; }
        public string catCreatedBy { get; set; }
        public Nullable<System.DateTime> catModifiedOn { get; set; }
        public string catModifiedBy { get; set; }
        public Nullable<bool> catIsDeleted { get; set; }
        public Nullable<bool> catIsActive { get; set; }
        public int MaxRows { get; set; }
    }
}
