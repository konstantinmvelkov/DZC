using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireballDead : MonoBehaviour
{
    public AudioSource dieSound;

    private bool dead = false;

    public void Die()
    {
        if (!dead)
        {
            dieSound.Play();
            dead = true;
            StartCoroutine(waitReset());
        }
    }

    IEnumerator waitReset()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
