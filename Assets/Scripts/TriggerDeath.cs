using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//delete this after the fix
using UnityEngine.SceneManagement;

public class TriggerDeath : MonoBehaviour
{
    Restart resetter;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        //this gives me a null reference exception so im just gonna ignore DRY rn
        //resetter.restartGame();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
