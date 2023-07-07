using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMenuScript : MonoBehaviour
{
    //Segue-se o padrão de cenas no index baseado na ordem dos menus 
    //0 é o menu inicial
    //1 = Historias
    //2 = Quiz
    //3 = Créditos
    public void SelectMenu()
    {
        const int sceneIndex = 0;
        var sceneLoading = SceneManager.LoadSceneAsync(sceneIndex);
        sceneLoading.allowSceneActivation = true;
    }

    public void SelectHistories()
    {
        const int sceneIndex = 1;
        var sceneLoading = SceneManager.LoadSceneAsync(sceneIndex);
        sceneLoading.allowSceneActivation = true;
    }

    public void SelectQuiz()
    {
        const int sceneIndex = 2;
        var sceneLoading = SceneManager.LoadSceneAsync(sceneIndex);
        sceneLoading.allowSceneActivation = true;
    }

    public void SelectCredits()
    {
        const int sceneIndex = 3;
        var sceneLoading = SceneManager.LoadSceneAsync(sceneIndex);
        sceneLoading.allowSceneActivation = true;
    }


   
}