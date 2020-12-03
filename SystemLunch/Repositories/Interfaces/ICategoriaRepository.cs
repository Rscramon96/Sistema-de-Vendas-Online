﻿using System.Collections.Generic;
using SystemBeauty.Models;

namespace SystemBeauty.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> ListaCategorias();
        Categoria GetCategoriaByID(int ID);
        Categoria AddCategoria(Categoria categoria);
        Categoria UpdateCategoria(Categoria categoria);
    }
}
