//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lodki
{
    using System;
    using System.Collections.Generic;
    
    public partial class BD10_Менеджеры
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BD10_Менеджеры()
        {
            this.BD10_Доставка = new HashSet<BD10_Доставка>();
        }
    
        public int Код_менеджера { get; set; }
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public Nullable<int> Код_пользователя { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BD10_Доставка> BD10_Доставка { get; set; }
    }
}
