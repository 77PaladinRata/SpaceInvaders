using UnityEngine;
using UnityEngine.Events;

public class WinScreen : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onShowWinScreen;
    [SerializeField]
    private TextMesh[] textMeshes;
    [SerializeField]
    private GameObject nextLevelButton;
    [SerializeField]
    private GameObject quitButton;
    [SerializeField]
    private LevelManager levelManager;
    [SerializeField] ///*** Nuevo
    private GameObject[] screenAssets;
    private bool isWinScreenShown = false;
    private void Awake()
    {
        ShowScreenAssets(false);
    }
    public void ShowWinScreen()
    {
        if (isWinScreenShown) return;
        isWinScreenShown = true;
        ShowScreenAssets(true);
        onShowWinScreen ?. Invoke();
        ChangeTextMeshes("You\nWin!");
        levelManager.NextLevel();
        nextLevelButton.SetActive(!levelManager.IsPastLastLevel);
        quitButton.SetActive(true);
    }
    public void ShowLoseScreen()
    {
        if (isWinScreenShown) return;
        isWinScreenShown = true;
        ShowScreenAssets(true);
        onShowWinScreen ?. Invoke();
        ChangeTextMeshes("You\nLose!"); ///***You\nLose!
        nextLevelButton.SetActive(false);
        nextLevelButton.SetActive(true);
        quitButton.SetActive(true);
    }
    private void ChangeTextMeshes(string text)
    {
        foreach (TextMesh textMesh in textMeshes)
        {
            textMesh. text = text;
        }
    } ///***** nuevo entero
    private void ShowScreenAssets(bool show)
    {
        foreach (GameObject asset in screenAssets)
        {
            asset.SetActive(show);
        }
    }
}
