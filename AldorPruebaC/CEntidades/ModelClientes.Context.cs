﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CEntidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Clientes_AREntities : DbContext
    {
        public Clientes_AREntities()
            : base("name=Clientes_AREntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
    
        public virtual int STPR_CLIENTES_PRUEBA_MANTENIMIENTE(string aCCION, string nOMBRE, Nullable<decimal> iDENTIFICACION, Nullable<decimal> tELEFONO, Nullable<int> iD, ObjectParameter p_Mensaje)
        {
            var aCCIONParameter = aCCION != null ?
                new ObjectParameter("ACCION", aCCION) :
                new ObjectParameter("ACCION", typeof(string));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var iDENTIFICACIONParameter = iDENTIFICACION.HasValue ?
                new ObjectParameter("IDENTIFICACION", iDENTIFICACION) :
                new ObjectParameter("IDENTIFICACION", typeof(decimal));
    
            var tELEFONOParameter = tELEFONO.HasValue ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(decimal));
    
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("STPR_CLIENTES_PRUEBA_MANTENIMIENTE", aCCIONParameter, nOMBREParameter, iDENTIFICACIONParameter, tELEFONOParameter, iDParameter, p_Mensaje);
        }
    }
}
