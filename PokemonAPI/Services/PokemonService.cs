using PokemonAPI.Dtos;
using PokemonAPI.Services.Interfaces;

namespace PokemonAPI.Services
{
    public class PokemonService : IPokemonService
    {

        private static List<PokemonDto> _pokemons = new()
        {
            new() { Id=1, Name="Bulbasaur", Type="Grass", Level=10},
            new() { Id=2, Name="Ivysaur", Type="Grass-Poison", Level=34},
            new() { Id=3, Name="Venesaur", Type="Grass-Poison", Level=100},
        };

        public PokemonDto? GetPokemonBy(int id)
        {
            return _pokemons.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<PokemonDto> GetPokemons()
        {
            return _pokemons;
        }
    }
}
