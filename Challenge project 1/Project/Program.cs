
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumExamScores = 0;

    int sumExtraCreditScores = 0;
    int extraCreditAssignments = 0;

    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;


    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumExamScores += score;

        else
            sumExtraCreditScores += score;
        if (gradedAssignments > 5)
            extraCreditAssignments++;
    }

    decimal avgExamScores = (decimal)sumExamScores / examAssignments;
    int avgExtraCreditScores = sumExtraCreditScores / extraCreditAssignments;

    decimal overallScores = (decimal) (sumExamScores + ((sumExtraCreditScores * 10) /100)) / examAssignments;

    currentStudentGrade = overallScores;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    decimal extraCreditPoints = (decimal) ((sumExtraCreditScores * 10) /100) / examAssignments;

    Console.WriteLine($"{currentStudent}\t\t{avgExamScores}\t\t{overallScores}\t{currentStudentLetterGrade}\t{avgExtraCreditScores} ({extraCreditPoints} pts)");
    
}
