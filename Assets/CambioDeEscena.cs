﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CambioDeEscena : MonoBehaviour
{
    public string input;
    SceneManager ma;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiarEscena()
    {
       
        SceneManager.LoadScene(input);

    }
}
