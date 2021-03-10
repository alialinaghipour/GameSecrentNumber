using System;
using System.Collections.Generic;
using System.Text;

namespace Contract.Interface
{
    public interface Game
    {
         void SetSecretNumber(int min = 1, int max = 100);
         ResultGame GetGameResult(int input);
    }
}
