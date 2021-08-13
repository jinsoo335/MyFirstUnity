using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject EnemyPrefab1;
    public GameObject EnemyPrefab2;

    private void Start()
    { 
        SpawnEnemy(EnemyPrefab1, new Vector3(-1, 1, 0));
        SpawnEnemy(EnemyPrefab2, new Vector3(1, 1, 0));

        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            SpawnEnemy(EnemyPrefab1, new Vector3(i, j, 0));
        //        }
        //        else
        //        {
        //            SpawnEnemy(EnemyPrefab2, new Vector3(i, j, 0));

        //        }
                
        //    }
        //}

    }


    void SpawnEnemy(GameObject prefab, Vector3 position)
    {
        GameObject enemy = Instantiate(prefab);
        enemy.transform.position = position;
        enemy.GetComponent<Enemy>().Move();

    }

}
