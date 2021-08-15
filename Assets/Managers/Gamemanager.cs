using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Gamemanager : MonoBehaviour
{
    /* 
     *  - ���� ������ ����
     *  1. PlayerPrefs - ������ ����, ���ڿ� ���� ������ �� ���.
     *  - SetInt, GetInt, Save ���� �޼��� �̿�
     *  
     *  2. User Data ��ü�� ����
     * 
     */ 




    public GameObject Cover;
    public ItemManager itemManager;
    public SpawnManager spawnManager;

    int score = 0;
    //int bestScore = 0;
    UserData userData;
    public Text ScoreText;
    public Text BestScoreText;

    public void OnClickStartBtn()
    {
        Cover.SetActive(false);
        StartCoroutine(itemManager.SpawnRandom());
        StartCoroutine(spawnManager.SpawnRandom());

    }


    void Start()
    {
        EventManager.EnemyDieEvent += OnEnemyDie;
        ScoreText.text = String.Format("Score : {0}", score);

        // bestScore �ε�
        //bestScore = PlayerPrefs.GetInt("bestScore", 0);     // "bestScore" �� ���ٸ� 0���� �ʱ�ȭ
        LoadUserData();
        BestScoreText.text = String.Format("Best Score : {0}", userData.bestScore);

    }

    void OnEnemyDie()
    {
        score++;
        ScoreText.text = String.Format("Score : {0}", score);

        // ���� score > bestscore -> ����! ������ ����.
        if (score > userData.bestScore)
        {
            userData.bestScore = score;
            BestScoreText.text = String.Format("Best Score : {0}", userData.bestScore);

            //PlayerPrefs.SetInt("bestScore", bestScore); // key, value �� ����
            //PlayerPrefs.Save();
            SaveUserData();
        }

    }
    
    void SaveUserData()
    {
        // Application.persistentDataPath
        FileStream fs = new FileStream(Application.persistentDataPath + "\\userData.dat", FileMode.Create);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fs, userData);
        fs.Close();
    }

    void LoadUserData()
    {
        //if (File.Exists(Application.persistentDataPath + "\\userData.dat"))     //  ��ο� ������ �����ϴ� ��쿡 true ��ȯ ������ false ��ȯ
        //{
        //    FileStream fs = new FileStream(Application.persistentDataPath + "\\userData.dat", FileMode.Open);
        //    BinaryFormatter bf = new BinaryFormatter();
        //    userData = (UserData)bf.Deserialize(fs);
        //    fs.Close();
        //}
        //else
        //{
        //    userData = new UserData();
        //}

        try
        {
            FileStream fs = new FileStream(Application.persistentDataPath + "\\userData.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            userData = (UserData)bf.Deserialize(fs);
            fs.Close();
        }
        catch(System.Exception ex) 
        {
            Debug.Log(ex.Message);
            userData = new UserData();
        }



    }

}

[System.Serializable]   // Ŭ������ ��ü�� Serialize �Ҷ� ������ Ŭ�������� ǥ���ؾ���
class UserData
{
    public int bestScore;
}