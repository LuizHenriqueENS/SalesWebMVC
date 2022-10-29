﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendas(DateTime inicio, DateTime fim)
        {
            return Vendedores.Sum(vendedor => vendedor.TotalDeVendas(inicio, fim));
        }
    }
}
