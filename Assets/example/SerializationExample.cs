using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SerializationExample : MonoBehaviour
{
    // serialization(직렬화) : 객체를 파일로 저장하기 좋은 형태로 가공하는 과정 

    void Start()
    {
        //User user = new User();
        //user.level = 1;
        //user.name = "chulsoo"; 

        //FileStream fs = new FileStream("C:\\Users\\jinso\\OneDrive\\바탕 화면\\data.dat", FileMode.Create);
        BinaryFormatter bf = new BinaryFormatter();

        //bf.Serialize(fs, user);
        //fs.Close();

        FileStream fs = new FileStream("C:\\Users\\jinso\\OneDrive\\바탕 화면\\data.dat", FileMode.Open);
        User user = (User)bf.Deserialize(fs);
        Debug.Log(user.level);
        Debug.Log(user.name);
    }

}


[System.Serializable]
class User
{
    public int level;
    public string name;
}