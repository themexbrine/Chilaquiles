using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteract : MonoBehaviour
{
    float deltaX;
    float deltaY;
    public bool isHeld = false;

    Vector3 initialPosition;
    Vector3 mousePosition;
    Vector2 mousePos;
    Vector2 initialPos;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    //private void OnMouseDown()
    //{
    //    deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
    //    deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;

    //}

    private void OnMouseDrag()
    {
        //mousePosition = Input.mousePosition;
        //gameObject.transform.position = new Vector3(mousePosition.x, mousePosition.y);
        mousePos = Input.mousePosition;
        rb.MovePosition(new Vector2(mousePos.x, mousePos.y));


        //mousePos = (Vector2)Input.mousePosition;
        //gameObject.transform.position = new Vector2(transform.position.x - mousePos.x,  transform.position.y - mousePos.y);

        Debug.Log("mouse" + mousePosition);
        Debug.Log("object" + gameObject.transform.position);
    }

    private void OnMouseUp()
    {
        //transform.position = new Vector3(Input.mousePosition.x,Input.mousePosition.y,0);
    }

    //void Update()
    //{

    //    if (isHeld == true)
    //    {
    //        Vector3 mousePos;
    //        mousePos = Input.mousePosition;
    //        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

    //        this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);//mousePos.x - startPosX, mousePos.y - startPosY, 0

    //    }
    //}

    // Update is called once per frame
    //private void OnMouseDown()
    //{
    //    Debug.Log("Contacy");
    //    if (Input.GetMouseButton(0))
    //    {
    //        Vector3 mousePos;
    //        mousePos = Input.mousePosition;
    //        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

    //        startPosX = mousePos.x - this.transform.position.x;
    //        startPosY = mousePos.y - this.transform.position.y;

    //        isHeld = true;
    //    }
    //}
}
