using ZazaFlix.Models;

namespace ZazaFlix.Interfaces;

public interface IMovieRepository : IRepository<Movie>
{
    List<Movie> ReadAllDetailed();

    Movie ReadByIdDetailed(int id);
}
