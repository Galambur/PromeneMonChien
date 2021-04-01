namespace PromeneMonChien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("promenemonchien.utilisateur")]
    public partial class utilisateur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public utilisateur()
        {
            chiens = new HashSet<chien>();
            promenades = new HashSet<promenade>();
        }

        [Key]
        public int idUtilisateur { get; set; }

        [Required]
        [StringLength(50)]
        public string nomUtilisateur { get; set; }

        [Required]
        [StringLength(50)]
        public string prenomUtilisateur { get; set; }

        public bool proprietaire { get; set; }

        public int? idVille { get; set; }

        [StringLength(50)]
        public string telephone { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string mdp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chien> chiens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<promenade> promenades { get; set; }

        public virtual ville ville { get; set; }
    }
}
