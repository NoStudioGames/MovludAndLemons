using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float objectTimer;
    public float objectTimerMax;
    public GameObject[] objects;
    public float sideMax;
    public GameManager gameManager;
    void Start()
    {
        objectTimer = objectTimerMax;
    }

    void Update()
    {
        if (!gameManager.isGame)
        {
            return;
        }
        if (objectTimer > 0)
        {
            objectTimer -= Time.deltaTime;
        }
        else
        {
            objectTimer = objectTimerMax;
            int objectType = Random.Range(0, 100);
            float pos_x = Random.Range(-sideMax, sideMax);
            if(objectType < 80){
                Instantiate(objects[0], new Vector3(pos_x, transform.position.y, transform.position.z), Quaternion.identity);
            }else {
                Instantiate(objects[1], new Vector3(pos_x, transform.position.y, transform.position.z), Quaternion.identity);
            }

        }
    }
}
