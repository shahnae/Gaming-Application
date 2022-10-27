using Gaming_Application.Model;
using System.Collections.Generic;

namespace Gaming_Application.Contract
{
    public interface IGuessTestService
    {
        List<InputValue> GetInputs();

       // InputValue GetInputs(int Num);

        string GetDivisibleResult(InputValue input);
    }
}
