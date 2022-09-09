using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneHelper : MonoBehaviour
{
    [SerializeField]
    private Image image;

    [SerializeField]
    private float timeToOpenNextScene;

    [SerializeField]
    private string sceneToOpen;

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

        yield return new WaitForSeconds(timeToOpenNextScene);

        OpenSceneByName(sceneToOpen);
    }
}
