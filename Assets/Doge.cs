using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Doge : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float jumpHeight = 1f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = RandomSpawnPosition();
    }
    Vector3 RandomSpawnPosition()
    {
        float spawnPosX = RandomSquareIndex();
        float spawnPosY = RandomSquareIndex();

        Vector3 spawnPosition = new Vector3(spawnPosX, spawnPosY, 0);
        return spawnPosition;
    }
    int RandomSquareIndex()
    {
        return Random.Range(-2, 2);
    }
}
