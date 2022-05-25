using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String : MonoBehaviour
{
    string inputStr = "김연아 손흥민 김치 최고";

    // Start is called before the first frame update
    void Start()
    {

        while (true)
        {
            int indexValue = inputStr.IndexOf(" ");

            if(indexValue == -1)
            {
                print(inputStr);
                break;
            }
            else
            {
                string result = inputStr.Substring(0, indexValue);
                inputStr = inputStr.Substring(indexValue + 1);
                print(result);

            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
