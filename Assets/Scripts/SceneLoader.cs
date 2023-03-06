using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public float duration = 3.0f;
    public Color startColor = Color.black;
    public Color endColor = Color.white;
    private float t = 0.0f;
    private Image image;
    private Text buttonText;
    

    void Start()
    {
        image = GetComponent<Image>();
        buttonText = GetComponentInChildren<Text>();
        Invoke("ChangeTextColor", 3.0f);
    }

    void Update()
    {
        t += Time.deltaTime / duration;
        image.color = Color.Lerp(startColor, endColor, t);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator ChangeTextColor()
    {
        float timeElapsed = 0.0f;
        float totalTime = 3.0f;
        Color startColor = Color.clear;
        Color endColor = Color.white;

        while (timeElapsed < totalTime)
        {
            timeElapsed += Time.deltaTime;
            float t = timeElapsed / totalTime;
            buttonText.color = Color.Lerp(startColor, endColor, t);
            yield return null;
        }

        buttonText.color = endColor;
    }
}
