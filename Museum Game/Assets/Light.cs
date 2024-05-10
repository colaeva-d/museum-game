using UnityEngine;

public class LightController : MonoBehaviour
{
    private Light gameLight;

    void Start()
    {
        // Get the Light component attached to this GameObject
        gameLight = GetComponent<Light>();

        if (gameLight == null)
        {
            Debug.LogError("Light component not found!");
        }
    }

    void Update()
    {
        // Example usage: Turn the light on and off
        if (Input.GetKeyDown(KeyCode.Space) && gameLight != null)
        {
            gameLight.enabled = !gameLight.enabled;
        }
    }
}
