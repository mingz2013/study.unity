using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 一波敌人
public class EnemySpwaner : MonoBehaviour
{
    public static int CountEnemyAlive = 0;
    public Wave[] waves;
    public Transform START;
    public float waveRate = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());// 启动协程
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 协程
    IEnumerator SpawnEnemy()
    {
        foreach(Wave wave in waves)
        {
            for(int i = 0; i < wave.count; i++)
            {
                GameObject.Instantiate(wave.enemyPrefab, START.position, Quaternion.identity);
                CountEnemyAlive++;

                if(i != wave.count - 1)
                {
                    yield return new WaitForSeconds(wave.rate);
                }

            }

            while(CountEnemyAlive > 0)
            {
                yield return 0;
            }

            yield return new WaitForSeconds(waveRate);

        }
    }

}
