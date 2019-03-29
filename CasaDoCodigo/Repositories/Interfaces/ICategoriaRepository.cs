using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<Categoria> Salvar(string nome);
    }
}
