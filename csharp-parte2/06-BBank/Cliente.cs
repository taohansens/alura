﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BBank {
    public class Cliente {
        private string _nome;
        private string _cpf;
        private string _profissao;

        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Profissao { get => _profissao; set => _profissao = value; }
    }

}


