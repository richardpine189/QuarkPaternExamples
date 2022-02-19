using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pokemon
{
    private Texture2D _pokemonTexture;
    private string _pokemonName = "";
    private string[] _pokemonTypes;
    private int _pokemonNumber = 0;

    public int PokemonNumber { get => _pokemonNumber; private set => _pokemonNumber = value; }
    public Texture2D PokemonTexture { get => _pokemonTexture; private set => _pokemonTexture = value; }
    public string[] PokemonTypes { get => _pokemonTypes; private set => _pokemonTypes = value; }
    public string PokemonName { get => _pokemonName; private set => _pokemonName = value; }

    public Pokemon(int number)
    {
        PokemonNumber = number;
    }

    public void SetPokemonInfo(Texture2D pokeTexture, string pokeName, string[] pokeTypes)
    {
        _pokemonTexture = pokeTexture;
        _pokemonTypes = pokeTypes;
        _pokemonName = pokeName;
    }
}
