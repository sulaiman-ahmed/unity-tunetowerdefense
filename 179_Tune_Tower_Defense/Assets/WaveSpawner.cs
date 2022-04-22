using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    
    public Transform enemyPrefab;
    public Transform spawnPoint;

    public float waveTime = 5f;
    private float count = 2f;
    private int waveNumber = 0;
    public int totalWaves = 5;


    void Update() {
        if(count <= 0f) {
            StartCoroutine(spawnWave());
            count = waveTime;
        } 
        count -= Time.deltaTime;
    }

    IEnumerator spawnWave() {
        waveNumber++;
        if(waveNumber <= totalWaves) {
            for(int i = 0; i < waveNumber; i++) {
            spawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        }
        
    }

    void spawnEnemy() {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

    }
}
