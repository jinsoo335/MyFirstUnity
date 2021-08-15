using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;

    private void Start()
    {
        EventManager.EnemyDieEvent += OnEnemyDie;
        //SpawnRandom();

        //SpawnEnemy(EnemyPrefab1, new Vector3(-1, 1, 0));
        //SpawnEnemy(EnemyPrefab2, new Vector3(1, 1, 0));

        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        if (j % 2 == 0)
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

    public IEnumerator SpawnRandom()
    {
        while (true)    // ��� �ݺ���
        {
            GameObject prefab = EnemyPrefabs[Random.Range(0, EnemyPrefabs.Length)];
            Points points = new Points();
            Vector2 pos = points[Random.Range(0, points.GetCount())].GetPos();

            SpawnEnemy(prefab, pos);
            yield return new WaitForSeconds(1.0f);  //  ������� ȣ���� ������ �Ѿ�ٰ� 1.0f �� �Ŀ� �ٽ� ������� ã�ƿ�

        }
    }

    void SpawnEnemy(GameObject prefab, Vector3 position)
    {
        GameObject enemy = Instantiate(prefab);
        enemy.transform.position = position;
        enemy.GetComponent<Enemy>().Move();

    }

    void OnEnemyDie()
    {
        float x = Random.Range(-3.0f, 3.0f);
        float y = Random.Range(-5.0f, 5.0f);
        Point point = new Point(x, y);

        Points.points.Add(point);
        Debug.Log(Points.points.Count);
    }

}
