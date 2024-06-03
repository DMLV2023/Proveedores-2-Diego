using System;
using System.Collections.Generic;

namespace Proveedores2.Models
{
    public partial class Proveedore
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Cuit { get; set; } = null!;
        public string? ContactoPrincipal { get; set; }
        public string? Telefono { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? DireccionCalle { get; set; }
        public string? DireccionCiudad { get; set; }
        public string? DireccionEstado { get; set; }
        public string? DireccionCodigoPostal { get; set; }
        public string? DireccionPais { get; set; }
        public string? SitioWeb { get; set; }
        public string? TipoProductosServicios { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? CondicionesPago { get; set; }
    }
}
