using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMenuScript : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void SelectMenu()
    {
        const string path  = "Assets/Scenes/Inicio.unity";
        var sceneLoading = SceneManager.LoadSceneAsync(path);
        var cena = SceneManager.GetSceneByPath(path);
        SceneManager.SetActiveScene(cena);
    }

    public void SelectHistories()
    {
        const string path  = "Assets/Scenes/Historias.unity";
        var sceneLoading = SceneManager.LoadSceneAsync(path);
        var cena = SceneManager.GetSceneByPath(path);
        SceneManager.SetActiveScene(cena);
    }

    public void SelectQuiz()
    {
        
        const string path  = "Assets/Scenes/Quiz.unity";
        var sceneLoading = SceneManager.LoadSceneAsync(path);
        var cena = SceneManager.GetSceneByPath(path);
        SceneManager.SetActiveScene(cena);

    }

    public void SelectCredits()
    {
        const string path  = "Assets/Scenes/Creditos.unity";
        var sceneLoading = SceneManager.LoadSceneAsync(path);
        var cena = SceneManager.GetSceneByPath(path);
        SceneManager.SetActiveScene(cena);
    }


   
}