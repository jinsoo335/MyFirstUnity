using UnityEngine;

public class ExceptionExample : MonoBehaviour
{
    // 예외(exception) : 오류(런타임)
    // - 컴파일 에러 : 실행시키기 전 컴파일 단계에서 발생하는 에러
    // - 런타임 에러 : 실행 도중 발생하는 에러 -> 프로그램이 비정상적으로 종료

    // * try, catch, finally    
    // try -> 예외가 날거 같은 문장
    // catch  -> 예외가 일어날시 실행할 문장
    // finally -> 예외처리가 끝난 후 실행할 문장

    void Start()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int sum = 0;

        try
        {
            User user = null;
            Debug.Log(user.name);
            for (int i = 0; i < 10; i++)
            {
                Debug.Log(arr[i]);
                sum += arr[i];
            }
        }
        catch (System.Exception exception)
        {
            Debug.Log(exception.Message);
        }
        finally
        {
            Debug.Log(sum);
        }


        Debug.Log("완료!");

    }
}
