// int currentAssignments = 5;

// int sophia1 = 90;
// int sophia2 = 86;
// int sophia3 = 87;
// int sophia4 = 98;
// int sophia5 = 100;

// int andrew1 = 92;
// int andrew2 = 89;
// int andrew3 = 81;
// int andrew4 = 96;
// int andrew5 = 90;

// int emma1 = 90;
// int emma2 = 85;
// int emma3 = 87;
// int emma4 = 98;
// int emma5 = 68;

// int logan1 = 90;
// int logan2 = 95;
// int logan3 = 87;
// int logan4 = 88;
// int logan5 = 96;

// int sophiaSum = 0;
// int andrewSum = 0;
// int emmaSum = 0;
// int loganSum = 0;

// decimal sophiaScore;
// decimal andrewScore;
// decimal emmaScore;
// decimal loganScore;

// sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
// emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
// loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

// sophiaScore = (decimal)sophiaSum / currentAssignments;
// andrewScore = (decimal)andrewSum / currentAssignments;
// emmaScore = (decimal)emmaSum / currentAssignments;
// loganScore = (decimal)loganSum / currentAssignments;

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();


// int[] sophiaScore = new int[5];


// initialize variables - graded assignments 
// int currentAssignments = 5;

// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// int sophiaSum = 0;
// int andrewSum = 0;
// int emmaSum = 0;
// int loganSum = 0;

// decimal sophiaScore;
// decimal andrewScore;
// decimal emmaScore;
// decimal loganScore;

// sophiaSum = sophiaScores[0] + sophiaScores[1] + sophiaScores[2] + sophiaScores[3] + sophiaScores[4];
// andrewSum = andrewScores[0] + andrewScores[1] + andrewScores[2] + andrewScores[3] + andrewScores[4];
// emmaSum = emmaScores[0] + emmaScores[1] + emmaScores[2] + emmaScores[3] + emmaScores[4];
// loganSum = loganScores[0] + loganScores[1] + loganScores[2] + loganScores[3] + loganScores[4];

// sophiaScore = (decimal)sophiaSum / currentAssignments;
// andrewScore = (decimal)andrewSum / currentAssignments;
// emmaScore = (decimal)emmaSum / currentAssignments;
// loganScore = (decimal)loganSum / currentAssignments;

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");


// string[] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};
// foreach (string name in studentNames) {
//     Console.Write(name + ",");
// };
// Console.Write("\n");

// int currentAssignments = 5;

// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// foreach (string name in studentNames) {
//     if (name == "Sophia") {
//         int sophiaSum = 0;
//         decimal sophiaScore;

//         foreach (int score in sophiaScores) {
//             sophiaSum += score;
//         }

//         sophiaScore = (decimal) sophiaSum / currentAssignments;
//         Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
//         Console.WriteLine($"Sophia: \t{sophiaScore} \tA-");
//     };
// };

// Console.WriteLine("Press enter to continue!");
// Console.ReadLine();
// int[] studentScores = new int[10];
// Console.WriteLine("Student\t\tGrade\tCurrent Student Letter Grade\n");
// foreach (string name in studentNames) {
//     string currentName = name;
//     if (currentName == "Sophia") {
//         studentScores = sophiaScores;
//     }

//     if (currentName == "Andrew") {
//         studentScores = andrewScores;
//     }

//     if (currentName == "Emma") {
//         studentScores = emmaScores;
//     }

//     if (currentName == "Logan") {
//         studentScores = loganScores;
//     }

//     int sumAssignmentScores = 0;
//     decimal currentStudentGrade = 0;
//     string currentStudentLetterGrade = "";

//     foreach (int score in studentScores) {
//         sumAssignmentScores += score;
//     }

//     currentStudentGrade = (decimal) sumAssignmentScores / currentAssignments;
//     if (currentStudentGrade >= 97)
//         currentStudentLetterGrade = "A+";

//     else if (currentStudentGrade >= 93)
//         currentStudentLetterGrade = "A";

//     else if (currentStudentGrade >= 90)
//         currentStudentLetterGrade = "A-";

//     else if (currentStudentGrade >= 87)
//         currentStudentLetterGrade = "B+";

//     else if (currentStudentGrade >= 83)
//         currentStudentLetterGrade = "B";

//     else if (currentStudentGrade >= 80)
//         currentStudentLetterGrade = "B-";

//     else if (currentStudentGrade >= 77)
//         currentStudentLetterGrade = "C+";

//     else if (currentStudentGrade >= 73)
//         currentStudentLetterGrade = "C";

//     else if (currentStudentGrade >= 70)
//         currentStudentLetterGrade = "C-";

//     else if (currentStudentGrade >= 67)
//         currentStudentLetterGrade = "D+";

//     else if (currentStudentGrade >= 63)
//         currentStudentLetterGrade = "D";

//     else if (currentStudentGrade >= 60)
//         currentStudentLetterGrade = "D-";

//     else
//         currentStudentLetterGrade = "F";
//     Console.WriteLine($"{currentName}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
// }


int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };


string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

static string GetStudentLetterGrade(decimal currentStudentGrade)
{
    string currentStudentLetterGrade;

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

    return currentStudentLetterGrade;
}


Console.WriteLine("Student\t\tGrade\tLetter Grade\n");

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

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
    {
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

    string currentStudentLetterGrade = GetStudentLetterGrade(currentStudentGrade);

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}
