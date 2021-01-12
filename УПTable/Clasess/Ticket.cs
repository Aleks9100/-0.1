namespace УПTable
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Ticket { get; set; }

        public int? Id_Warehouse { get; set; }

        public int? Id_Item { get; set; }

        public int? Id_Buyer { get; set; }

        public int? Id_Employee { get; set; }

        public int? Quantity { get; set; }

        public bool Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? Result { get; set; }

        public virtual Buyer Buyer { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Item Item { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
