using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InstrumentWindowManager : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 2;
    public GameObject OuWindow;
    public GameObject ChuckWindow;
    public GameObject ajangWindow;
    public GameObject jingoWindow;

    public void grabOu()
    {
        OuWindow.SetActive(!OuWindow.activeSelf);

        OuWindow.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;

        OuWindow.transform.LookAt(new Vector3(head.position.x, head.position.y, head.position.z));

        OuWindow.transform.forward *= -1;
    }

    public void ungrabOu()
    {
        OuWindow.SetActive(false);  
    }

    public void grabChuck()
    {
        ChuckWindow.SetActive(!ChuckWindow.activeSelf);
        ChuckWindow.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        ChuckWindow.transform.LookAt(new Vector3(head.position.x, head.position.y, head.position.z));
        ChuckWindow.transform.forward *= -1;
    }

    public void ungrabChuck()
    {
        ChuckWindow.SetActive(false);
    }

    public void grabAjang()
    {
        ajangWindow.SetActive(!ajangWindow.activeSelf);
        ajangWindow.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        ajangWindow.transform.LookAt(new Vector3(head.position.x, head.position.y, head.position.z));
        ajangWindow.transform.forward *= -1;
    }

    public void ungrabAjang()
    {
        ajangWindow.SetActive(false);
    }

    public void grabJingo()
    {
        jingoWindow.SetActive(!jingoWindow.activeSelf);
        jingoWindow.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        jingoWindow.transform.LookAt(new Vector3(head.position.x, head.position.y, head.position.z));
        jingoWindow.transform.forward *= -1;
    }
    public void ungrabJingo()
    {
        jingoWindow.SetActive(false);
    }

}
