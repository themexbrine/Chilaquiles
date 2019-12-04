using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] currentScene;
    public GameObject finalScene;
    public GameObject buttonTotopos, buttonSalsa;
    public bool tortillas = false, salsa = false;

    private void Update()
    {
        if(tortillas && salsa)
        {
            for (int i = 0; i < currentScene.Length; i++)
                currentScene[i].SetActive(false);

            finalScene.SetActive(true);
        }
    }

    public void checkTortillas()
    {
        tortillas = true;
    }

    public void checkSalsa()
    {
        salsa = true;
    }
}
