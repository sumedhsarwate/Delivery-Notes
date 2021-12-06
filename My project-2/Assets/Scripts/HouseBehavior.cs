using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseBehavior : MonoBehaviour
{
    public string house_identity = "";
    // public Button house_button;

    public GameBehavior gameManager;
    public CrateBehavior crate;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("hi");
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
        crate = GameObject.Find("Crate").GetComponent<CrateBehavior>();
        // Button b = house_button.GetComponent<Button>();
        // b.onClick.AddListener(TaskOnClick);
    }

    public void OnClick()
    {
        Debug.Log("You have Clicked the button: " + house_identity);
        string current_note = crate.getCurrentNote();
        if (current_note.Equals(house_identity))
        {
            gameManager.Score += 10;
            crate.updateFeedback(true);
            Debug.Log(gameManager.Score);
            // tell crate to put a check mark under note
        }
        else
        {
            // tell crate to put an x mark under note
            crate.updateFeedback(false);
            Debug.Log(gameManager.Score);
        }
    }


    // Update is called once per frame
    void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // { // if left button pressed...
        //     Ray ray = GetComponent<Camera>.ScreenPointToRay(Input.mousePosition);
        //     RaycastHit hit;
        //     if (Physics.Raycast(ray, out hit))
        //     {
        //         Debug.Log("howdy!!!");
        //         // the object identified by hit.transform was clicked
        //         // do whatever you want
        //     }
        // }
    }

    void OnMouseDown()
    {
        // getting current note
        // string current_note = "";
        // Destroy(this.gameObject);
        Debug.Log("goodbye!!!");
        //Debug.Log("clicked on note " + house_identity);
        // if (current_note.Equals(house_identity))
        // {
        //     // incr score
        //     // tell crate to put a check mark
        // }
        // else
        // {
        //     // tell crate to put an x mark 
        // }

    }
}
