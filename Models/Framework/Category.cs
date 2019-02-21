namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        [DisplayName("Tên danh mục")]
        [Required(ErrorMessage = "Bạn chưa nhập tên danh mục!")]
        public string Name { get; set; }

        [StringLength(50)]
        [DisplayName("Tên viết tắt")]
        public string Alias { get; set; }

        public int? ParentId { get; set; }

        public DateTime? CreateDate { get; set; }

        [DisplayName("Số thứ tự")]
        public int? Idx { get; set; }

        [DisplayName("Trạng thái")]
        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
