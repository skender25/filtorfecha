//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demolun
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BIBLIOTECAEntities : DbContext
    {
        public BIBLIOTECAEntities()
            : base("name=BIBLIOTECAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LIBRO> LIBRO { get; set; }
    
        public virtual ObjectResult<getrecors_Result> getrecors(Nullable<System.DateTime> start, Nullable<System.DateTime> end)
        {
            var startParameter = start.HasValue ?
                new ObjectParameter("start", start) :
                new ObjectParameter("start", typeof(System.DateTime));
    
            var endParameter = end.HasValue ?
                new ObjectParameter("end", end) :
                new ObjectParameter("end", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getrecors_Result>("getrecors", startParameter, endParameter);
        }
    
        public virtual ObjectResult<LIBRO> GetFuntion(Nullable<System.DateTime> start, Nullable<System.DateTime> end)
        {
            var startParameter = start.HasValue ?
                new ObjectParameter("start", start) :
                new ObjectParameter("start", typeof(System.DateTime));
    
            var endParameter = end.HasValue ?
                new ObjectParameter("end", end) :
                new ObjectParameter("end", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LIBRO>("GetFuntion", startParameter, endParameter);
        }
    
        public virtual ObjectResult<LIBRO> GetFuntion(Nullable<System.DateTime> start, Nullable<System.DateTime> end, MergeOption mergeOption)
        {
            var startParameter = start.HasValue ?
                new ObjectParameter("start", start) :
                new ObjectParameter("start", typeof(System.DateTime));
    
            var endParameter = end.HasValue ?
                new ObjectParameter("end", end) :
                new ObjectParameter("end", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LIBRO>("GetFuntion", mergeOption, startParameter, endParameter);
        }
    }
}
