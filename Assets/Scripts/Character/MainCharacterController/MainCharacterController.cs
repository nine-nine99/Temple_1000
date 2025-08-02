using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterController : SingletonMonoBehavior<MainCharacterController>
{
    // 玩家角色预制体
    public GameObject playerPrefab;
    // 摄像机
    public Camera mainCamera;
    // 玩家对象
    private GameObject playerInstance;



    // 初始化玩家角色
    public void InitPlayer()
    {
        if (playerPrefab != null)
        {
            playerInstance = Instantiate(playerPrefab, new Vector3(8, 0.65f, 0), Quaternion.identity);
            playerInstance.transform.SetParent(this.transform, true);

            // 设置摄像机为playerInstance子物体
            if (mainCamera != null)
                {
                    mainCamera.transform.SetParent(playerInstance.transform);
                    mainCamera.transform.localPosition = new Vector3(5.0f, 6.6f, -16.0f); // 调整摄像机位置(5.0f, 6.6f, -16.0f)
                    mainCamera.transform.localRotation = Quaternion.Euler(10.44526f,345.539795f,359.053223f); // 调整摄像机角度Vector3(10.44526,345.539795,359.053223)
                }
        }
        else
        {
            Debug.LogError("Player prefab is not assigned!");
        }
    }
}
