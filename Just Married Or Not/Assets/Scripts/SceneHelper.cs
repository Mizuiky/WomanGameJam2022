using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneHelper : MonoBehaviour
{
    public Image image;
    public void OpenSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void showImage()
    {
        StartCoroutine(Show());
    }

    private IEnumerator Show()
    {
        image.gameObject.SetActive(true);

        yield return new WaitForSeconds(3f);

        OpenSceneByName("SCN_GamePlay");
    }
}
