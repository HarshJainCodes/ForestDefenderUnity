using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update

    float enemySpawnInterval = 1f;
    float enemySpawnTimer = 0f;
    float enemySpeed = 7;

    GameObject health;
    DisplayHealth score_script;

    List<GameObject> enemySpawns = new List<GameObject>();

    [SerializeField] GameObject EnemyPrefab;

    void Start()
    {
        health = GameObject.Find("health");
        score_script = health.GetComponent<DisplayHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        enemySpawnTimer += Time.deltaTime;
        if (enemySpawnTimer > enemySpawnInterval)
        {
            enemySpawnTimer = 0f;
            SpawnEnemy();
        }

        UpdateEnemy();
    }

    void SpawnEnemy()
    {
        GameObject enmey = Instantiate(EnemyPrefab, new Vector3(Random.Range(-8f, 3f), 8f, 0f), Quaternion.identity);
        enemySpawns.Add(enmey);
    }

    void UpdateEnemy()
    {
       

        for (int i = 0; i < enemySpawns.Count; i++)
        {
            if (enemySpawns[i])
            {
                GameObject enemy = enemySpawns[i];
                enemy.transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);

                if (enemy.transform.position.y < -5)
                {
                    Destroy(enemySpawns[i]);
                    enemySpawns.RemoveAt(i);
                    score_script.UpdateHealth();

                }
            }
            else
            {
                enemySpawns.RemoveAt(i);
            }
        }
    }
}
