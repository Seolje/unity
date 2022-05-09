using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private Text score;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        this.score = GameObject.Find("Score").GetComponent<Text>();  //Score라는 오브젝트 찾아서 가져온다
        count = 0;  //count 값을 0으로 초기화해줌
        
    }

    public void IncScore()  //IncScore함수 외부에서 가져오기 위해 public으로 선언함
    {
        count += 1;
        this.score.text = "Score : " + count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
