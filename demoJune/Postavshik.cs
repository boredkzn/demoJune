//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demoJune
{
    using System;
    using System.Collections.Generic;
    
    public partial class Postavshik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Postavshik()
        {
            this.HistoriaIzmeneniiKolisestvaMterialov = new HashSet<HistoriaIzmeneniiKolisestvaMterialov>();
        }
    
        public int PostavshikId { get; set; }
        public int MaterialId { get; set; }
        public byte TipPostavshikaId { get; set; }
        public string Naimenovanie { get; set; }
        public string Inn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoriaIzmeneniiKolisestvaMterialov> HistoriaIzmeneniiKolisestvaMterialov { get; set; }
        public virtual Material Material { get; set; }
        public virtual TipPostavshika TipPostavshika { get; set; }
    }
}