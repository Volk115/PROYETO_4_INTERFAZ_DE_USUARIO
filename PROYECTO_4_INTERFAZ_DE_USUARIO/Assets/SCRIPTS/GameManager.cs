using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public GameObject[] targetPrefabs;
    public Vector3 randomSpawnPos;

    private float minX = -3.75f;
    private float minY = -3.75f;
    private float spaceBetweenSquares = 2.5f;
    private int numberRows = 4;

    //CADA DOS SEGUNDOS APARECERA UN OBJETO EN PANTALLA
    private float spawnRate = 2f;

    private void start()
    {
        StartCoroutine("SpawnRandomTarget");

    }

    public Vector3 RandomSpawnPosition()
    {
        //GENERA UNA POSIION ALEATORIA EN UNO DE LOS CENTROS DE LOS 16 CUADRADOS
        int randomInt = Random.Range(0, numberRows);
        float randomPosX = minX + randomInt * spaceBeatweenSquares;
        float randomPosY = minY + randomInt * spaceBeatweenSquares;

        return new Vector3(randomPosX, randomPosY, 0);
    }

    private IEnumerator SpawnRandomTarget()
    {
        yield return new WaitForSeconds(spawnRate);

        int randomIndex = RandomSpawnPosition.Range(0, tardetPrefabs.Length);
        randomSpawnPos = RandomSpawnPosition();

        //COMPROBAR SI LA POSICIO ESTA LIBRE

        Instantiate(targetPrefabs[randomIndex],
            randomSpawnPos, targetPrefabs[randomIndex], transform, rotation);

    }

}
