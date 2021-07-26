using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex; // 보이는 씬을 지정
    }

    public void NextScene()
    {
        SceneManager.LoadScene(sceneIndex + 1); // 다음 씬으로 넘어가기
    }

    public void NNextScene()
    {
        SceneManager.LoadScene(sceneIndex + 2); // 다다음 씬으로 넘어가기
    }

    public void NNNextScene()
    {
        SceneManager.LoadScene(sceneIndex + 3); // 다다다음 씬으로 넘어가기
    }

    public void NNNNextScene()
    {
        SceneManager.LoadScene(sceneIndex + 4); // 다다다다음 씬으로 넘어가기
    }

    public void NNNNNextScene()
    {
        SceneManager.LoadScene(sceneIndex + 5); // 다다다다다음 씬으로 넘어가기
    }
    public void NNNNNNextScene()
    {
        SceneManager.LoadScene(sceneIndex + 6); // 다다다다다음 씬으로 넘어가기
    }
    public void NowScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void RunconnectScene()
    {
        SceneManager.LoadScene(sceneIndex - 6);
    }


}
