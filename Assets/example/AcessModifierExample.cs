using UnityEngine;

public class AcessModifierExample : MonoBehaviour
{
    // 접근제한자
    // - 캡슐화에서 정보를 은닉하는 방법 중 하나
    // - 주로 멤버의 앞에 붙어 수식하는 형태

    // 접근제한자의 종류
    // 1. public : 외부에 공개
    // 2. internal : 같은 어셈블리에서 접근 가능 (유니티에서는 한 프로젝트가 어셈블리)
    // 3. protected : 파생클레스에서만 접근 가능
    // 4. private : 외부에 공개하지 않음

    // 멤버의 경우 접근제한자를 생략할 경우 직접 명시하지 않더라도 private으로 설정된다.
    // 단 class의 경우 접근제한자를 생략할 경우 internal로 설정된다.

    void Start()
    {
        Human john = new Human();
        john.Age = 1;
        john.Eat();

    }
}
