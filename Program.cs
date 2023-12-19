using System; 

//Practice 1 ------------------------------------------------------------------------------------------------------------------------------------



//Practice 2 ------------------------------------------------------------------------------------------------------------------------------------

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// // Your code goes here:

// if (daysUntilExpiration > 5 && daysUntilExpiration <= 10)
// {
    
//     Console.WriteLine("Your subscription will expire soon. Renew now!");   
// }
// else if (daysUntilExpiration > 1 && daysUntilExpiration <= 5)
// {
//     discountPercentage = 10;
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
// }
// else if (daysUntilExpiration == 1)
// {
//     discountPercentage = 20;
//     Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
// }
// else
// {
//     Console.WriteLine("Your subscription has expired.");
// }


// Practice 3 ------------------------------------------------------------------------------------------------------------------------------------

// string firstName = "Bob";
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");git 


/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

// Random random = new Random();
// string[] orderIDs = new string[5];
// // Loop through each blank orderID
// for (int i = 0; i < orderIDs.Length; i++)
// {
//     // Get a random value that equates to ASCII letters A through E
//     int prefixValue = random.Next(65, 70);
//     // Convert the random value into a char, then a string
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     // Create a random number, pad with zeroes
//     string suffix = random.Next(1, 1000).ToString("000");
//     // Combine the prefix and suffix together, then assign to current OrderID
//     orderIDs[i] = prefix + suffix;
// }
// // Print out each orderID
// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

// // Example 1:
// Console
// .
// WriteLine
// (
// "Hello Example 1!"
// )
// ;

// // Example 2:
// string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");


//Ejemplo de uso de espacios en blanco correctamente para legibilidad del codigo.

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
// {
//     if ((roll1 == roll2) && (roll2 == roll3)) 
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6; 
//     } 
//     else 
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }


//Reto 

/*
En este desafío, usará las técnicas que ha aprendido en este módulo para mejorar la legibilidad de un ejemplo
 de código. Se le proporciona un ejemplo de código con un estilo deficiente y comentado.
  El objetivo es actualizar el código mediante directrices de estilo para nombres de variables, 
comentarios de código y espacios en blanco para mejorar la legibilidad del código.
*/

//Strint to convert
// string originalMessage = "The quick brown fox jumps over the lazy dog.";

// // convert the message into a char array
// char[] charMessage = originalMessage.ToCharArray();

// Reverse the chars
// Array.Reverse(charMessage);
// int letterCount = 0;

// // count the o's
// foreach (char letter in charMessage) 
// {
//     if (letter == 'o') 
//     {
//         letterCount++;     
//     } 
// }

// // convert it back to a string
// string newMessage = new String(charMessage);

// // print it out
// Console.WriteLine($"{newMessage}\n 'o' appears {letterCount} times.");


//Proyecti guiado ----------

/* Crear una app que haga lo siguiente:
Imprimir nombre de alumno
Imprimir cada nota de examen en un valor entero
Imprimir calificacion global de examen en promedio 
Criterios para las tareas de créditos adicionales:
Incluya notas de tareas de créditos adicionales en la matriz de notas del alumno.
Las asignaciones de créditos adicionales valen el 10 % de una nota de examen (al calcular la nota numérica final).
Agregaremos las notas de las tareas de créditos adicionales a la nota total del examen del alumno antes de calcular la calificación numérica final.
La aplicación debe asignar automáticamente calificaciones con letras en función de la nota final calculada para cada alumno.
La aplicación debe generar o mostrar el nombre de cada alumno y la nota con formato.
La aplicación debe admitir la incorporación de otros alumnos y de otras notas sin que ello afecte al código en gran medida.
*/

/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/


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
Console.WriteLine("Student\t\tGrade\n");

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

    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;
        else
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

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

    // Student         Grade
    // Sophia:         92.2    A-
    
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();



