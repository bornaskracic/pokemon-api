using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Services.Interfaces;

namespace PokemonAPI.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet]
        public IActionResult GetPokemons()
        {
            return Ok(_pokemonService.GetPokemons());
        }

        [HttpGet("{pokemonId}")]
        public IActionResult GetPokemonById(int pokemonId) {
            var pokemon = _pokemonService.GetPokemonBy(pokemonId);
            if (pokemon is null)
                return NotFound();
            return Ok(pokemon);
        
        }


    }
}
