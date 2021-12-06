using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite notes;
    public SheetMusicBehavior sheetMusic;
    public string[] phrase;
    public string currentPhrase;

    public int currentNote;

    public GameObject[] answers;
    public FeedbackBehavior[] feedbacks;


    public GameBehavior gameManager;
    
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
        //phrase = gameManager.CurrentPhrase.Split(' ');
        //currentPhrase = gameManager.CurrentPhrase;
        currentNote = 0;
        sheetMusic = GameObject.Find("SheetMusic").GetComponent<SheetMusicBehavior>();

        feedbacks = new FeedbackBehavior[8];
        for (int i = 0; i < 8; i++)
        {
            int n = i + 1;
            string name = "Feedback" + n.ToString();
            Debug.Log(name);
            feedbacks[i] = GameObject.Find(name).GetComponent<FeedbackBehavior>();
        }

        //sheetMusic.updateSprite(index);

    }  

    // Update is called once per frame
    void Update()
    {
        /*if (!currentPhrase.Equals(gameManager.CurrentPhrase)) {
            phrase = gameManager.CurrentPhrase.Split(' ');
            currentPhrase = gameManager.CurrentPhrase;
            currentNote = 0;
        }*/
    }


    public void updateFeedback(bool correct){
        if (correct) {
            feedbacks[currentNote].UpdateFeedback(0);
        } else {
            feedbacks[currentNote].UpdateFeedback(2);
        }

        currentNote += 1;
        if (currentNote < phrase.Length)
        {
            //gameManager.CurrentPhraseIndex += 1;
            //gameManager.CurrentNote = phrase[currentNote];
        } else {
            // SWITCH TO NEXT SHEET MUSIC AFTER FEW SECOND DELAY
            phrase = sheetMusic.updateSprite().Split(' ');
            currentNote = 0;
            for (int i = 0; i < feedbacks.Length; i++)
            {
                feedbacks[i].UpdateFeedback(1);
            }
        }
    }

    public string getCurrentNote()
    {
        return phrase[currentNote];
    }

    public void setPhrase(string p)
    {
        phrase = p.Split(' ');
    }




}
