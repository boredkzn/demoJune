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
    
    public partial class HistoriaIzmeneniiKolisestvaMterialov
    {
        public int HistoriaIzmeneniiKolisestvaMterialovId { get; set; }
        public int MaterialId { get; set; }
        public int PostavshikId { get; set; }
        public System.DateTime DateAndTime { get; set; }
        public short Kolishestvo { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Postavshik Postavshik { get; set; }
    }
}