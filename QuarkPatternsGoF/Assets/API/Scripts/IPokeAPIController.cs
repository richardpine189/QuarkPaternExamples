
using System.Collections;
using UnityEngine;

public interface IPokeAPIController
{
    Pokemon GetPokemon();
    IEnumerator GetPokemonInRepository();
    void SetPokemonIndex(int pokemonIndex);
}