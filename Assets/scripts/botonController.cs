using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class botonController : MonoBehaviour
{
    [SerializeField] GameObject[] buttons;
    [SerializeField] int[] pattern;
    [SerializeField] int patternLength = 3;
    [SerializeField] int currentPattern = 1;
    [SerializeField] int[] playerPattern;
    [SerializeField] float speed = 2.5f;
    [SerializeField] bool IsOk;
    [SerializeField] float time = 3;
    [SerializeField] int i = 0;
    [SerializeField] bool isFinished;
    [SerializeField] int GoodResponse = 0;

    void Start()
    {
        IsOk = true;
        buttons = GameObject.FindGameObjectsWithTag("button");
        foreach (var b in buttons) b.GetComponent<Image>().color = Color.red;
        StartCoroutine(PattersToResolve());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PattersToResolve()
    {
        for (int i = 0; i < 99; i++)
        {
            Execute();
            yield return new WaitUntil(() => isFinished == true);
            isFinished = false;
        }
        yield return new WaitForSeconds(3f);
    }

    void Execute()
    {
        pattern = PatternGenerator();
        StartCoroutine(ChangeColor());
    }

    int[] PatternGenerator()
    {
        pattern = new int[patternLength];
        
        for (int i = 0; i < patternLength; i++)
        {
            pattern[i] = Random.Range(0, buttons.Length);
        }
        currentPattern++;
        return pattern;
    }

    public void GetPlayerResponse(int res)
    {
        if (pattern[i] != res)
        {
            isFinished = true;
            Debug.Log("Error");
            IsOk = false;
        }
        else
        {
            GoodResponse++;
            Debug.Log("bien");
            if (GoodResponse == pattern.Length)
            {
                isFinished = true;
                Debug.Log("Correcto");
                AddDifficulty(currentPattern);
            }
            
        }
        if (isFinished)
        {
            i = 0;
            GoodResponse = 0;
        }
        else
        {
            i++;
        }
    }

    void AddDifficulty(int currentPattern)
    {
        if (speed < .03f)
        {
            speed -= 0.015f;
        }

        if (currentPattern % 3 == 0)
        {
            patternLength++;
        }
    }

    IEnumerator ChangeColor()
    {
        yield return new WaitForSeconds(1.5f);

        for (int i = 0; i < pattern.Length; i++)
        {
            yield return new WaitForSeconds(speed);
            buttons[pattern[i]].GetComponent<Image>().color = Color.yellow;
            yield return new WaitForSeconds(speed);
            buttons[pattern[i]].GetComponent<Image>().color = Color.red;
            yield return new WaitForSeconds(speed);
        }
        yield return null;
    }

    void WaitForResponse(float time)
    {
        time -= 1 * Time.deltaTime; 
    }

}
