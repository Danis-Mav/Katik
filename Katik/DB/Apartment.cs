//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Katik.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Apartment()
        {
            this.PhotoApartament = new HashSet<PhotoApartament>();
        }
    
        public int Id { get; set; }
        public int RoomSum { get; set; }
        public string Adress { get; set; }
        public int Price { get; set; }
        public int LivingSpace { get; set; }
        public int Id_User { get; set; }
        public Nullable<int> Id_Region { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual User User { get; set; }
        public virtual Region Region { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhotoApartament> PhotoApartament { get; set; }
    }
}