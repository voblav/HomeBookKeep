using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeBookKeep.Models
{
    [Table("cost_sub_cats")]
    public class CostSubCat
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public int IdCats { get; set; }

        public virtual CostCat CostCat { get; set; }

    }
}
