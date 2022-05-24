using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//가운데 문자 가져오기

//문자 s가 주어질 때 가운데 문자를 Console 창에 출력하는 코드를 만들어보세요.
//예) s = “asdfg”; 이면 “d”를, s = “qwer”; 이면 “we”를 Console 창에 나오면 됩니다.

public class CenterWord : MonoBehaviour
{
    string s = "asdfg";
    //입력값 (s)

    // Start is called before the first frame update
    void Start()
    {
        int length = s.Length;
        //입력갑(s)의 길이를 구한뒤

        if (length <= 0 )
        //만약 입력값의 길이가 0보다 작다면 return
        {
            return;
        }
        else if(length % 2 == 0)
        //입력값을 2의 배수라면(짝수라면)
        {
            int initial = (int)length / 2 - 1;
            // initial 은 입력값의 반값에 - 1값으로 Substring의 시작점으로 활용
            print(s.Substring(initial, 2));
            // 2의 배수면 중간값이 2개가 나오니 initial 값부터 2개의 문자가 나오도록 프린트
        }
        else
        //입력값이 2의 배수가 아니라면(홀수라면)
        {
            print(s.Substring(length / 2, 1));
            // 입력값의 반값부터 1개의 문자가 나올 수 있도록 프린트
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
