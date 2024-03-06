using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Quiz : MonoBehaviour
{
    [Header("Questions")]
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] List<QuestionSO> questions = new List<QuestionSO>();
    QuestionSO currentQuestion;
    int count = 10;

    [Header("Answers")]
    [SerializeField] GameObject[] answerButtons;
    int correctAnswerIndex;
    bool hasAnsweredEarly;
    int index=3;

    [Header("Animator")]
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioSource audioSource;
    [SerializeField] Animator strangeGuy;

    public GameObject panel1;
    public GameObject panel2;

    void Start()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
        GetNextQuestion();
    }

    void Update()
    {
        if (hasAnsweredEarly)
        {
            strangeGuy.SetBool("isAnswered", true);
            StartCoroutine(ResetAnimation());

        }
    }

    IEnumerator ResetAnimation()
    {
        audioSource.PlayOneShot(audioClip);
        hasAnsweredEarly = false;
        GetNextQuestion();
        yield return new WaitForSeconds(5);

        strangeGuy.SetBool("isAnswered", false);
    }

    public void OnAnswerSelected(int buttonIndex)
    {
        count--;
        hasAnsweredEarly = true;

        index = buttonIndex;
    }

    void GetNextQuestion()
    {
        if (questions.Count > 0)
        {
            GetRandomQuestion();
            DisplayQuestion();
        }

        if (count == 0)
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
        }
    }

    void GetRandomQuestion()
    {
        int index = Random.Range(0, questions.Count);
        currentQuestion = questions[index];

        if (questions.Contains(currentQuestion))
        {
            questions.Remove(currentQuestion);
        }
    }

    void DisplayQuestion()
    {
        questionText.text = currentQuestion.GetQuestion();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = currentQuestion.GetAnswer(i);
        }
    }

    public int GetIndex()
    {
        return index;
    }

    public void ChangeIndex(int i)
    {
        index = i;
    }
}
