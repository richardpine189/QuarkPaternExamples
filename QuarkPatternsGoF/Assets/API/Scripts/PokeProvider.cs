using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using UnityEngine;

public class PokeProvider
{
    private IPokeAPIController _pokeAPIController;
    private Pokemon _pokemon;

    public PokeProvider(int pokeNumber)
    {
        _pokemon = new Pokemon(pokeNumber);
        _pokeAPIController = new PokeAPIController();   
    }

    public async void SendRequest()
    {
        _pokeAPIController.SetPokemonIndex(_pokemon.PokemonNumber);


        //StartCoroutine(_pokeAPIController.GetPokemonInRepository());


        _pokemon = _pokeAPIController.GetPokemon();
        
    }

    public Pokemon GetPokemonModel()
    {
        return _pokemon;
    }
}
