namespace PromeneMonChien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("promenemonchien.promenade")]
    public partial class promenade
    {
        [Key]
        public int idPromenade { get; set; }

        public DateTime datePromenade { get; set; }

        public int? idUtilisateur { get; set; }

        public int? idChien { get; set; }

        public virtual chien chien { get; set; }

        public virtual utilisateur utilisateur { get; set; }
    }
}
