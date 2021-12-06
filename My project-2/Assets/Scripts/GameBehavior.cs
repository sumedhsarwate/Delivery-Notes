using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    private float _score = 0;
    private string[] _cratePhrases;
    private int _crateIndex;

    private int _scoreToWin = 80;
    public bool showWinScreen = false;
    public bool showLoseScreen = false;

    private int _numPackages = 0;

    public SpriteRenderer[] _sheetMusic;

    private string _currentNote = " ";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public float Score {
        get {
            return _score;
        }

        set {
            _score = value;

            if (_score == 0)
            {
                showLoseScreen = true;
            }
        }
    }

    public string CurrentPhrase {
        get {
            return _cratePhrases[_crateIndex];
        }

        set {
            _cratePhrases[_crateIndex] = value;
        }
    }

    public string CurrentNote {
        get {
            return _currentNote;
        }

        set {
            _currentNote = value;
        }
    }


    public int NumPackages {
        get {
            return _numPackages;
        }

        set {
            _numPackages = value;
        }
    }

    /*public string CurrentSheetMusic {
        get {
            return _sheetMusic[_crateIndex];
        }
    }*/

    /*public int CurrentPhraseIndex {
        get {
            return _cratePhrases[_crateIndex];
        }

        set {
            _crateIndex = value;
            if (_crateIndex == _cratePhrases.Length)
            {
                if (_score >= _scoreToWin){
                    showWinScreen = true;
                    Time.timeScale = 0f;
                } else {
                    showWinScreen = false;
                    Time.timeScale = 0f;
                }

            }
        }
    }*/

    public void PhrasesDone() {
        if (_score >= _scoreToWin){
            showWinScreen = true;
            Time.timeScale = 0f;
        } else {
            showLoseScreen = true;
            Time.timeScale = 0f;
        }
    }
}
