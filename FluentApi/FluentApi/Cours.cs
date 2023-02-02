namespace FluentApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courses")]
    public partial class Cours
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cours()
        {
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public float FullPrice { get; set; }

        public int  Author_Id { get; set; }
           
        
        [Required]
        public string Name { get; set; }

        public Cover Cover { get; set; }
        public virtual Author Author { get; set; }
        public int AuthorID { get; set; }
       public virtual ICollection<Tag> Tags { get; set; }
    }
}
