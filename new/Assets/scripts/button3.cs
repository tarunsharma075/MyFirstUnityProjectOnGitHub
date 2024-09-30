using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button3 : MonoBehaviour
    {

    public Button button;
    public string changesence;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button.onClick.AddListener(onbuttonclick);   
    }

    private  void onbuttonclick()
    {
     
        SceneManager.LoadScene(changesence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
