//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desafio_WF_V3.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ERTE
    {
        public int Id_erte { get; set; }
        public string Empresa { get; set; }
        public System.DateTime Fecha_inicio { get; set; }
        public Nullable<System.DateTime> Fecha_fin { get; set; }
    
        public virtual EMPRESA EMPRESA1 { get; set; }
    }
}
