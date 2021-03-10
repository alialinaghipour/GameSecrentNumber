using System;
using System.Collections.Generic;
using System.Text;

namespace Contract.Interface
{
    public interface IO
    {
        void PrintResult(ResultGame result);
        int GetUserAnswer(int answer = 0);
    }
}
