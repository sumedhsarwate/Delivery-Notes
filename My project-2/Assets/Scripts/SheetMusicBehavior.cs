using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheetMusicBehavior : MonoBehaviour
{
    public GameBehavior gameManager;

    SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    private string _phrase;
    public int currentPhrase = 0;

    public CrateBehavior crate;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
        crate = GameObject.Find("Crate").GetComponent<CrateBehavior>();
        Debug.Log("hi");
        spriteArray = Resources.LoadAll<Sprite>("LevelN");
        spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log(spriteArray.Length);
        Debug.Log(spriteRenderer);
        spriteRenderer.sprite = spriteArray[currentPhrase];
        _phrase = spriteRenderer.sprite.name;
        gameManager.NumPackages = spriteArray.Length;
        Debug.Log(spriteArray.Length);
        crate.setPhrase(_phrase);
        //Debug.Log(_phrase);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string updateSprite()
    {
        currentPhrase += 1;
        if (currentPhrase < spriteArray.Length) {
            spriteRenderer.sprite = spriteArray[currentPhrase];
            _phrase = spriteRenderer.sprite.name;
            return _phrase;
        } else {
            gameManager.PhrasesDone();
            return " ";
        }
    }

    public string Phrase {
        get {
            return _phrase;
        }

        set {
            _phrase = value;
        }
    }
}
