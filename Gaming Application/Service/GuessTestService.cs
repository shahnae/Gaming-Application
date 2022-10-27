using Gaming_Application.Contract;
using Gaming_Application.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Gaming_Application.Service
{
    public class GuessTestService : IGuessTestService
    {

        private List<InputValue> inputs = new List<InputValue>()
            {
                new InputValue()
                { 
                    Num=25, GuessValue="hello"
                }
            };
        public List<InputValue> GetInputs()
        {
            return inputs;
            //return inputs.Single(x => x.Num == Num);
        }

        public string GetDivisibleResult(InputValue input)
        {
            var res = input.Num;
            string guess = input.GuessValue;
            if(res % 3 == 0 && res % 5 == 0)
            {

                return "FooBar";
            }
            else if(res % 3 == 0)
            {
                return "Foo";
            }
            else if(res % 5 ==0)
            {
                return "Bar";
            }
            else
            {
                return "None";
            }

            int test= (guess == "FooBar") ? 200 : (guess == "Foo") ? 200 : (guess == "Bar") ? 200 : (guess == "None") ? 200 : 404;
            if(test == 200)
            {
                return "Match found";
            }
            else
            {
                return "Error";
            }
        }

         string GetDivisibleResult(InputValue input, string guess)
         {
            var res = input.Num;
            guess = input.GuessValue;
            if (res % 3 == 0 && res % 5 == 0)
            {

                return "FooBar";
            }
            else if (res % 3 == 0)
            {
                return "Foo";
            }
            else if (res % 5 == 0)
            {
                return "Bar";
            }
            else
            {
                return "None";
            }

            int test = (guess == "FooBar") ? 200 : (guess == "Foo") ? 200 : (guess == "Bar") ? 200 : (guess == "None") ? 200 : 404;
            if (test == 200)
            {
                return "Match found";
            }
            else
            {
                return "Error";
            }
        }
    }
}
