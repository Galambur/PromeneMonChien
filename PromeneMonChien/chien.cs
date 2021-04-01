namespace PromeneMonChien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("promenemonchien.chien")]
    public partial class chien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public chien()
        {
            promenades = new HashSet<promenade>();
        }

        [Key]
        public int idChien { get; set; }

        [Required]
        [StringLength(50)]
        public string nomChien { get; set; }

        public int idType { get; set; }

        public int idUtilisateur { get; set; }

        [StringLength(250)]
        public string description { get; set; }

        public virtual type type { get; set; }

        public virtual utilisateur utilisateur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<promenade> promenades { get; set; }
    }
}
