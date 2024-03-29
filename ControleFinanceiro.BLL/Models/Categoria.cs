﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.BLL.Models
{
    public class Categoria
    {
        public int CategoriaId { set; get; }

        public string Nome { get; set; }

        public string Icone { get; set; }

        public int TipoId { get; set; }

        public Tipo Tipo { get; set; }

        public virtual ICollection<Despesa> Despesas { get; set; }

        public virtual ICollection<Ganho> Ganhos { get; set; }


    }
}
