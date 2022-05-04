using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] GameObject objectToSpawn;
    [SerializeField] Transform[] spawnPoint;

    //[SerializeField] float[] floattest = { 90, 150, 30 };

    [SerializeField] float timeUntilSpawnedObjectDestroy = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnthenDestroy();
        }
    }

    void spawnthenDestroy()
    {

        //randomindex = Random.Range(0, 3);
        for (int i = 0; i < spawnPoint.Length; i++)
        {


            GameObject newSpawn = Instantiate(objectToSpawn, spawnPoint[i].position, spawnPoint[i].rotation);
            //Destroy(newSpawn, timeuntilspawnedobjectdestroy);
            Debug.Log(spawnPoint[i].position +"sep"+ spawnPoint[i].rotation);
        }
    }
}
