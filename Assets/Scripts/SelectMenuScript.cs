using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMenuScript : MonoBehaviour
{
    [SerializeField] private string anteriorScreen;

    private const string Inicio = "Assets/Scenes/Inicio.unity";

    private const string HistoriasLobby = "Assets/Scenes/Historias/Historias.unity";
    private const string AgentesHistoria = "Assets/Scenes/Historias/Cenas/AgentesCausadoresHistoria.unity";
    private const string QueimaduraHistoria = "Assets/Scenes/Historias/Cenas/GrausQueimaduraHistoria.unity";
    private const string PrevençoesHistoria = "Assets/Scenes/Historias/Cenas/PrevençoesHistoria.unity";
    private const string PrimeirosHistoria = "Assets/Scenes/Historias/Cenas/PrimeirosSocorrosHistoria.unity";

    private const string QuizLobby = "Assets/Scenes/Quiz/Quiz.unity";

    
    private const string Creditos = "Assets/Scenes/Creditos.unity";

    private const string Devs = "Assets/Scenes/Devs.unity";

    private const string References = "Assets/Scenes/referencias.unity";

    private const string Ensino = "Assets/Scenes/Ensino.unity";


    private void ChangeScreen(string path)
    {
        var sceneLoading = SceneManager.LoadSceneAsync(path);
        var cena = SceneManager.GetSceneByPath(path);
        sceneLoading.completed += operation => SceneManager.SetActiveScene(cena);
    }

    public void ReturnAnteriorScreen()
    {
        var sceneLoading = SceneManager.LoadSceneAsync(anteriorScreen);
        var cena = SceneManager.GetSceneByPath(anteriorScreen);
        sceneLoading.completed += operation => SceneManager.SetActiveScene(cena);
    }

    public void SelectMenu()
    {
        anteriorScreen = Inicio;
        ChangeScreen(Inicio);
    }

    public void SelectHistories()
    {
        anteriorScreen = Inicio;
        ChangeScreen(HistoriasLobby);
    }

    public void HistoriaAgentes()
    {
        anteriorScreen = HistoriasLobby;
        ChangeScreen(AgentesHistoria);
    }

    public void HistoriaGraus()
    {
        anteriorScreen = HistoriasLobby;
        ChangeScreen(QueimaduraHistoria);
    }

    public void HistoriaPrevencoes()
    {
        anteriorScreen = HistoriasLobby;
        ChangeScreen(PrevençoesHistoria);
    }

    public void HistoriaPrimeiros()
    {
        anteriorScreen = HistoriasLobby;
        ChangeScreen(PrimeirosHistoria);
    }

    public void SelectQuiz()
    {
        anteriorScreen = Inicio;
        ChangeScreen(QuizLobby);
    }

    public void QuizAgentes()
    {
        anteriorScreen = QuizLobby;
        ChangeScreen(AgentesHistoria);
    }

    public void QuizGraus()
    {
        anteriorScreen = QuizLobby;
        ChangeScreen(QueimaduraHistoria);
    }

    public void QuizPrevencoes()
    {
        anteriorScreen = QuizLobby;
        ChangeScreen(PrevençoesHistoria);
    }

    public void QuizPrimeiros()
    {
        anteriorScreen = QuizLobby;
        ChangeScreen(PrimeirosHistoria);
    }
    
    public void SelectCredits()
    {
        anteriorScreen = Inicio;
        ChangeScreen(Creditos);
    }

    public void SelectDevs()
    {
        anteriorScreen = Creditos;
        ChangeScreen(Devs);
    }

    public void SelectReferences()
    {
        anteriorScreen = Creditos;
        ChangeScreen(References);
    }

    public void SelectEnsino()
    {
        anteriorScreen = Creditos;
        ChangeScreen(Ensino);
    }
}