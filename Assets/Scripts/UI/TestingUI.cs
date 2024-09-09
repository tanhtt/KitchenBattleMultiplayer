using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using Unity.Networking;
using Unity.Networking.Transport;
using UnityEngine;
using UnityEngine.UI;

public class TestingUI : MonoBehaviour
{
    [SerializeField] private Button hostBtn;
    [SerializeField] private Button clientBtn;

    private void Awake()
    {
        hostBtn.onClick.AddListener(() =>
        {
            Debug.Log("HOST");
            NetworkManager.Singleton.StartHost();
            Hide();
        });

        clientBtn.onClick.AddListener(() =>
        {
            Debug.Log("CLIENT");
            NetworkManager.Singleton.StartClient();
            Hide();
        });
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
