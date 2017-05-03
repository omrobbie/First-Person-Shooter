using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text txtScore;

    private void FixedUpdate()
    {
        txtScore.text = Data.Score.ToString();
    }
}