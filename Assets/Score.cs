using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //ì_êî
    private int score = 0;
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //è’ìÀéûÇ…åƒÇŒÇÍÇÈä÷êî
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Hit: "+ other.gameObject.tag );

        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
        }
        if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 20;
        }
        if (other.gameObject.tag == "LargeStarTag")
        {
            score += 15;
        }
        if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 25;
        }
        this.scoreText.GetComponent<Text>().text = "Score "+ score;

    }
}
