using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportPlayer : MonoBehaviour
{
    public Network network;

    private void Start()
    {
        network = FindObjectOfType<Network>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Jungmyo")
        {
            Debug.Log("������ ���� ��");
            network.CreatRoom(0);
        }
        else if(other.tag == "Gwanghwamun")
        {
            Debug.Log("��ȭ������ ���� ��");
            network.CreatRoom(1);
        }
        else if(other.tag == "Bugchonmunhwa")
        {
            Debug.Log("�������� ���� ��");
            network.CreatRoom(2);
        }
    }
}
