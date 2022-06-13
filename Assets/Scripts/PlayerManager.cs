using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    public GameObject gameOverPanel;
    

    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "LoseBox")
        {
            Destroy(gameObject);
            gameOverPanel.SetActive(true);
            Debug.Log("HitCollider");
            
        }
        
    }

   
}
