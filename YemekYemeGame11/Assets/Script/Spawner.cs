using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float Xmin = -6;
    private float Xmax = 6;
    public   List<GameObject> SpawnFood;
    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject(float Time)
    {
        while (true)
        {
            int randomIndex = Random.Range(0, SpawnFood.Count);
            GameObject objectToinstantine = SpawnFood[randomIndex];

            float randomX = Random.Range(Xmin, Xmax);
            Instantiate(objectToinstantine, new Vector3(randomX, 4.5f, 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
            
        }
        
    }


        

}
