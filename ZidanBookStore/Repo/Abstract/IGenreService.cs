using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZidanBookStore.Models.Domain;

namespace ZidanBookStore.Repo.Abstract
{
    public interface IGenreService
    {
        bool Add(Genre genre);
        bool Update(Genre genre);
        Genre FindById(int id);
        bool Delete(int id);
        IEnumerable<Genre> GetAll();

    }
}
