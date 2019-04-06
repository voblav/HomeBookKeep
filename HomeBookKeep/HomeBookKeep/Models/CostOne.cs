using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeBookKeep.Models
{
    [Table("cost_one")]
    public class CostOne
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public decimal Sum { get; set; }
        public decimal Quantity { get; set; }

        public virtual CostCat CostCat { get; set; }
        public virtual CostSubCat CostSubCat { get; set; }
        public virtual Purse Purse { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
