//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laba3
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHARACTERS
    {
        public int CHARACTERID { get; set; }
        public string NAMEe { get; set; }
        public Nullable<int> GAMEID { get; set; }
        public string DESCRIPTIONn { get; set; }
    
        public virtual GAMES GAMES { get; set; }
    }
}