﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entity.Entities
{
    public class Time
    {
        public int IdTime { get; set; }
        public string Nome { get; set; }
        public DateTime DataFundacao { get; set; }

        #region Relacionamentos

        public ICollection<Jogador> Jogadores { get; set; }

        #endregion
    }
}
