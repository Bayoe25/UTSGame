using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVirus : MonoBehaviour
{
    public GameObject enemy;
    public float timeMinimal, timeMaximal;
    public float minimalPosition, maximalPosition;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(VirusEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator VirusEnemy()
    {
        Instantiate(enemy, transform.position + Vector3.right * Random.Range(minimalPosition,maximalPosition)
        , Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(timeMinimal,timeMaximal));
        StartCoroutine(VirusEnemy());
    }
}
