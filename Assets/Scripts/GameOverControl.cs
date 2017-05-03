using UnityEngine;
using UnityEngine.UI;

public class GameOverControl : MonoBehaviour
{
    public Text txtScore;
    public Text txtGameOver;
    public Text txtLastScore;
    public Text labelScore;
    public Button btnRestart;
    bool enable = false;

    public Image btnControl;
    public Image btnFire;

    // toggle untuk UI Text
    void SetVisible(bool visible)
    {
        txtGameOver.enabled = visible;
        txtLastScore.enabled = visible;
        labelScore.enabled = visible;
        btnRestart.gameObject.SetActive(visible);

        txtScore.enabled = !visible;
        btnControl.enabled = !visible;
        btnFire.enabled = !visible;

        enable = false;
    }

    private void Start()
    {
        SetVisible(false);
    }

    private void Update()
    {
        if(Data.isGameOver && !enable)
        {
            txtLastScore.text = Data.Score.ToString();
            SetVisible(true);
            enable = true;
        }
    }

    public void Restart()
    {
        Data.isGameOver = false;
        Data.Score = 0;
        Application.LoadLevel(0);
    }
}