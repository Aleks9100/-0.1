namespace УПTable
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entrance")]
    public partial class Entrance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Entrance { get; set; }

        public int? Id_Supplier { get; set; }

        public int? Id_Employee { get; set; }

        public int? Id_Item { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Item Item { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
