using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumBetweenNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 5;
        int b = 5;

        int answer = 0;

        if (a < b)
        {
            for (int i = a; i <= b; i++)
            {
                answer += i;
            }
        }else if(a == b){
            return;
        }else
        {
            for (int i = b; i <= a; i++)
            {
                answer += i;
            }
        }

        print(answer);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
