using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeBookKeep.Models
{
    [Table("income_cats")]
    public class IncomeCat
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
