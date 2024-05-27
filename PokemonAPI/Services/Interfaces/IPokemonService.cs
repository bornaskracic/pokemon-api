using PokemonAPI.Dtos;

namespace PokemonAPI.Services.Interfaces
{
    public interface IPokemonService
    {
        List<PokemonDto> GetPokemons();
        PokemonDto? GetPokemonBy(int id);
    }
}
