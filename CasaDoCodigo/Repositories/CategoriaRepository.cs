using CasaDoCodigo.Models;
using CasaDoCodigo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public async Task<Categoria> Salvar(string nome)
        {
            try
            {
                if (string.IsNullOrEmpty(nome))
                    throw new Exception("Nome da categoria deve ser preenchido");

                var novaCategoria = dbSet.SingleOrDefault(x => x.Nome == nome);

                if (novaCategoria != null)
                    return novaCategoria;

                novaCategoria = new Categoria(nome);
                dbSet.Add(novaCategoria);

                await contexto.SaveChangesAsync();

                return novaCategoria;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message, ex);
            }
        }
    }
}
