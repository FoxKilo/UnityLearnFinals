using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public List<GameObject> dogePrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnDog()
    {
        Instantiate(dogePrefabs[RandomDoge()]);
    }
    private int RandomDoge()
    {
        int d = Random.Range(0, dogePrefabs.Count);
        return d;
    }
    
}
