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
    
    public partial class BD10_Аксессуары
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BD10_Аксессуары()
        {
            this.BD10_Критерии_доставки = new HashSet<BD10_Критерии_доставки>();
            this.BD10_Лодочные_аксессуары = new HashSet<BD10_Лодочные_аксессуары>();
        }
    
        public int Код_Аксессуара { get; set; }
        public string Название { get; set; }
        public string Описание { get; set; }
        public string Цена { get; set; }
        public string НДС { get; set; }
        public string Инвентарь { get; set; }
        public string Уровень_порядка { get; set; }
        public string Набор_заказов { get; set; }
        public Nullable<int> Код_партнера { get; set; }
    
        public virtual BD10_Партнеры BD10_Партнеры { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BD10_Критерии_доставки> BD10_Критерии_доставки { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BD10_Лодочные_аксессуары> BD10_Лодочные_аксессуары { get; set; }
    }
}
