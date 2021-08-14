using UnityEngine;

public class IndexerExample : MonoBehaviour
{
    /*
     * 
     *  - 인덱서의 구조
     *  접근_제한자 반환_타입 this[int index]{
     *      get {}
     *      set {}
     *  }
     */  
    


    private void Start()
    {
        Grade grades = new Grade();
        //int[] grades = gr.grades;


        grades[0] = 20;
        for (int i= 0; i< grades.grades.Length; i++)
        {
            Debug.Log(grades[i]);
        }
    }
}

class Grade
{
    public int[] grades = { 10, 50, 90, 70, 30 };

    public int this[int index]
    {
        get
        {
            return grades[index];
        }
        set
        {
            grades[index] = value;
        }
       
    }

}