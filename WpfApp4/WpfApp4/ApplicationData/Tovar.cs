//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp4.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tovar
    {
        public string ID_tovara { get; set; }
        public string Nazvanie_tovara { get; set; }
        public int Kategoriya_tovara { get; set; }
        public int Skidka { get; set; }
        public int Kolichestvo__Na_Sklade { get; set; }
        public string Opisanie { get; set; }
        public string Izobrajenie { get; set; }
    
        public virtual Kategorii_tovara Kategorii_tovara { get; set; }
    }
}
