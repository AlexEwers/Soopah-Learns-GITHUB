using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;
    private Rigidbody2D Rigidbody;

    private void Start()
    {
        
        gm = GameMaster.instance;
        Rigidbody = GetComponent<Rigidbody2D>();
        Debug.Log($"lastCheckPointPos = {gm.lastCheckPointPos}");
        Rigidbody.position = gm.lastCheckPointPos;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}

    