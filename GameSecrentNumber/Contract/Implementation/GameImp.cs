using Contract.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Tools.Utility;

namespace Contract.Implementation
{
    public class GameImp : Game
    {
        

        private int _secretNumber;
        public void SetSecretNumber(int min = 1, int max = 100)
        {
            var radnom = new Random();
            _secretNumber = radnom.Next(min, max);
        }
        public ResultGame GetGameResult(int input)
        {
            if (input > _secretNumber)
            {
                return ResultGame.Bigger;
            }
            else if (input < _secretNumber)
            {
                return ResultGame.Smaller;
            }
            else
            {
                return ResultGame.Correct;
            }
        }

    }
}
