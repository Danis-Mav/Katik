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
    
    public partial class PhotoApartament
    {
        public int Id { get; set; }
        public Nullable<int> Id_Ap { get; set; }
        public string Photo { get; set; }
    
        public virtual Apartment Apartment { get; set; }
    }
}
