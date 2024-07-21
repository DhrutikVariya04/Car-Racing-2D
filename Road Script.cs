using UnityEngine;

public class RoadScript : MonoBehaviour
{
    Renderer renderer;       
    float speeeeed = .2f;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (PlayerScript.GameOver) return;

        var offset = Time.time * speeeeed;
        renderer.material.SetTextureOffset("_MainTex", new Vector2(0f, offset));
    }

}
