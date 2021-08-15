using System.IO;
using UnityEngine;

public class FileStreamExample : MonoBehaviour
{
    // 게임 중 생성되는 데이터 -> 메모리에 저장 -> 게임이 종료되면 유실.  -> 유지되어야 하는 데이터는 파일 형태로 디스크에 저장해야 한다.
    // * Desktop 경로
    // - Window : C:/Users/jinsoo/Desktop

    // * 파일 생성
    // - FileStream  객체 생성
    // - 경로와 파일모드 입력(Create)

    // * 파일에 텍스트를 쓰기
    // - StreamWriter 객체 생성
    // - Write() 메서드로 쓰기
    
    // * 파일을 일기
    // - StreamReader 객체 생성
    // - ReadLine() 메서드로 읽기

    // * 바이너리 형태(이진수)로 파일 쓰고 읽기
    // - BinaryWrite, BinaryReader
    // - 인코딩 : 텍스트 등의 데이터 형태를 바이너리 형태로 변환하는 과정 (utf - 8)


    private void Start()
    {
        FileStream fs = new FileStream("C:\\Users\\jinso\\OneDrive\\바탕 화면\\example.txt", FileMode.Create);
        StreamWriter sw = new StreamWriter(fs);
        sw.Write("안녕하세요");
        sw.Close();

        fs = new FileStream("C:\\Users\\jinso\\OneDrive\\바탕 화면\\example.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        Debug.Log(sr.ReadLine());      //  한줄 읽기
        sr.Close();

        FileStream fs2 = new FileStream("C:\\Users\\jinso\\OneDrive\\바탕 화면\\exampleBin.txt", FileMode.Create);
        BinaryWriter bw = new BinaryWriter(fs2);    
        bw.Write("안녕하세요");      // 바이너리로 저장했기 때문에 읽을 때도 타입을 알아야 가져올 수 있음
        bw.Write(945);               // 인코딩을 거치지 않고 저장했기 때문에 파일을 열면 글자가 깨져있다.  
        bw.Close();           

        fs2 = new FileStream("C:\\Users\\jinso\\OneDrive\\바탕 화면\\exampleBin.txt", FileMode.Open);
        BinaryReader br = new BinaryReader(fs2);
        string str = br.ReadString();
        int num = br.ReadInt32();
        Debug.Log(str);
        Debug.Log(num);
        br.Close();



    }
    
}
