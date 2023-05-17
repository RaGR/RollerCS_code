using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{   
    public GameObject Player;
    private Vector3 pos_initial;
    private int score = 0;
    private float coeffient = 1f;
    public Text score_Text;
    // Start is called before the first frame update
    void Start()
    {
        pos_initial = Player.transform.position;
        score_Text.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (score < Mathf.Abs(Player.transform.position.z - pos_initial.z)){
            score = (int)(Mathf.Abs(Player.transform.position.z - pos_initial.z) * coeffient);
        }
        score_Text.text = score.ToString();
    }
}
