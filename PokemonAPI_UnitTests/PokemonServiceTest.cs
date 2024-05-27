using PokemonAPI.Services;

namespace PokemonAPI_UnitTests
{
    public class PokemonServiceTest
    {
        [Fact]
        public void GetPokemons_ShouldReturnNonEmptyList()
        {
            // AAA
            // Arrange - create object under test
            PokemonService service = new();
            // Act - call the method that you are testing
            var result = service.GetPokemons();
            // Arrange - make a statement that should be true if test is successful
            Assert.NotEqual(0, result.Count);
        }
    }
}