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
    
    public partial class Zaiavka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zaiavka()
        {
            this.IstoriaIzmeneniMinStoimostDlaAgent = new HashSet<IstoriaIzmeneniMinStoimostDlaAgent>();
        }
    
        public int ZaiavkaId { get; set; }
        public int AgentId { get; set; }
        public string FamiliaMenedjrea { get; set; }
        public string ImaMenedjrea { get; set; }
        public string OthestvoMenedjrea { get; set; }
        public System.DateTime DataZaiavki { get; set; }
        public System.TimeSpan VremaProizvodstva { get; set; }
        public short KolishestvoProdyctii { get; set; }
        public string OrganizashiaDostavki { get; set; }
        public decimal StoimostPredoplati { get; set; }
        public decimal StoimostProisvodstva { get; set; }
        public bool StatysPredoplaty { get; set; }
        public bool StatysPolnoiOplaty { get; set; }
        public bool StatysZaversheniaZaiavki { get; set; }
        public int ProductshiaId { get; set; }
    
        public virtual Agent Agent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IstoriaIzmeneniMinStoimostDlaAgent> IstoriaIzmeneniMinStoimostDlaAgent { get; set; }
        public virtual Productshia Productshia { get; set; }
    }
}