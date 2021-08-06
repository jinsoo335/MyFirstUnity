using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    // gameObject -> 헤당 스크립트가 부착된 게임오브젝트
    // . -> ~의
    // SetActive() 메서드
    // transform

    /*
        Vector
        -> 크기와 방향을 갖는 물리값
        -> 좌표값 (x, y, z)
        * Vector2 vs Vector3
        -Vector2 : (x, y)
        -Vector3 : (x, y, z)
     */

    void Start()
    {
        //SetActive() 메서드 .. 껏다 키기, 존재 유무 표현
        //bool isHidden = false; 
        //bool isDead = false; 

        //gameObject.SetActive(!(isHidden || isDead));


        // transform.position
        // transform.position = Vector2.one;   // (1, 1)
        // position 값은 Vector를 이용해서만 변경할 수 있다.

        //Vector2 pos = transform.position;
        //pos.x += 3;     // (3, 0)
        //transform.position = pos;
    
        // 2. 플레이어의 이동
        // *Input.GetKey() : 키보드의 입력을 받는 메서드
        // * frame - 60fps (frame per second) 

    }
    public float speed = 0.01f;
    public GameObject BulletPrefab;
    public float bulletSpeed = 100;
    //public GameObject Gun;    gameObject Gun을 유니티에서 생성한 후 player에 종속시켜 사용할 수 있음

    void Update()
    {
       if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }
       if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed, 0);
        }
       if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }
       if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed, 0);
        }

        // GetKeyDown 눌렸을 때 최초 1회만 적용
        if (Input.GetKeyDown(KeyCode.Space))
        {

            for (int i = 0; i < 3; i++)
            {
                GameObject bullet = Instantiate(BulletPrefab);

                Vector3 bulletStartPositon = transform.position + new Vector3(0, 0.3f, 0);
                bulletStartPositon.y += i * 0.3f;
                bullet.transform.position = bulletStartPositon;

                //Vector3 bulletStartPos = Gun.transform.position;
                //bulletStartPos.y += i * 0.3f;
                //bullet.transform.position = bulletStartPos;


                bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed);  // (0, 1) * 100 = (0, 100)
             
            }

        }


    }

}
