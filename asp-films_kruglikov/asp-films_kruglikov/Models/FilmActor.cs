//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace asp_films_kruglikov.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FilmActor
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int ActorId { get; set; }
    
        public virtual Actor Actor { get; set; }
        public virtual Film Film { get; set; }
    }
}
