using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusRandom : MonoBehaviour
{
    public GameObject cactusPrefab1;
    public GameObject cactusPrefab2;
    private float wait = 1.5f;

    private void Start()
    {
        StartCoroutine(SpawnPrefab());
    }

    private void Update()
    {
    }

    private IEnumerator SpawnPrefab()
    {
        while (true)
        {
            float a = Random.Range(4.5f, 6f);
            GameObject spawnCactus1 = (GameObject)Instantiate(cactusPrefab1, new Vector3(a, 0f, 0f), Quaternion.identity);

            yield return new WaitForSeconds(wait);

            float b = Random.Range(5f, 9f);
            GameObject spawnCactus2 = (GameObject)Instantiate(cactusPrefab2, new Vector3(b, 0f, 0f), Quaternion.identity);

            yield return new WaitForSeconds(wait);
        }
    }
}