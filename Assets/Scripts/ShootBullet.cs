using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    // Start is called before the first frame update
    float bulletSpeed = 10;
    [SerializeField] GameObject Bullet;

    List<GameObject> bullets = new List<GameObject>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Instantiate(Bullet, transform.position, transform.rotation);
            bullets.Add(b);
        }

        UpdateBullet();
    }

    void UpdateBullet()
    {
        for (int i = 0; i < bullets.Count; i++)
        {
            if (bullets[i] != null)
            {
                GameObject bullet = bullets[i];
                bullet.transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);

                if (bullet.transform.position.y > 6)
                {
                    Destroy(bullet);
                    bullets.RemoveAt(i);
                }
            }
            
        }
    }
}
