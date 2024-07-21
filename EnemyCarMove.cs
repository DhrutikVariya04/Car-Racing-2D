using Unity.VisualScripting;
using UnityEngine;

public class EnemyCarMove : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (PlayerScript.GameOver) return;

        transform.position = new Vector3(
            transform.position.x,
            transform.position.y - 0.02f,
            transform.position.z);

        if (transform.position.y <= -5.89)
        {
            Destroy(gameObject);
        }
    }
}
