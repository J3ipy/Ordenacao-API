//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TarefaMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarefa
    {
        public int TARID { get; set; }
        public string TARDESCRICAO { get; set; }
        public System.DateTime TARDATA { get; set; }
        public bool TARFEITO { get; set; }
        public int PESID { get; set; }
    
        public virtual Pessoa Pessoa { get; set; }
    }
}
