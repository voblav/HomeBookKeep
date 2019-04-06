using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeBookKeep.Models
{
    [Table("cost_cats")]
    public class CostCat
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
