using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionManager : MonoBehaviour
{
    public GameObject currentCanvas;
    
    


    // Start is called before the first frame update
    void Start()
    {
        currentCanvas = this.gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextCanvas(GameObject target)
    {
        currentCanvas.SetActive(false);
        target.SetActive(true);
    }
}


