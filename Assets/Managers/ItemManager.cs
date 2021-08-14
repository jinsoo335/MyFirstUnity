using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject[] ItemPrefabs;
    

    private void Start()
    {
        SpawnRandom();

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

    void SpawnRandom()
    {
        GameObject prefab = ItemPrefabs[Random.Range(0, ItemPrefabs.Length)];
        Points points = new Points();
        Vector2 pos = points[Random.Range(0, points.GetLength())].GetPos();

        SpawnItem(prefab, pos);
        Invoke("SpawnRandom", 1.0f);
    }
}




enum Items
{
    Coin, SpeedUp, PowerUp, DefenseUp
}

class Points
{
    public Point[] points =
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
    public int GetLength()
    {
        return points.Length;
    }
}



public struct Point
{
    int x;
    int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Vector2 GetPos()
    {
        return new Vector2(this.x, this.y);
    }
}