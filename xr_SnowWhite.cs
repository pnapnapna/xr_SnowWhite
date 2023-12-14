using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xr_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("\t story");
            Console.WriteLine("-----------------------");
            Console.WriteLine("옛날옛날 아주 아름다운 백설공주가 있었습니다.");
            Console.WriteLine("옛날옛날 아주 아름다운 백설공주가 있었습니다.");
            Console.WriteLine("백설공주를 질투한 왕비가 사냥꾼을 시켜 백설공주를 죽이게 했습니다.");
            Console.WriteLine("백설공주가 가여워진 사냥꾼은 숲에서 백설공주를 죽이지 않고 돌아갔습니다.");
            Console.WriteLine("사냥꾼은 저주받은 숲이니 두고 가면 어차피 죽을 백설공주라고 생각했습니다.");
            Console.WriteLine("백설공주는 추위를 피할 곳을 찾다가 어느 집에 들어가게 됩니다.");
            Console.WriteLine("\n");
            Console.WriteLine("저벅저벅....");
            Console.WriteLine("\n");
            Console.WriteLine("쾅--!!!!!!!!!!!!");
            Console.WriteLine("\n");
            Console.WriteLine("그때 문이 갑자기 세게 닫힙니다.");
            Console.WriteLine("놀란 백설공주는 문고리를 돌려보지만 문은 열리지 않습니다.");
            Console.WriteLine("백설공주는 주위를 둘러봅니다.");
            Console.WriteLine("아무래도 이 집에서 탈출해야 할 것 같습니다.");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\t Game Start");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Q1");
            Console.WriteLine("퀴즈를 맞히고 방을 탈출 하세요.");
            Console.WriteLine("\n");
            Console.WriteLine("C#에서 'int' 형식은 몇 비트인가요?");
            Console.WriteLine("1. 4");
            Console.WriteLine("2. 16");
            Console.WriteLine("3. 32");
            Console.WriteLine("4. 64");
            Console.WriteLine("\n");
            Console.WriteLine("알맞은 보기의 번호를 입력하세요.");
            Console.WriteLine("-----------------------------------------------------------");

            int maxAttempts = 2;
            int wrongAttempts = 0;

            while (true)
            {
                Console.WriteLine($"남은 기회: {maxAttempts - wrongAttempts}회");
                Console.WriteLine("정답을 입력하세요:");

                // 사용자 입력 받기
                if (!int.TryParse(Console.ReadLine(), out int userInput))
                {
                    Console.WriteLine("1,2,3,4 중에 하나를 입력하세요.");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("\n");
                    wrongAttempts++;

                    if (wrongAttempts >= maxAttempts)
                    {
                        Console.WriteLine("기회를 모두 소진하였습니다.");
                        Console.WriteLine("백설공주는 기회를 모두 소진하여 살아남을 수 없었습니다.");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("\t Game Over");
                        Console.WriteLine("-------------------------------");
                        return; // 틀린 횟수가 최대 허용 횟수 이상인 경우 종료
                    }

                    continue; // 다시 입력 받기
                }

                // 입력된 숫자에 따라 정답, 오답 또는 다시 입력 안내 출력
                if (userInput == 3)
                {
                    Console.WriteLine("!!! 정답입니다 !!!!");
                    Console.WriteLine("다음방으로 이동합니다.");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("\n");
                    break; // 정답인 경우 반복문 종료
                }
                else if (userInput == 1 || userInput == 2 || userInput == 4)
                {
                    Console.WriteLine("오답입니다.");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("\n");
                    wrongAttempts++;

                    if (wrongAttempts >= maxAttempts)
                    {
                        Console.WriteLine("기회를 모두 소진하였습니다.");
                        Console.WriteLine("백설공주는 기회를 모두 소진하여 살아남을 수 없었습니다.");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("\t Game Over");
                        Console.WriteLine("-------------------------------");
                        return; // 틀린 횟수가 최대 허용 횟수 이상인 경우 종료
                    }
                }
                else
                {
                    Console.WriteLine("1, 2, 3, 4 중 하나를 입력하세요.");
                    Console.WriteLine("-----------------------------------------------------------");
                    wrongAttempts++;

                    if (wrongAttempts >= maxAttempts)
                    {
                        Console.WriteLine("기회를 모두 소진하였습니다.");
                        Console.WriteLine("백설공주는 기회를 모두 소진하여 살아남을 수 없었습니다.");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("\t Game Over");
                        Console.WriteLine("-------------------------------");
                        return; // 틀린 횟수가 최대 허용 횟수 이상인 경우 종료
                    }
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Q2");
            Console.WriteLine("퀴즈를 맞히고 방을 탈출 하세요.");
            Console.WriteLine("\n");
            Console.WriteLine("C#에서 사용되는 'using' 키워드는 무엇을 나타내나요?");
            Console.WriteLine("1. 조건문");
            Console.WriteLine("2. 파일 입출력");
            Console.WriteLine("3. 예외 처리");
            Console.WriteLine("4. 패키지 입포트");
            Console.WriteLine("\n");
            Console.WriteLine("알맞은 보기의 번호를 입력하세요.");
            Console.WriteLine("-----------------------------------------------------------");

            int maxAttempts2 = 2;
            int wrongAttempts2 = 0;

            while (true)
            {
                Console.WriteLine($"남은 기회: {maxAttempts2 - wrongAttempts2}회");
                Console.WriteLine("정답을 입력하세요:");

                // 사용자 입력 받기
                if (!int.TryParse(Console.ReadLine(), out int userInput2))
                {
                    Console.WriteLine("1,2,3,4 중에 하나를 입력하세요.");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("\n");
                    wrongAttempts2++;

                    if (wrongAttempts2 >= maxAttempts2)
                    {
                        Console.WriteLine("기회를 모두 소진하였습니다.");
                        Console.WriteLine("백설공주는 기회를 모두 소진하여 살아남을 수 없었습니다.");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("\t Game Over");
                        Console.WriteLine("-------------------------------");
                        return; // 틀린 횟수가 최대 허용 횟수 이상인 경우 종료
                    }

                    continue; // 다시 입력 받기

                }

                // 입력된 숫자에 따라 정답, 오답 또는 다시 입력 안내 출력
                if (userInput2 == 4)
                {
                    Console.WriteLine("!!! 정답입니다 !!!!");
                    Console.WriteLine("다음방으로 이동합니다.");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("\n");
                    break; // 정답인 경우 반복문 종료
                }
                else if (userInput2 == 1 || userInput2 == 2 || userInput2 == 3)
                {
                    Console.WriteLine("오답입니다.");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("\n");
                    wrongAttempts2++;

                    if (wrongAttempts2 >= maxAttempts2)
                    {
                        Console.WriteLine("기회를 모두 소진하였습니다.");
                        Console.WriteLine("백설공주는 기회를 모두 소진하여 살아남을 수 없었습니다.");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("\t Game Over");
                        Console.WriteLine("-------------------------------");
                        return; // 틀린 횟수가 최대 허용 횟수 이상인 경우 종료
                    }
                }
                else
                {
                    Console.WriteLine("1, 2, 3, 4 중 하나를 입력하세요.");
                    Console.WriteLine("-----------------------------------------------------------");
                    wrongAttempts2++;

                    if (wrongAttempts2 >= maxAttempts2)
                    {
                        Console.WriteLine("기회를 모두 소진하였습니다.");
                        Console.WriteLine("백설공주는 기회를 모두 소진하여 살아남을 수 없었습니다.");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("\t Game Over");
                        Console.WriteLine("-------------------------------");
                        return; // 틀린 횟수가 최대 허용 횟수 이상인 경우 종료
                    }
                }
            }


            while (true)
            {
                Console.WriteLine("다음 방으로 가는 문을 열겠습니까?");
                Console.WriteLine("1. 열기");
                Console.WriteLine("2. 열지 않기");

                // 사용자의 입력을 읽어옵니다.
                string userInput = Console.ReadLine();

                // 사용자가 입력한 값에 따라 다른 동작을 수행합니다.
                if (userInput == "1")
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("\n");
                    Console.WriteLine("방의 문이 열리자 그곳엔 일곱난쟁이가 있었다.");
                    break; // 프로그램 종료
                }
                else if (userInput == "2")
                {
                    // 사용자가 2를 선택하면 계속 진행합니다.
                    Console.WriteLine("다시 선택하세요.");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("\n");
                }
                else
                {
                    // 잘못된 입력에 대한 안내 메시지
                    Console.WriteLine("잘못된 입력입니다. 1 또는 2를 입력하세요.");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("\n");
                }
            }

            Console.WriteLine("\n");
            //Console.WriteLine("방의 문이 열리자 그곳엔 일곱난쟁이가 있었다.");

            Console.WriteLine("=== 첫번째 난쟁이가 말했다. ===");
            Console.WriteLine("용케 여기까지 왔군. 하지만 여태까지 이 방을 나간 먹잇감은 없었소.");
            Console.WriteLine("이곳은 당신의 운을 시험하는 곳.");
            Console.WriteLine("4개의 문 중 오직 하나만이 밖으로 통하는 문이오.");
            Console.WriteLine("당신이 이 방의 시험마저 통과한다면 당신을 살려서 보내주지.");
            Console.WriteLine("하지만 만약 틀린 문을 열게 된다면...");
            Console.WriteLine("당신은 우리의 저녁 식사가 될 것이오.");
            Console.WriteLine("\n");

            Console.WriteLine(" ---------   ---------    ---------    ---------  ");
            Console.WriteLine(" |       |   |       |    |       |    |       |  ");
            Console.WriteLine(" |   A   |   |   B   |    |   C   |    |   D   |  ");
            Console.WriteLine(" |       |   |       |    |       |    |       |  ");
            Console.WriteLine(" ---------   ---------    ---------    ---------  ");
            Console.WriteLine("\n");


            while (true)
            {
                Console.WriteLine("=== 난쟁이들에게 이런 짓을 하는 이유를 물어볼까? ===");
                Console.WriteLine("1. 대체 당신들은 왜 이런 짓을 하는 거죠?");
                Console.WriteLine("2. 당신들은 사이코패스인가요?");

                // 사용자의 입력을 읽어옵니다.
                string userInput = Console.ReadLine();

                // 사용자가 입력한 값에 따라 다른 동작을 수행합니다.
                if (userInput == "1")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("=== 두번째 난쟁이가 말했다. ===");
                    break; // 프로그램 종료
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("=== 두번째 난쟁이가 말했다. ===");
                    Console.WriteLine("뭐 그렇게 생각할지도 모르지.");
                    break;
                }
                else
                {
                    // 잘못된 입력에 대한 안내 메시지
                    Console.WriteLine("잘못된 입력입니다. 1 또는 2를 입력하세요.");
                    Console.WriteLine("\n");
                }
            }
            
            Console.WriteLine("이 저주받은 숲속엔 먹을 게 없소.");
            Console.WriteLine("작은 동물을 잡아봤자 우리 7명의 배를 불릴 순 없지.");
            Console.WriteLine("하지만 인간들은 우리보다 훨씬 덩치가 크지 않나.");
            Console.WriteLine("그런 당신들이 길을 잃고 이곳으로 온다면 우리에겐 기회지.");

            Console.WriteLine("\n");
            Console.WriteLine("=== 백설공주가 눈을 가늘게 뜨고 말했다. ===");
            Console.WriteLine("그럼 뭐하러 문제를 맞히면 절 살려준다는 건가요? 거짓말인가요?");

            Console.WriteLine("\n");
            Console.WriteLine("=== 세번째 난쟁이가 말했다. ===");
            Console.WriteLine("우린 왕국에 살 때 잘나가던 프로그래머였소.");
            Console.WriteLine("마수로부터 왕국을 보호하는 왕국의 보호막도 우리가 만들었지.");
            Console.WriteLine("\n");


            while (true)
            {
                Console.WriteLine("=== 난쟁이들이 숲에 살고있는 이유를 물어볼까? ===");
                Console.WriteLine("1. 근데 지금은 왜 숲에서 살고 있는 거죠?");
                Console.WriteLine("2. 그럼 뭐해요? 지금은 이런 짓이나 하고 있는데.");

                // 사용자의 입력을 읽어옵니다.
                string userInput = Console.ReadLine();

                // 사용자가 입력한 값에 따라 다른 동작을 수행합니다.
                if (userInput == "1")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("=== 네번째 난쟁이가 말했다. ===");
                    break; // 프로그램 종료
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("=== 네번째 난쟁이가 말했다. ===");
                    Console.WriteLine("그래. 우리도 이러고 싶진 않았소. 누구만 아니었다면...");
                    break;
                }
                else
                {
                    // 잘못된 입력에 대한 안내 메시지
                    Console.WriteLine("잘못된 입력입니다. 1 또는 2를 입력하세요.");
                    Console.WriteLine("\n");
                }
            }

            Console.WriteLine("우리의 능력을 질투한 사냥꾼이 여왕에게 우리가 반역을 꾀한다고 거짓을 고했소.");
            Console.WriteLine("화가난 왕과 여왕은 우리를 숲으로 쫓아냈소.");
            Console.WriteLine("그때부터 우린 죽은 듯 숨어살고 있지...");

            Console.WriteLine("\n");
            Console.WriteLine("=== 백설공주가 동질감을 느끼며 안타까워 했다. ===");
            Console.WriteLine("저와 상황이 비슷하네요...");
            Console.WriteLine("저도 모함을 당해 버림받았거든요.");

            Console.WriteLine("\n");
            Console.WriteLine("=== 다섯번째 난쟁이가 말했다. ===");
            Console.WriteLine("그래. 당신 인생도 참 기구하군...");
            Console.WriteLine("원래 힌트는 안 주지만 특별히 힌트를 주겠소.");
            Console.WriteLine("당신이 올바른 문을 연다면 정말 당신을 살려주도록 하지.");
            Console.WriteLine("\n");

            while (true)
            {
                Console.WriteLine("=== 난쟁이들에게 무슨 말을 할까? ===");
                Console.WriteLine("1. 그거 참 고맙네요. 나한테 동정심이라도 들었나봐요.");
                Console.WriteLine("2. 그냥 살려주면 어디 덧나나요?");

                // 사용자의 입력을 읽어옵니다.
                string userInput = Console.ReadLine();

                // 사용자가 입력한 값에 따라 다른 동작을 수행합니다.
                if (userInput == "1")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("=== 여섯번째 난쟁이가 말했다. ===");
                    Console.WriteLine("그래...당신이 산다면 우린 한동안 굶겠지만 그것도 운명이겠지.");
                    break; // 프로그램 종료
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("=== 여섯번째 난쟁이가 말했다. ===");
                    Console.WriteLine("미안하오. 우리도 우리의 입장이 있어. 우리도 살고 싶은 것 뿐이오.");
                    break;
                }
                else
                {
                    // 잘못된 입력에 대한 안내 메시지
                    Console.WriteLine("잘못된 입력입니다. 1 또는 2를 입력하세요.");
                    Console.WriteLine("\n");
                }
            }


            Console.WriteLine("아스키코드 10진수 67을 문자로 변환했을 때 무슨 문자인지 생각해보시오.");

            Console.WriteLine("\n");
            Console.WriteLine("=== 백설공주가 중얼거렸다. ===");
            Console.WriteLine("65가 대문자 A이니까...");

            Console.WriteLine("\n");
            Console.WriteLine(" ---------   ---------    ---------    ---------  ");
            Console.WriteLine(" |       |   |       |    |       |    |       |  ");
            Console.WriteLine(" |   A   |   |   B   |    |   C   |    |   D   |  ");
            Console.WriteLine(" |       |   |       |    |       |    |       |  ");
            Console.WriteLine(" ---------   ---------    ---------    ---------  ");

            Console.WriteLine("\n");
            Console.WriteLine("Q3");
            Console.WriteLine("마지막 퀴즈를 맞히고 탈출 하세요.");
            Console.WriteLine("\n");
            Console.WriteLine("백설공주는 어떤 문을 열어야 할까요?");
            Console.WriteLine("1. A");
            Console.WriteLine("2. B");
            Console.WriteLine("3. C");
            Console.WriteLine("4. D");
            Console.WriteLine("\n");
            Console.WriteLine("알맞은 보기의 번호를 입력하세요.");
            Console.WriteLine("-----------------------------------------------------------");



            while (true)
            {
                // 사용자의 입력을 읽어옵니다.
                string userInput = Console.ReadLine();

                // 사용자가 입력한 값에 따라 다른 동작을 수행합니다.
                if (userInput == "3")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("끼익-");
                    Console.WriteLine("\n");
                    Console.WriteLine("문이 열리며 밝은 햇빛과 풀, 나무들이 보였다.");
                    Console.WriteLine("숲이었다. 이곳에 갇히기 전에 있던.");
                    Console.WriteLine("다행히도 아직 낮이었다. 밤이 되면 위험하니 서둘러 떠나야 했다.");
                    Console.WriteLine("\n");
                    Console.WriteLine("탁-  탁- 탁탁- 탁탁탁-");
                    Console.WriteLine("\n");
                    Console.WriteLine("뒤를 돌아보지도 않고 뛰기 시작했다.");
                    Console.WriteLine("역겨운 살인마들과는 인사도 하고 싶지 않았다.");
                    Console.WriteLine("드디어 탈출했다.");
                    Console.WriteLine("\n");
                    Console.WriteLine("점점 호흡이 가빠졌다.");
                    Console.WriteLine("백설공주는 태어나서 처음으로 이렇게 빨리 뛰어보았다.");
                    Console.WriteLine("비록 상황은 안 좋지만 지금처럼 자유로운 적은 백설공주 인생에 없었다.");
                    Console.WriteLine("백설공주는 홀가분하게 웃었다.");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("     CCCC  LL      EEEEEE       AA       RRRR        ");
                    Console.WriteLine("   CC      LL      EE          AAAA      RR  RR      ");
                    Console.WriteLine("   CC      LL      EEEEEE     AA  AA     RRRR        ");
                    Console.WriteLine("   CC      LL      EE        AAAAAAAA    RR  RR      ");
                    Console.WriteLine("     CCCC  LLLLLL  EEEEEE   AA      AA   RR    RR    ");
                    Console.WriteLine("------------------------------------------------------");
                    break; // 프로그램 종료
                }
                else if (userInput == "1" || userInput == "2" || userInput == "4")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("실패했습니다.");
                    Console.WriteLine("\n");
                    Console.WriteLine("탁-탁-탁-탁-탁");
                    Console.WriteLine("\n");
                    Console.WriteLine("보글보글보글");
                    Console.WriteLine("\n");
                    Console.WriteLine("백설공주는 난쟁이들의 저녁식사가 되었습니다.");
                    Console.WriteLine("난쟁이들은 짧은 묵념 후 배불리 식사했습니다.");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("\t Game Over");
                    Console.WriteLine("-------------------------------");
                    break;
                }

                else
                {
                    // 잘못된 입력에 대한 안내 메시지
                    Console.WriteLine("잘못된 입력입니다. 1,2,3,4 중에 입력하세요.");
                    Console.WriteLine("\n");
                }
            }


        }
}
}
