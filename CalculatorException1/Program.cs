using System;

namespace ExceptionHandlingCalculator
{/// <summary>
/// To implement an example on exception handling
/// </summary>
    class ExceptionHandlingCalc
    {

        public int Add(int a, int b)
        {
            return a + b;

        }
        /// <summary>

        /// This method performs subtraction operation

        /// </summary>

        /// <param name="a">this is operand 1</param>

        /// <param name="b">this is operand 2</param>

        /// <returns> it returns the difference of two numbers</returns>
        public int Subtract(int a, int b)
        {
            int result = 0;
            try
            {
                if (a < 0)
                {
                    throw (new CustomException("Cannot pass a negative value"));
                }
                result = a - b;
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
        /// <summary>

        /// This method performs multiplication operation

        /// </summary>

        /// <param name="a">this is operand 1</param>

        /// <param name="b">this is operand 2</param>

        /// <returns>it returns the product of two numbers</returns>
        public int Multiply(int a, int b)
        {
            int result = 0;
            try
            {
                if (a == 0 || b == 0)
                {
                    throw (new CustomException("multiplying by zero"));
                }
                result = a * b;
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }
            return result;

        }
        /// <summary>

        /// This method performs division operation

        /// </summary>

        /// <param name="a">this is operand 1</param>

        /// <param name="b">this is operand 2</param>

        /// <returns>it returns the division of two numbers</returns>
        public int Division(int a, int b)
        {
            int result = 0;
            try
            {
                result = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            return result;
        }

        static void Main(string[] args)
        {
            ExceptionHandlingCalc obj = new ExceptionHandlingCalc();
            Console.WriteLine(obj.Subtract(-5, 3));
            Console.WriteLine(obj.Division(9, 0));
            Console.WriteLine(obj.Multiply(0, 2));
        }
    }
    /// <summary>
    /// To implement Custom Exception
    /// </summary>
    public class CustomException : ApplicationException
    {
        public CustomException() : base()
        {
        }
        public CustomException(String message) : base(message)
        {

        }
    }
}