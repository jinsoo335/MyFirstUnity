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
     *  - 게임 데이터 저장
     *  1. PlayerPrefs - 간단한 숫자, 문자열 등을 저장할 때 사용.
     *  - SetInt, GetInt, Save 등의 메서드 이용
     *  
     *  2. User Data 객체를 저장
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

        // bestScore 로드
        //bestScore = PlayerPrefs.GetInt("bestScore", 0);     // "bestScore" 가 없다면 0으로 초기화
        LoadUserData();
        BestScoreText.text = String.Format("Best Score : {0}", userData.bestScore);

    }

    void OnEnemyDie()
    {
        score++;
        ScoreText.text = String.Format("Score : {0}", score);

        // 만약 score > bestscore -> 갱신! 데이터 저장.
        if (score > userData.bestScore)
        {
            userData.bestScore = score;
            BestScoreText.text = String.Format("Best Score : {0}", userData.bestScore);

            //PlayerPrefs.SetInt("bestScore", bestScore); // key, value 로 저장
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
        //if (File.Exists(Application.persistentDataPath + "\\userData.dat"))     //  경로에 파일이 존재하는 경우에 true 반환 없으면 false 반환
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

[System.Serializable]   // 클래스의 객체를 Serialize 할때 가능한 클래스인지 표시해야함
class UserData
{
    public int bestScore;
}