using UnityEngine;

public class Object : MonoBehaviour
{
    public float speed;
    public float rotateAngle = 10;
    void Start()
    {
        Destroy(this.gameObject, 5);
    }

    void FixedUpdate()
    {
        transform.position -= new Vector3(0f, 0.12f*speed, 0f);
        transform.Rotate(0, 0, rotateAngle * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            Destroy(this.gameObject);
        }
    }
}
