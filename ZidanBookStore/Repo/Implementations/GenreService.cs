using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZidanBookStore.Models.Domain;
using ZidanBookStore.Repo.Abstract;

namespace ZidanBookStore.Repo.Implementations
{
    public class GenreService : IGenreService
    {
        private readonly DatabaseContext _context;
        public GenreService(DatabaseContext context)
        {
            _context = context;
        }
        public bool Add(Genre genre)
        {
            try
            {
                _context.genres.Add(genre);
               _context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var genre = _context.genres.FirstOrDefault(x=>x.Id == id);
                if(genre == null)
                {
                    return false;

                }
                _context.genres.Remove(genre);
                _context.SaveChanges();
                return true;


            }
            catch (Exception)
            {
                return false;

            }
        }

        public Genre FindById(int id)
        {
            try
            {

                return _context.genres.FirstOrDefault(x => x.Id == id);

            }catch(Exception ex)
            {
                return null ;
            }
        }

        public IEnumerable<Genre> GetAll()
        {
            try
            {
                return _context.genres.ToList();
            }catch(Exception ex)
            {
                return null;
            }
        }

        public bool Update(Genre genre)
        {
            try
            {
                _context.genres.Update(genre);
                _context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
