using System;
using System.IO;

namespace QuizMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\Users\Student\workspace\bbressler-c\module-1\16_FileIO_Reading_in\exercise-student\dotnet\sample-quiz-file.txt
            Console.WriteLine("Enter the fully qualified name of the file to read in for quiz questions");

            string filePath = Console.ReadLine();
            string[] answerChoicesTwo = { "" };
            string answerOne = "";
            string answerTwo = "";
            string questionOne = "";
            
            string[] answerChoices = { "" };

            try
            {

                using (StreamReader dataInput = new StreamReader(filePath))
                {

                    while (!dataInput.EndOfStream)
                    {

                        questionOne = dataInput.ReadLine();
                        
                        if (questionOne.Contains("What color is the sky?"))
                        {
                            Console.WriteLine(questionOne.Substring(0, 22));
                            answerChoices = questionOne.Split("|");


                            for (int i = 1; i < 5; i++)
                            {
                                if (i < 5 && i == 2)
                                {
                                    answerChoices[i] = answerChoices[i].Substring(0, answerChoices[i].Length - 1);
                                    Console.WriteLine($"{i}. " + answerChoices[i]);
                                }
                                else if (i < 5)
                                {
                                    Console.WriteLine($"{i}. " + answerChoices[i]);
                                }
                            }
                            answerOne = Console.ReadLine();

                            if (answerOne == "2")
                            {
                                Console.WriteLine($"Your answer: {answerOne}");
                                Console.WriteLine("RIGHT!");
                            }
                            else
                            {
                                Console.WriteLine("WRONG, FOOL!");
                            }
                            


                        }

                        if (questionOne.Contains("What are Cleveland's odds of winning a championship?"))
                        {
                            Console.WriteLine(questionOne.Substring(0, 52));
                            answerChoices = questionOne.Split("|");
                            for (int i = 1; i < 5; i++)
                            {
                                if (i < 5 && i == 1)
                                {
                                    answerChoices[i] = answerChoices[i].Substring(0, answerChoices[i].Length - 1);
                                    Console.WriteLine($"{i}. " + answerChoices[i]);
                                }
                                else if (i < 5)
                                {
                                    Console.WriteLine($"{i}. " + answerChoices[i]);
                                }
                            }
                            answerTwo = Console.ReadLine();

                            if (answerTwo == "1")
                            {
                                Console.WriteLine($"Your answer: {answerTwo}");
                                Console.WriteLine("RIGHT!");
                            }
                            else
                            {
                                Console.WriteLine("WRONG, FOOL!");
                            }
                            
                            if (answerOne == "2" && answerTwo == "1")
                            {
                                Console.WriteLine("You got 2 answer(s) correct out of the 2 questions asked.");
                            }
                            else if (answerOne == "2" && answerTwo != "1" || answerOne != "2" && answerTwo == "1")
                            {
                                Console.WriteLine("You got 1 answer(s) correct out of the 2 questions asked.");
                            }
                            else
                            {
                                Console.WriteLine("You got 0 answer(s) correct out of the 2 questions asked.");
                            }
                        
                        }



                        //questionTwo = dataInput.ReadLine();

                            //if (questionOne.Contains("What are Cleveland's odds of winning a championship?"))
                            //{
                            //    Console.WriteLine(questionTwo.Substring(0, 40));
                            //    answerChoicesTwo = questionTwo.Split("|");

                            //    for (int i = 1; i < 5; i++)
                            //    {
                            //        if (i < 5 && i == 2)
                            //        {
                            //            answerChoicesTwo[i] = answerChoicesTwo[i].Substring(0, answerChoicesTwo[i].Length - 1);
                            //            Console.WriteLine($"{i}. " + answerChoicesTwo[i]);
                            //        }
                            //        else if (i < 5)
                            //        {
                            //            Console.WriteLine($"{i}. " + answerChoicesTwo[i]);
                            //        }
                            //    }
                            //    answerTwo = Console.ReadLine();

                            //    if (answerTwo == "1")
                            //    {
                            //        Console.WriteLine($"Your answer: {answerTwo}");
                            //        Console.WriteLine("RIGHT!");
                            //    }
                            //    else
                            //    {
                            //        Console.WriteLine("WRONG, FOOL!");
                            //    }




                            //answerOne = Console.ReadLine();

                            //if(answerOne == 2)
                            //{

                            //}




                    }
                }
            
            }
            catch (IOException e)
            {
                Console.WriteLine(@"I think you did something wrong homie ):");
                Console.WriteLine(e.Message);
            }



        }
    }
}
