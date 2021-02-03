//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentCar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculo()
        {
            this.RENTADEVOLUCION = new HashSet<RENTADEVOLUCION>();
            this.INSPECCION = new HashSet<INSPECCION>();
        }
    
        public int IdVehiculo { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }
        public int IdTipoVehiculo { get; set; }
        public int IdTipoCombustible { get; set; }
        public string Despcricion { get; set; }
        public int NoChasis { get; set; }
        public int NoMotor { get; set; }
        public int NoPlaca { get; set; }
        public string Estado { get; set; }
    
        public virtual MARCA MARCA { get; set; }
        public virtual MODELO MODELO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RENTADEVOLUCION> RENTADEVOLUCION { get; set; }
        public virtual TIPOCOMBUSTIBLE TIPOCOMBUSTIBLE { get; set; }
        public virtual TIPOVEHICULO TIPOVEHICULO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSPECCION> INSPECCION { get; set; }
    }
}