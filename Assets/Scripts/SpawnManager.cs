using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obsticalPrefabs;
    public GameObject spawnposition;

    GameManager gamem;
    // Start is called before the first frame update
    void Start()
    {
        gamem = GameObject.FindGameObjectWithTag("gamemanager").GetComponent<GameManager>();
        if(gamem.gameover==false)
        {
            InvokeRepeating("SpawnRandomObstical", 2, 2.5f);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomObstical()
    {
        if (gamem.gameover == false)
        {
            int obsticalIndex = Random.Range(0, obsticalPrefabs.Length);
            if (obsticalIndex == 0)
            {
                Instantiate(obsticalPrefabs[0], new Vector3(-11.8f, 1.5f, 0.87f), obsticalPrefabs[0].transform.rotation);
            }
            else if (obsticalIndex == 1)
            {
                Instantiate(obsticalPrefabs[1], new Vector3(-11.56f, 1.45f, 0.22f), obsticalPrefabs[1].transform.rotation);
            }
            else if (obsticalIndex == 2)
            {
                Instantiate(obsticalPrefabs[2], new Vector3(-11.58f, 1.5f, 1.43f), obsticalPrefabs[2].transform.rotation);
            }
        }
            
        //Instantiate(obsticalPrefabs[obsticalIndex], spawnposition.transform.position, obsticalPrefabs[obsticalIndex].transform.rotation);
    }
}
