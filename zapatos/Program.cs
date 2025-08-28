using System;
using System.Collections.Generic;

namespace TiendaZapatos
{
   public class Zapato
    {
        public bool Disponible { get; set; }
        public string? Modelo { get; set; } 
        public int Talla { get; set; }
        public decimal Precio { get; set; }

        // Relaciones
        public Marca Marca { get; set; } = null!;
        public Proveedor Proveedor { get; set; } = null!;
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
    }

   public class Marca
    {
        public bool Activa { get; set; }
        public string? Nombre { get; set; }
        public int AñoFundacion { get; set; }
        public decimal Valor { get; set; }

        // Relación: una marca tiene muchos zapatos
        public List<Zapato> Zapatos { get; set; } = new List<Zapato>();
    }

   public class Proveedor
    {
        public bool Nacional { get; set; }
        public string? Nombre { get; set; }
        public int Antiguedad { get; set; }
        public decimal Capital { get; set; }

        // Relación: un proveedor tiene muchos zapatos
        public List<Zapato> Zapatos { get; set; } = new List<Zapato>();
    }

   public class Cliente
    {
        public bool Vip { get; set; }
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public decimal Saldo { get; set; }

        // Relación: un cliente puede comprar muchos zapatos
        public List<Zapato> ZapatosComprados { get; set; } = new List<Zapato>();
    }
}




