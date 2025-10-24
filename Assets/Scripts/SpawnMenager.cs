using UnityEngine;

public class SpawnMenager : MonoBehaviour
{
    public float xRange;
    public GameObject[] animalPrefabs;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), 2.5f, 2.0f);

    }

    // Update is called once per frame
    void Update()
    {
    }
       
    void SpawnRandomAnimal()
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(
                Random.Range(-xRange, xRange),
                0,
                transform.position.z
            );


            Instantiate(
                animalPrefabs[animalIndex],
                spawnPos,
                animalPrefabs[animalIndex].transform.rotation);


    }
}
