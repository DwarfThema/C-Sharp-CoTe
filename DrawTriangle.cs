using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawTriangle : MonoBehaviour
{
    string star = "";
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i <= 5; i++)
        {
            for(int j=1; j<=i; j++)
            {
                star += "*";
            }
            star += "\n";
        }
        print(star);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
