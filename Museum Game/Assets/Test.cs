using UnityEngine;

public class LightControllers : MonoBehaviour
{
    private Light[] allMuralLights;

    void Start()
    {
        FindAllMuralLights();

        if (allMuralLights.Length == 0)
        {
            Debug.LogError("No lights found in any Mural GameObjects!");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleAllMuralLights();
        }
    }

    void FindAllMuralLights()
    {
        GameObject[] muralObjects = GameObject.FindGameObjectsWithTag("Mural");
        int totalLights = 0;

        foreach (GameObject muralObject in muralObjects)
        {
            Light[] muralLights = muralObject.GetComponentsInChildren<Light>();
            totalLights += muralLights.Length;
        }

        allMuralLights = new Light[totalLights];
        int index = 0;

        foreach (GameObject muralObject in muralObjects)
        {
            Light[] muralLights = muralObject.GetComponentsInChildren<Light>();
            muralLights.CopyTo(allMuralLights, index);
            index += muralLights.Length;
        }
    }

    void ToggleAllMuralLights()
    {
        foreach (Light light in allMuralLights)
        {
            light.enabled = !light.enabled;
        }
    }
}
