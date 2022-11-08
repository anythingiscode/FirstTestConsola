using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);
        foreach(int grade in result)
            //Console.WriteLine(Convert.ToString(grade));
            Console.WriteLine(grade);
        Console.ReadKey();

    }
}
class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter. 
     * Redondeo de notas a 0 o 5 en funcion de si la dif entre nota y multiplo es menor que 3 y si  nota es menor que 38, ya que nmotas < 40 /100 son suspensos
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> GradesRound = new List<int>();
        int auxgrade;
        foreach (int grade in grades)
        {
            if (grade < 38) GradesRound.Add(grade);
            else if (grade >= 38)
            {
                if (grade % 5 == 0) GradesRound.Add(grade);
                else if ((grade + 1) % 5 == 0) GradesRound.Add(grade + 1);
                else if ((grade + 2) % 5 == 0) GradesRound.Add(grade + 2);
                else GradesRound.Add(grade);
            }
        }
        return GradesRound;

    }

}