﻿using ProjetoEduX.Domains;
using System;
using System.Collections.Generic;

namespace ProjetoEduX.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();

        Usuario BuscarPorId(Guid id);
        void Adicionar(Usuario usuario);
        void Editar(Usuario usuario);
        void Remover(Guid id);

    }
}