using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tp : MonoBehaviour
{
    public GameObject interaction;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interaction.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("Next");
            }
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        interaction.SetActive(false);
    }

}
