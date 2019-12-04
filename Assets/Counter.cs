using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int Limit;
    public int count;
    public GameObject[] currentScene;
    public GameObject[] nextScene;
    public bool bonusaction;

    // Start is called before the first frame update
    void Start()
    {
        bonusaction = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (count >= Limit)
        {
            for (int i = 0; i < currentScene.Length;i++)
            currentScene[i].SetActive(false);

            for (int i = 0; i < nextScene.Length; i++)
                nextScene[i].SetActive(true);

            bonusaction = true;
        }


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ingredient")
        {
            count++;
        }
    }
}
