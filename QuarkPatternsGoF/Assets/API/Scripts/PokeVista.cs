using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PokeVista : MonoBehaviour
{
    [SerializeField] RawImage _pokeRawImage;
    [SerializeField] TextMeshProUGUI _pokeNameText, _pokeNumText;
    [SerializeField] TextMeshProUGUI[] _pokeTypeTextArray;
    PokeProvider _pokeProvider;
    Pokemon _pokemon;

    private void Start()
    {
        _pokeRawImage.texture = Texture2D.blackTexture;

        _pokeNameText.text = "";
        _pokeNumText.text = "";

        foreach (TextMeshProUGUI pokeTypeText in _pokeTypeTextArray)
        {
            pokeTypeText.text = "";
        }

       
    }

    public void OnButtonRandomPokemon()
    {

        int pokeNumber = GenerateRandomNumber();
        SetLoadingMSG(pokeNumber);

        _pokeProvider = new PokeProvider(pokeNumber);

        _pokeProvider.SendRequest();

        _pokemon = _pokeProvider.GetPokemonModel();

        UpdateUI();
    }

    private void UpdateUI()
    {
        
        SetTypeTextInUI(_pokemon.PokemonTypes);
        SetSpriteInUI(_pokemon.PokemonTexture);
        SetNameTextInUI(_pokemon.PokemonName);
        
    }

    private void SetTypeTextInUI(string[] pokeTypeNames)
    {
        

        for (int i = 0; i < pokeTypeNames.Length; i++)
        {
            _pokeTypeTextArray[i].text = CapitalizeFirstLetter(pokeTypeNames[i]);
        }
    }

    private void SetNameTextInUI(string pokeName)
    {
        _pokeNameText.text = CapitalizeFirstLetter(pokeName);
    }
    private void SetSpriteInUI(Texture2D pokeSprite)
    {
        _pokeRawImage.texture = pokeSprite;
        _pokeRawImage.texture.filterMode = FilterMode.Point;
    }
    private string CapitalizeFirstLetter(string str)
    {
        return char.ToUpper(str[0]) + str.Substring(1);
    }

    private int GenerateRandomNumber()
    {
        return Random.Range(1, 808); 
    }

    private void SetLoadingMSG(int pokeNumber)
    {

        _pokeRawImage.texture = Texture2D.blackTexture;
        _pokeNameText.text = "Loading...";
        _pokeNumText.text = "#" + pokeNumber.ToString();
        
        foreach (TextMeshProUGUI pokeTypeText in _pokeTypeTextArray)
        {
            pokeTypeText.text = "";
        }

    }
}
