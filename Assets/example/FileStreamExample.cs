using System.IO;
using UnityEngine;

public class FileStreamExample : MonoBehaviour
{
    // ���� �� �����Ǵ� ������ -> �޸𸮿� ���� -> ������ ����Ǹ� ����.  -> �����Ǿ�� �ϴ� �����ʹ� ���� ���·� ��ũ�� �����ؾ� �Ѵ�.
    // * Desktop ���
    // - Window : C:/Users/jinsoo/Desktop

    // * ���� ����
    // - FileStream  ��ü ����
    // - ��ο� ���ϸ�� �Է�(Create)

    // * ���Ͽ� �ؽ�Ʈ�� ����
    // - StreamWriter ��ü ����
    // - Write() �޼���� ����
    
    // * ������ �ϱ�
    // - StreamReader ��ü ����
    // - ReadLine() �޼���� �б�

    // * ���̳ʸ� ����(������)�� ���� ���� �б�
    // - BinaryWrite, BinaryReader
    // - ���ڵ� : �ؽ�Ʈ ���� ������ ���¸� ���̳ʸ� ���·� ��ȯ�ϴ� ���� (utf - 8)


    private void Start()
    {
        FileStream fs = new FileStream("C:\\Users\\jinso\\OneDrive\\���� ȭ��\\example.txt", FileMode.Create);
        StreamWriter sw = new StreamWriter(fs);
        sw.Write("�ȳ��ϼ���");
        sw.Close();

        fs = new FileStream("C:\\Users\\jinso\\OneDrive\\���� ȭ��\\example.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        Debug.Log(sr.ReadLine());      //  ���� �б�
        sr.Close();

        FileStream fs2 = new FileStream("C:\\Users\\jinso\\OneDrive\\���� ȭ��\\exampleBin.txt", FileMode.Create);
        BinaryWriter bw = new BinaryWriter(fs2);    
        bw.Write("�ȳ��ϼ���");      // ���̳ʸ��� �����߱� ������ ���� ���� Ÿ���� �˾ƾ� ������ �� ����
        bw.Write(945);               // ���ڵ��� ��ġ�� �ʰ� �����߱� ������ ������ ���� ���ڰ� �����ִ�.  
        bw.Close();           

        fs2 = new FileStream("C:\\Users\\jinso\\OneDrive\\���� ȭ��\\exampleBin.txt", FileMode.Open);
        BinaryReader br = new BinaryReader(fs2);
        string str = br.ReadString();
        int num = br.ReadInt32();
        Debug.Log(str);
        Debug.Log(num);
        br.Close();



    }
    
}
