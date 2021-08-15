using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemManager : MonoBehaviour
{
    public GameObject[] ItemPrefabs;
    

    private void Start()
    {
        //SpawnRandom();

        //GameObject CoinPrefab = GetItem(Items.Coin);

        //for (int i =0; i < 5; i++)
        //{
        //    Points points = new Points();
        //    GameObject itemPrefab = ItemPrefabs[Random.Range(0, ItemPrefabs.Length)];
        //    Vector2 pos = points[Random.Range(0, points.GetLength())].GetPos();

        //    SpawnItem(itemPrefab, pos);
        //}
    }

    GameObject GetItem(Items item)
    {
        return ItemPrefabs[(int)item];
    }

    void SpawnItem(GameObject itemPrefab, Vector2 pos)
    {
        GameObject item = Instantiate(itemPrefab);
        item.transform.position = pos;
    }

    public IEnumerator SpawnRandom()
    {
        while (true)
        {
            GameObject prefab = ItemPrefabs[Random.Range(0, ItemPrefabs.Length)];
            Vector2 pos = Points.points[Random.Range(0, Points.points.Count)].GetPos();

            SpawnItem(prefab, pos);
            yield return new WaitForSeconds(1.0f);
        }
    }
 
}




enum Items
{
    Coin, SpeedUp, PowerUp, DefenseUp
}

class Points
{
    public static List<Point> points = new List<Point>
    {
        new Point(0, 0),
        new Point(1, 0),
        new Point(0, 1),
        new Point(2, 0),
        new Point(0, 2),
        new Point(-1, 0),
        new Point(0, -1),
        new Point(-2, 0),
        new Point(0, -2),
    };

    public Point this[int index]
    {
        get
        {
            return points[index];
        }
        set
        {
            points[index] = value;
        }
    }
    public int GetCount()
    {
        return points.Count;
    }
}



public struct Point
{
    float x;
    float y;

    public Point(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public Vector2 GetPos()
    {
        return new Vector2(this.x, this.y);
    }
}