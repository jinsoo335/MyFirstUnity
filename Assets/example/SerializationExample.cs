using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SerializationExample : MonoBehaviour
{
    // serialization(����ȭ) : ��ü�� ���Ϸ� �����ϱ� ���� ���·� �����ϴ� ���� 

    void Start()
    {
        //User user = new User();
        //user.level = 1;
        //user.name = "chulsoo"; 

        //FileStream fs = new FileStream("C:\\Users\\jinso\\OneDrive\\���� ȭ��\\data.dat", FileMode.Create);
        BinaryFormatter bf = new BinaryFormatter();

        //bf.Serialize(fs, user);
        //fs.Close();

        FileStream fs = new FileStream("C:\\Users\\jinso\\OneDrive\\���� ȭ��\\data.dat", FileMode.Open);
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