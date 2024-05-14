using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InfoPlaqueButton : MonoBehaviour
{
    public GameObject detailPanel;

    public void OpenClose()
    {
        Debug.Log("check");
        if (detailPanel.activeInHierarchy == false)
        {
            detailPanel.SetActive(true);
            Debug.Log("erscheint");
        }
        else
        {
            detailPanel.SetActive(false);
            Debug.Log("verschwindet");
        }
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("Works!");
        if (detailPanel.activeInHierarchy == false)
        {
            detailPanel.SetActive(true);
            Debug.Log("erscheint");
        }
        else
        {
            detailPanel.SetActive(false);
            Debug.Log("verschwindet");
        }
    }
}
