using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Dialogues : MonoBehaviour
{
    public GameObject[] texts;
    public float timer = 0;
    int index = 0;
    void Start()
    {
        texts[0].SetActive(true);
    }

    void Update()
    {
        timer = timer + Time.deltaTime;
        //Debug.Log(index);
        if (timer > 36 && index == 6)
        {
            texts[index].SetActive(false);
            index++;
            texts[index].SetActive(true);
        }
        else if (timer > 28 && index == 5)
        {
            texts[index].SetActive(false);
            index++;
            texts[index].SetActive(true);
        }
        else if (timer > 22 && index == 4)
        {
            texts[index].SetActive(false);
            index++;
            texts[index].SetActive(true);
        }
        else if (timer > 20 && index == 3)
        {
            texts[index].SetActive(false);
            index++;
            texts[index].SetActive(true);
        }
        else if (timer > 11 && index == 2)
        {
            texts[index].SetActive(false);
            index++;
            texts[index].SetActive(true);
        }
        else if (timer > 7 && index == 1)
        {
            texts[index].SetActive(false);
            index++;
            texts[index].SetActive(true);
        }
        if (timer > 3 && index == 0) {
            texts[index].SetActive(false);
            index++;
            texts[index].SetActive(true);
        }
    }
}
