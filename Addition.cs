using System;
namespace MathTutor
{
    public class Addition
    {
       


            private int num1;
            private int num2;
            private int Answer;
            public virtual int GetNum1()//generate num1 and other class can modify it 
            {
                Random rnd = new Random();//declare random object 
                int number1 = rnd.Next(0, 10);//generate a number between 0 and 10
                return number1;
            }

            public virtual int GetNum2()//generate num2 and other class can modift it 
            {
                Random rnd = new Random();//declare random object 
                int number2 = rnd.Next(0, 10);//generate a number between 0 and 10
                return number2;
            }

            public void Setnumbers() //set to priate vaiable in class 
            {
                num1 = GetNum1();
                num2 = GetNum2();

            }
            

        public virtual void Print()//print out the number and other class can modify it 
            {
                if(num1 >= num2)
                {
                Console.WriteLine("  " + num1);//print 
                Console.WriteLine("+ " + num2);//print
                 }
               else
                {
                Console.WriteLine("  " + num2);//print 
                Console.WriteLine("+ " + num1);//print

                }

             }

            public virtual int GetAnswer()//return the correct answer and other class can modify it 
            {
                int answer = num1 + num2;//do the math
                return answer;
            }

            public void SetAnswer()//set the coeect answer to priate variable 
            {
                Answer = GetAnswer();
            }

            public bool truth()//see if user got the answer correctly 
            {
                Console.WriteLine("------"); //ask user to enter the correct number
                int userAnswer = Int32.Parse(Console.ReadLine());
                if (userAnswer == Answer)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

    }
}
