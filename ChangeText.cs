using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//영단어 숫자를 아라비아 숫자로 바꾸기

//다음은 숫자의 일부 자릿수를 영단어로 바꾸는 예시입니다.

//  "one4three5“ → “1435”

//  “1two3four5 “ → “12345”

//이렇게 숫자의 일부 자릿수가 영단어로 바뀌어졌거나, 혹은 바뀌지 않고 그대로인 문자열 s가 주어집니다. s가 의미하는 원래 숫자를 Console 창에 출력하는 코드를 만들어보세요.
//단, 숫자의 범위는 1 ~ 5 입니다.

public class ChangeText : MonoBehaviour
{
    string inputStr = "1two3four5";
    
    // Start is called before the first frame update
    void Start()
    {
        string indexOne = "one";
        int indexOneValue = inputStr.IndexOf(indexOne);

        if (indexOneValue != -1)
        {
            inputStr = inputStr.Replace("one", "1");
        }

        string indexTwo = "two";
        int indexTwoValue = inputStr.IndexOf(indexTwo);

        if (indexTwoValue != -1)
        {
            inputStr = inputStr.Replace("two", "2");
        }

        string indexThree = "three";
        int indexThreeValue = inputStr.IndexOf(indexThree);

        if (indexThreeValue != -1)
        {
            inputStr = inputStr.Replace("three", "3");
        }

        string indexFour = "four";
        int indexFourValue = inputStr.IndexOf(indexFour);

        if (indexFourValue != -1)
        {
            inputStr = inputStr.Replace("four", "4");
        }

        string indexFive = "five";
        int indexFiveValue = inputStr.IndexOf(indexFive);

        if (indexFiveValue != -1)
        {
            inputStr = inputStr.Replace("five", "5");
        }


        print(inputStr);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
