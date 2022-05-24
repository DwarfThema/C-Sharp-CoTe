using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//문자열 나누기

//문자 s가 주어질 때 띄어쓰기를 기준으로 단어를 분리해서 Console 창에 출력하는 코드를 만들어보세요.

//예) s = “하이 헬로우 안녕하세요”; 이면
//    “하이” -> “헬로우” -> “안녕하세요” 순으로 Console 창에 나오면 
//    됩니다.

//힌트) string 의 IndexOf, Substring 이용하자.

public class DivideText : MonoBehaviour
{
    string s = "하이 헬로우 안녕";
    // 입력값

    // Start is called before the first frame update
    void Start()
    {
        string indexBlank = " ";
        //Index로 찾을 값은 Blank 값 
        int indexValue = s.IndexOf(indexBlank);
        //Blank 값의 위치 찾기

        if (indexValue != -1)
        // 만약 입력값에 Blank가 존재한다면
        {
            if(s==" ")
            // s가 Blank로만 이루어져있다면 return
            {
                return;
            }
            else
            // s가 Blank로만 이루어져있지 않다면
            {
                for (int i = 0; i < s.Length; i++)
                //for문은 0부터 입력값(s)의 길이만큼 반복
                {
                    string result = s.Substring(0, indexValue);
                    // result는 입력값의 0 ~ Blank 위치만큼의 문자열

                    if(result != "")
                    // result가 빈 문자열이 아니라면 result 프린트
                    {
                        print(result);
                    }

                    s = s.Substring(indexValue + 1);
                    // result 프린트 이후에 입력값 재 지정
                    // 기존 입력값(s)에서 Blank를 포함한 다음(+1) 시작 부분부터로 지정
                    indexValue = s.IndexOf(indexBlank);
                    // Blank 위치도 재지정

                    if (indexValue == -1)
                    // 만약 Blank가 없다면 그냥 입력값(s) 프린트 이후 break
                    {
                        print(s);
                        break;
                    }
                }
            }
        }
        else
        //만약 입력값에 Blank를 찾을 수 없다면 입력갑(s) 자체를 프린트
        {
            print(s);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
