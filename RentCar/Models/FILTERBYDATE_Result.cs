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
    
    public partial class FILTERBYDATE_Result
    {
        public int IdRentaDevolucion { get; set; }
        public int IdEmpleado { get; set; }
        public int IdCliente { get; set; }
        public int IdVehiculo { get; set; }
        public System.DateTime FechaRenta { get; set; }
        public Nullable<System.DateTime> FechaDevolucon { get; set; }
        public decimal MontoDia { get; set; }
        public string CantidadDias { get; set; }
        public Nullable<decimal> MontoAtraso { get; set; }
        public string Comentarios { get; set; }
        public string Estado { get; set; }
    }
}