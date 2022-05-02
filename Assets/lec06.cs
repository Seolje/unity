using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lec06 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str1 = "Unity";
        string str2 = "Engine";
        int num = 2020;

        str1 = str1 + str2;
        Debug.Log(str1);

        str1 = str1 + num;
        Debug.Log(str1);

        
        int num1 = 2000;

        if (num1 > 2000)
        {
            Debug.Log("2000보다 크다");
        }
        else if (num1 == 2000)
        {
            Debug.Log("2000이다");
        }
        else
        {
            Debug.Log("2000보다 작다");
        }


        string str = "반복";

        for (int count = 0; count < 5; count++)
        {
            Debug.Log(str+count);
        }


        int [] score = {100, 50, 80, 90, 95};

        score[1] = 70;

        for (int index = 0; index < 5; index++)
        {
            Debug.Log(score[index]);
        }
    }
}

