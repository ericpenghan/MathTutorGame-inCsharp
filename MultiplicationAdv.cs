using System;
namespace MathTutor
{
    public class MultiplicationAdv:Multiplication//inhert everything and modify on top of it 
    {
        public override int GetNum1()//generate num1 and other class can modify it 
        {
            Random rnd = new Random();//declare random object 
            int number1 = rnd.Next(0, 100);//generate a number between 0 and 100
            return number1;
        }

        public override int GetNum2()//generate num2 and other class can modift it 
        {
            Random rnd = new Random();//declare random object 
            int number2 = rnd.Next(0, 100);//generate a number between 0 and 10
            return number2;
        }



    }
}
