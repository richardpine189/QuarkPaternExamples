using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using System.Threading.Tasks;

public class PokeAPIController : IPokeAPIController
{
    private PokeVista _pokeVista;
    private readonly string _basePokeURL = "https://pokeapi.co/api/v2/";
    private Pokemon _pokemon;
    
    public Pokemon GetPokemon()
    {
        return _pokemon;
        
    }
    public IEnumerator GetPokemonInRepository()
    {
        // Get Pokemon Info
        
        string pokemonURL = _basePokeURL + "pokemon/" + _pokemon.PokemonNumber.ToString();
        // Example URL: https://pokeapi.co/api/v2/pokemon/151

        UnityWebRequest pokeInfoRequest = UnityWebRequest.Get(pokemonURL);

        yield return pokeInfoRequest.SendWebRequest(); 
        

        if (pokeInfoRequest.isNetworkError || pokeInfoRequest.isHttpError)
        {
            Debug.LogError(pokeInfoRequest.error);
            yield break;
        }

        JSONNode pokeInfo = JSON.Parse(pokeInfoRequest.downloadHandler.text);

        string pokeName = pokeInfo["name"];
        string pokeSpriteURL = pokeInfo["sprites"]["front_default"];
        
        Debug.Log(pokeName);
        
        JSONNode pokeTypes = pokeInfo["types"];
        string[] pokeTypeNames = new string[pokeTypes.Count];
        
        for (int i = 0, j = pokeTypes.Count - 1; i < pokeTypes.Count; i++, j--)
        {
            pokeTypeNames[j] = pokeTypes[i]["type"]["name"];
        }

        // Get Pokemon Sprite

        UnityWebRequest pokeSpriteRequest = UnityWebRequestTexture.GetTexture(pokeSpriteURL);

        yield return pokeSpriteRequest.SendWebRequest();

        if (pokeSpriteRequest.isNetworkError || pokeSpriteRequest.isHttpError)
        {
            Debug.LogError(pokeSpriteRequest.error);
            yield break;
        }
        Texture2D pokeSprite = DownloadHandlerTexture.GetContent(pokeSpriteRequest);

        _pokemon.SetPokemonInfo(pokeSprite, pokeName, pokeTypeNames);
      
    }

    public void SetPokemonIndex(int pokemonIndex)
    {
        _pokemon = new Pokemon(pokemonIndex);
    }
}
