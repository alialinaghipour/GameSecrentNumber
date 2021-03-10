using Contract;
using Contract.Implementation;
using Contract.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class RunApp
    {
        IO _io;
        Game _game;

        public RunApp()
        {
            _io = new IOConsole();
            _game = new GameImp();
        }

        public void NewRandomNumber()
        {
            _game.SetSecretNumber();
        }

        public void Run()
        {
            int answer;
            ResultGame result;
            while(true)
            {
                answer = _io.GetUserAnswer();
                result = _game.GetGameResult(answer);
                _io.PrintResult(result);

                if (result == ResultGame.Correct)
                    NewRandomNumber();
            }
        }
    }
}
