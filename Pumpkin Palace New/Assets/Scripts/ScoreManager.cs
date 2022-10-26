using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text textScore;
    public float score = 0f;

    // Start is called before the first frame update
    void Start()
    {
        textScore.text = score.ToString() + " CANDIES";
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = score.ToString() + " CANDIES";
    }
}
