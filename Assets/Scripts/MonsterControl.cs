using UnityEngine;

public class MonsterControl : MonoBehaviour
{
    [SerializeField]
    private GameObject monster;

    [SerializeField]
    private GameObject player;

    GameObject[] monsters;
    float timer = 0;

    private void Update()
    {
        timer += Time.deltaTime;

        if(!Data.isGameOver)
        {
            if((timer > 5f) && (GameObject.FindGameObjectsWithTag("Monster").Length < 5))
            {
                Vector3 posRecommended;
                do
                {
                    posRecommended = new Vector3(Random.Range(100, 400), 50, Random.Range(100, 400));
                } while (Vector3.Distance(posRecommended, player.transform.position) < 100f);
                Instantiate(monster, posRecommended, Quaternion.identity);
                timer = 0;
            }
        }
    }
}