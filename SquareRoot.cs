using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//제곱근 판별

//자연수 n에 대해, n이 어떤 자연수 x의 제곱인지 아닌지 판단하려 합니다.
//n이 자연수 x의 제곱이라면 x+1의 제곱을, n이 자연수 x의 제곱이 아니라면 -1을 Console 창에 출력하는 코드를 만들어보세요.
//예) n = 9 라면 3의 제곱 입니다. 따라서 (3 + 1) *(3 + 1) = 16 이
//    Console 창에 나오면 됩니다.
//    n = 5 라면 어떠한 수의 제곱도 아닙니다. 이 경우에는 -1이
//    Console 창에 나오면 됩니다.

public class SquareRoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Sqrt 사용하지 않는 초기작성 코딩
        //int n = 5;
        //int answer = -1;

        //for (int x = 1; x < n; x++)
        //{
        //    if (n>=1 && x * x == n) {
        //        answer += (x + 1) * (x + 1) + 1;
        //    }
        //}

        //print(answer);


        //Sqrt 사용
        int n = 9;
        float f = Mathf.Sqrt(n);

        int answer = 0;

        if (f % 1 > 0)
            // f를 1로 나눈 나머지가 0보다 크다면
        {
            answer = -1;
        }
        else
        {
            int x = (int)f;
            answer = (x + 1) * (x + 1);
        }
        print(answer);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
