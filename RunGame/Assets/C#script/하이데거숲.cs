using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 하이데거숲 : MonoBehaviour
{
    int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex; // 보이는 씬을 지정
    }

    public void NextScene()
    {
        SceneManager.LoadScene(sceneIndex + 4); // 다음 씬으로 넘어가기
    } 
}
