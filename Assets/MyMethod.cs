using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMethod
{
    void Start(int num)
    {
        Debug.Log(num + 2);
    }
    void SecondRound (int num)
    {
        if (num>=10)
        {
            Debug.Log("Cool Number");
        }    
        else
        {
            Debug.Log("Cool Number Too");
        }
    }
    void ThirdRound (int num)
    {
        switch (num)
        {
            case 10:
                Debug.Log("That's Great!");
                    break;

            case 80:
                 Debug.Log("That's Too Much!");
                    break;

            case 30:
                 Debug.Log("That's Perfect");
                    break; 


        }
    }
}
