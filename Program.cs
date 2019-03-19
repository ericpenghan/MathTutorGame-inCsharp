using System;

//author:Eric Han
//name: Math Help(personal project)
//language:c#

namespace MathTutor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
         
            //int sum = 0;
            //int answer;


            int Option;
            printMenu();//call print menu
            do
            {

                Option = Choices();//set opetion equal to whatever user entered
                switch (Option)
                {//go into whatever pratice depends on what user entered
                    case 1:
                        Add();//call addition tutorial
                        break;
                    case 2:
                        Sub();//call subtraction tutorial
                        break;
                    case 3:
                        Mul();//call mutiplication tutorial
                        break;
                    case 4:
                       Div();//call Division tutorial
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using Math Help Program.");
                        break;
                }
                if (Option != 5)
                {
                    printMenu();//call print menu
                }
            } while (Option == 1 || Option == 2 || Option == 3 || Option == 4);

            
            //multiplication


        }
        static void printMenu()
        {//print menu
            Console.WriteLine("Math Is Fun! Complete all tutorial to get great knowledge");
            Console.WriteLine ("---------------------------------");
            Console.WriteLine("1. Addition Tutorial");
            Console.WriteLine("2. Subtraction Tutorial");
            Console.WriteLine("3. Multiplication Tutorial");
            Console.WriteLine("4. Division Tutorial");
            Console.WriteLine("5. Quit this Tutorial");
            Console.WriteLine( "---------------------------------");
        }

        static int Choices()
        {//return the final choice
           
            Console.WriteLine("Enter your choice (1-5): ");
            int choice = Int32.Parse(Console.ReadLine()); 
            while (choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5)
            {//testing until user entered the inrange choice
                Console.WriteLine("The valid choices are 1, 2, 3, 4, and 5. Please choose: ");
                choice = Int32.Parse(Console.ReadLine()); ;
            }
            return choice;
        }
        //addtion
        static void Add()//call two classes for addition tuturial
        {
            int sum = 0;
            int answer;
            //Addition
            Addition a = new Addition();//declare object 
            while (sum < 80)//keep running the loop until the user got at least 80 
            {
                Console.WriteLine("Here is 5 problems, each correct answer worth 20 points, Score at least 80 to advanced to the next level!");
                for (int i = 0; i < 5; i++)
                {
                    a.GetNum1();//generate num1
                    a.GetNum2();//generate num2 
                    a.Setnumbers();//set the number
                    a.Print();//print it out 
                    a.GetAnswer();//get the answer 
                    a.SetAnswer();//set to private vairable
                    if (a.truth())//ask the user to enter the answer and see if it's true 
                    {
                        sum = sum + 20;
                        Console.WriteLine("Great job! You scores is " + sum);
                    }
                    else
                    {
                        answer = a.GetAnswer();
                        Console.WriteLine("Sorry, the correct answer is " + answer);//shows the correct answer
                    }

                }
                if( sum < 80) 
                {
                    Console.WriteLine("So close, you almost there! I'm sure you will get it next time. Please try it one more time!");
                    sum = 0; //reset the score
                }
            }
            Console.WriteLine("Congratuations you have advanced to complicated level addition! Keep up the great work!");

            sum = 0; //reset the score to continue 
            //advanced addition 
            AdditionAdv ap = new AdditionAdv();//declare object 
            while (sum < 80)//keep running the loop until the user got at least 80 
            {
                Console.WriteLine("Here is 5 problems, each correct answer worth 20 points, Score at least 80 to advanced to the next level!");
                for (int i = 0; i < 5; i++)
                {
                    ap.GetNum1();//generate num1
                    ap.GetNum2();//generate num2 
                    ap.Setnumbers();//set the number
                    ap.Print();//print it out 
                    ap.GetAnswer();//get the answer 
                    ap.SetAnswer();//set to private vairable
                    if (ap.truth())//ask the user to enter the answer and see if it's true 
                    {
                        sum = sum + 20;
                        Console.WriteLine("Great job! You scores is " + sum);
                    }
                    else
                    {
                        answer = ap.GetAnswer();
                        Console.WriteLine("Sorry, the correct answer is " + answer);//shows the correct answer
                    }

                }
                if( sum < 80) 
                {
                    Console.WriteLine("So close, you almost there! I'm sure you will get it next time. Please try it one more time!");
                    sum = 0;//reset the socre
                }
            }
            Console.WriteLine("Congratuations you have complited all the adding tutorials! Keep up the great work!");


        }
        //subtraction
        static void Sub() {//called two class for subtraction tutrial
            int sum = 0;
            int answer;
            //subtraction
            Subtraction s = new Subtraction();//declare object 
            while (sum < 80)//keep running the loop until the user got at least 80 
            {
                Console.WriteLine("Here is 5 problems, each correct answer worth 20 points, Score at least 80 to advanced to the next level!");
                for (int i = 0; i < 5; i++)
                {
                    s.GetNum1();//generate num1
                    s.GetNum2();//generate num2 
                    s.Setnumbers();//set the number
                    s.Print();//print it out 
                    s.GetAnswer();//get the answer 
                    s.SetAnswer();//set to private vairable
                    if (s.truth())//ask the user to enter the answer and see if it's true 
                    {
                        sum = sum + 20;
                        Console.WriteLine("Great job! You scores is " + sum);
                    }
                    else
                    {
                        answer = s.GetAnswer();
                        Console.WriteLine("Sorry, the correct answer is " + answer);//shows the correct answer
                    }

                }
                if( sum < 80) 
                {
                    Console.WriteLine("So close, you almost there! I'm sure you will get it next time. Please try it one more time!");
                    sum = 0;//reset the score 
                }
            }
            Console.WriteLine("Congratuations you have advanced to advanced subtraction! Keep up the great work!");
            sum = 0;//reset the score to continue 

           // advaced subtraction
            SubtractionAdv sp = new SubtractionAdv();//declare object 
            while (sum < 80)//keep running the loop until the user got at least 80 
            {
                Console.WriteLine("Here is 5 problems, each correct answer worth 20 points, Score at least 80 to advanced to the next level!");
                for (int i = 0; i < 5; i++)
                {
                    sp.GetNum1();//generate num1
                    sp.GetNum2();//generate num2 
                    sp.Setnumbers();//set the number
                    sp.Print();//print it out 
                    sp.GetAnswer();//get the answer 
                    sp.SetAnswer();//set to private vairable
                    if (sp.truth())//ask the user to enter the answer and see if it's true 
                    {
                        sum = sum + 20;
                        Console.WriteLine("Great job! You scores is " + sum);
                    }
                    else
                    {
                        answer = sp.GetAnswer();
                        Console.WriteLine("Sorry, the correct answer is " + answer);//shows the correct answer
                    }

                }
                if( sum < 80) 
                {
                    Console.WriteLine("So close, you almost there! I'm sure you will get it next time. Please try it one more time!");
                    sum = 0;//reset the score 
                }
            }
            Console.WriteLine("Congratuations you have comlicated all the tutial of Subtraction! Keep up the great work!");

        }
        //mutipication
        static void Mul() 
        {
            int sum = 0;
            int answer;
            //mutipication
            Multiplication m = new Multiplication();//declare object 
            while (sum < 80)//keep running the loop until the user got at least 80 
            {
                Console.WriteLine("Here is 5 problems, each correct answer worth 20 points, Score at least 80 to advanced to the next level!");
                for (int i = 0; i < 5; i++)
                {
                    m.GetNum1();//generate num1
                    m.GetNum2();//generate num2 
                    m.Setnumbers();//set the number
                    m.Print();//print it out 
                    m.GetAnswer();//get the answer 
                    m.SetAnswer();//set to private vairable
                    if (m.truth())//ask the user to enter the answer and see if it's true 
                    {
                        sum = sum + 20;
                        Console.WriteLine("Great job! You scores is " + sum);
                    }
                    else
                    {
                        answer = m.GetAnswer();
                        Console.WriteLine("Sorry, the correct answer is " + answer);//shows the correct answer
                    }

                }
                if (sum < 80)
                {
                    Console.WriteLine("So close, you almost there! I'm sure you will get it next time. Please try it one more time!");
                    sum = 0;//reset the score 
                }
            }
            Console.WriteLine("Congratuations you have advanced to advanced subtraction! Keep up the great work!");
            sum = 0;//reset the score to continue 

            MultiplicationAdv mp = new MultiplicationAdv();//declare object 
            while (sum < 80)//keep running the loop until the user got at least 80 
            {
                Console.WriteLine("Here is 5 problems, each correct answer worth 20 points, Score at least 80 to advanced to the next level!");
                for (int i = 0; i < 5; i++)
                {
                    mp.GetNum1();//generate num1
                    mp.GetNum2();//generate num2 
                    mp.Setnumbers();//set the number
                    mp.Print();//print it out 
                    mp.GetAnswer();//get the answer 
                    mp.SetAnswer();//set to private vairable
                    if (mp.truth())//ask the user to enter the answer and see if it's true 
                    {
                        sum = sum + 20;
                        Console.WriteLine("Great job! You scores is " + sum);
                    }
                    else
                    {
                        answer = mp.GetAnswer();
                        Console.WriteLine("Sorry, the correct answer is " + answer);//shows the correct answer
                    }

                }
                if (sum < 80)
                {
                    Console.WriteLine("So close, you almost there! I'm sure you will get it next time. Please try it one more time!");
                    sum = 0;//reset the socre
                }
            }
            Console.WriteLine("Congratuations you have complited all the Multipication tutorials! Keep up the great work!");


        }
        //divition
        static void Div() //call two classes 
        {
            int sum = 0;
            int answer;
           //division
            Division d = new Division();//declare object 
            while (sum < 80)//keep running the loop until the user got at least 80 
            {
                Console.WriteLine("Here is 5 problems, each correct answer worth 20 points, Score at least 80 to advanced to the next level!");
                for (int i = 0; i < 5; i++)
                {
                    d.GetNum1();//generate num1
                    d.Setnumbers1();//set the number 1
                    d.GetNum2();//generate num2 
                    d.Setnumbers2();//set the number 1
                    d.Print();//print it out 
                    d.GetAnswer();//get the answer 
                    d.SetAnswer();//set to private vairable
                    if (d.truth())//ask the user to enter the answer and see if it's true 
                    {
                        sum = sum + 20;
                        Console.WriteLine("Great job! You scores is " + sum);
                    }
                    else
                    {
                        answer = d.GetAnswer();
                        Console.WriteLine("Sorry, the correct answer is " + answer);//shows the correct answer
                    }

                }
                if (sum < 80)
                {
                    Console.WriteLine("So close, you almost there! I'm sure you will get it next time. Please try it one more time!");
                    sum = 0;//reset the score 
                }
            }
            Console.WriteLine("Congratuations you have advanced to advanced subtraction! Keep up the great work!");
            sum = 0;//reset the score to continue 

            //advanced division
            DivisionAdv dp = new DivisionAdv();//declare object 
            while (sum < 80)//keep running the loop until the user got at least 80 
            {
                Console.WriteLine("Here is 5 problems, each correct answer worth 20 points, Score at least 80 to advanced to the next level!");
                for (int i = 0; i < 5; i++)
                {
                    dp.GetNum1();//generate num1
                    dp.Setnumbers1();//set the number 1
                    dp.GetNum2();//generate num2 
                    dp.Setnumbers2();//set the number 1
                    dp.Print();//print it out 
                    dp.GetAnswer();//get the answer 
                    dp.SetAnswer();//set to private vairable
                    if (dp.truth())//ask the user to enter the answer and see if it's true 
                    {
                        sum = sum + 20;
                        Console.WriteLine("Great job! You scores is " + sum);
                    }
                    else
                    {
                        answer = dp.GetAnswer();
                        Console.WriteLine("Sorry, the correct answer is " + answer);//shows the correct answer
                    }

                }
                if (sum < 80)
                {
                    Console.WriteLine("So close, you almost there! I'm sure you will get it next time. Please try it one more time!");
                    sum = 0;//reset the score 
                }
            }
            Console.WriteLine("Congratuations you have advanced to advanced subtraction! Keep up the great work!");

        }

    }
}