using UnityEngine;

public class EnemyCars : MonoBehaviour
{
    public GameObject[] Cars;

    void Start()
    {
        InvokeRepeating("CarSpawn", 2f, 2f);
    }

    void CarSpawn()
    {
        if (PlayerScript.GameOver) return;

        var car = Instantiate(
            Cars[Random.Range(0, 3)],
            new Vector3(
                Random.Range(-1.8f, 1.8f),
                transform.position.y,
                transform.position.z),
            Quaternion.identity
            );
    }
}
