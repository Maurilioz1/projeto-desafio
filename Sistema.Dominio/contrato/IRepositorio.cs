﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Dominio.contrato
{
    public interface IRepositorio<T> where T : class
    {
        void Salvar(T entidade);

        void Excluir(T entidade);

        IEnumerable<T> ListarTodos();

        T ListarPorId(string id);
    }
}
