using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float objectTimer;
    public float objectTimerMax;
    public GameObject[] objects;
    public float sideMax;
    void Start()
    {
        objectTimer = objectTimerMax;
    }

    void Update()
    {
        if (objectTimer > 0)
        {
            objectTimer -= Time.deltaTime;
        }
        else
        {
            objectTimer = objectTimerMax;
            int objectType = Random.Range(0, objects.Length);
            float pos_x = Random.Range(-sideMax, sideMax);

            Instantiate(objects[objectType], new Vector3(pos_x, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }
}
