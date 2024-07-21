using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public static bool GameOver = false;
    public GameObject Canvas;

    void Update()
    {
        if(GameOver)return;

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (transform.position.x >= -1.80)
            {
                transform.position = new Vector3(
                    transform.position.x - .05f,
                    transform.position.y,
                    transform.position.z);
            }
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (transform.position.x <= 1.80)
            {
                transform.position = new Vector3(
                    transform.position.x + .05f,
                    transform.position.y,
                    transform.position.z);
            }
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow) ||  Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            if (transform.position.y <= 4.10)
            {
                transform.position = new Vector3(
                    transform.position.x,
                    transform.position.y + .05f,
                    transform.position.z);
            }
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            if (transform.position.y >= -4.10)
            {
                transform.position = new Vector3(
                    transform.position.x,
                    transform.position.y - .05f,
                    transform.position.z
                    );
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("collision");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        GameOver = true;
        Canvas.SetActive(true);
    }

    public void restart()
    {
        var allEnemyCar = GameObject.FindGameObjectsWithTag("EnemyCar");
        for(int i = 0 ; i < allEnemyCar.Length; i++)
        {
            Destroy(allEnemyCar[i]);
        }
        ScoreScript.scoreeee = 0;
        Canvas.SetActive(false);
        GameOver = false;
        transform.position = new Vector3(-0.62f, -4.05f, transform.position.z);

    }
}
