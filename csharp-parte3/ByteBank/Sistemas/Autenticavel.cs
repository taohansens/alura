﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas {
    public abstract class Autenticavel : Funcionario {
        public Autenticavel(double salario, string cpf): base(cpf, salario) { }
        public string Senha { get; set; }
        public bool Autenticar(string senha) {
            return Senha == senha;
        }
    }
}
