using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//콜라츠 추측
//콜라츠 추측이란 주어진 수 n이 1이 될 때까지 다음 작업을 반복하면, 모든 수를 1로 만들 수 있다는 추측입니다. 

//1-1. 입력된 수가 짝수라면 2로 나눕니다. 
//1-2. 입력된 수가 홀수라면 3을 곱하고 1을 더합니다. 
//2. 결과로 나온 수에 같은 작업을 1이 될 때까지 반복합니다. 

//위 작업을 몇 번 반복해야 1이 나오는지 Console 창에 출력하는 코드를 만들어보세요.
//단, 100번을 반복해도 1이 되지 않는다면 -1을 출력해 주세요.

//예) n = 6 이라면 3-> 10-> 5-> 16-> 8-> 4-> 2-> 1 로 8번 반복합니다.

public class Collatz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int n = 6;

        int count = 0;

        for (count = 1; count <= 100; count++)
        {
            if(n % 2 == 0)
            {
                n = n / 2;
                if (n == 1)
                {
                    print(count);
                    break;
                }
            }
            else if(n > 1)
            {
                n = n * 3 + 1;
            }
            if (n == 1)
            {
                print(0);
                break;
            }
        }
        if (count > 100)
            {
                print(-1);
            }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
