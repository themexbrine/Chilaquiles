using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShakeTransition : MonoBehaviour
{
    public GameObject[] currentScene;
    public GameObject[] nextScene;
    public GameObject signal;
    public GameObject trigger;
    public GameObject lid;
    public GameObject[] ingredients;
    public GameObject salsa;


    public bool start;
    public float timer;
    public Text timerText;

    public float speed = 50.0f; //how fast it shakes
    public float amount = 5.0f; //how much it shakes

    float colorFall = 1f;
    float colorRise = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        timerText.text = timer.ToString();

        if (signal.GetComponent<Counter>().bonusaction)
        {
            lid.SetActive(true);
            trigger.SetActive(true);
        }

       
        if (start)
        {
            colorFall -= Time.deltaTime / 10f;
            colorRise += Time.deltaTime / 10f;
            salsa.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, colorRise);
            salsa.SetActive(true);
            gameObject.transform.position = new Vector3(transform.position.x + Mathf.Sin(Time.time * speed) * amount, transform.position.y, 0);
            timer -= Time.deltaTime;
            for (int i = 0; i < ingredients.Length; i++)
            {
                //SpriteRenderer.color = new Color(1f,1f,1f,0f) is about 100% transparent (Cant be seen at all, but still active)
                ingredients[i].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, colorFall);
            }
            

            if (timer < 0f)
            {
                for (int i = 0; i < currentScene.Length; i++)
                    currentScene[i].SetActive(false);

                for (int i = 0; i < nextScene.Length; i++)
                    nextScene[i].SetActive(true);
            }
        }
    }

    public void ShakeIt()
    {
        start = true;
    }
}
