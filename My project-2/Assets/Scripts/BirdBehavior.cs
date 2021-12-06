using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BirdBehavior : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    private bool selected = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            selected = !selected;
        }
        if (selected)
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
            //transform.anchoredPosition = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        }
    }

}
