using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text curScore;
    public Text totalScore;
    public int score=0;

    public static UIManager inst;

    private void Awake()
    {
        inst = this;
    }

    public void AddScore(bool isCenter)
    {
        int sco=(isCenter) ? 25 : 10;
        score += sco;
        curScore.text = sco.ToString();
        curScore.color=isCenter?Color.red:Color.white;
        
        totalScore.text = score.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
