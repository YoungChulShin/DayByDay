/*Name: DRAWRECT
#URL: https://algospot.com/judge/problem/read/DRAWRECT#
#문제
#AdbyMe, Inc. 의 인턴인 A.I.는 웹 브라우저에 직사각형을 그리는 코드를 작성해야 한다. 웹 브라우저는 직사각형 모양의 뷰포트를 가지고 있고, 그려지는 직사각형의 네 변은 반드시 그 뷰포트의 두 축에 평행해야 한다.
#한편, A.I.는 코드를 작성하던 중 그릴 직사각형의 네 꼭지점 중 어느 것이든 세 개의 좌표를 알고 있다면 나머지 점의 위치는 유일하게 결정됨을 알아내었다 (네 점 중 어떤 두 개의 좌표를 알아낸 경우는 때에 따라 직사각형을 결정하지 못할 수도 있다.)
#A.I.는 LIBe에게 이를 이번 대회 문제로 출제할 것을 제안하였다.
#직사각형을 이루는 네 점 중 임의의 세 점의 좌표가 주어졌을 때, 나머지 한 개의 점의 좌표를 찾는 프로그램을 작성하라.
#입력
#입력은 T 개의 테스트 케이스로 구성된다. 입력의 첫 행에는 T 가 주어진다.
#각 테스트 케이스는 공백 하나로 구분되는 두 개씩의 정수로 구성된 세 행으로 이뤄지며, 각각 임의의 세 점의 x와 y 좌표이다. 브라우저 뷰포트의 맨 왼쪽 위 픽셀의 좌표는 (1, 1)이고, 맨 오른쪽 아래 픽셀의 좌표는 (1000, 1000)이다. 모든 좌표는 뷰포트 안에 위치하며, 각 점의 위치는 모두 다르다.
#출력
#각 테스트 케이스에 대해 한 행에 하나씩 좌표가 주어지지 않은 나머지 한 점의 x와 y 좌표를 공백 하나로 구분하여 출력한다.
*/

static void Test(string[] args)
{
    int loopCount = int.Parse(Console.ReadLine());

    int[, ,] inputArray = new int[loopCount, 3, 2];
    int[,] outputArray = new int[loopCount, 2];
    string[] inputText;
    for (int i = 0; i < loopCount; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            inputText = Console.ReadLine().Split(new char[1] { ' ' });
            inputArray[i, j, 0] = int.Parse(inputText[0]);
            inputArray[i, j, 1] = int.Parse(inputText[1]);

        }

        for (int k = 0; k < 2; k++)
        {
            if (inputArray[i, 1, k] == inputArray[i, 0, k])
            {
                outputArray[i, k] = inputArray[i, 2, k];
            }
            else if (inputArray[i, 1, k] == inputArray[i, 2, k])
            {
                outputArray[i, k] = inputArray[i, 0, k];
            }
            else
            {
                outputArray[i, k] = inputArray[i, 1, k];
            }
        }
    }

    for (int i = 0; i < loopCount; i++)
    {
        Console.WriteLine(outputArray[i, 0].ToString() + " " + outputArray[i, 1].ToString());
    }
} 