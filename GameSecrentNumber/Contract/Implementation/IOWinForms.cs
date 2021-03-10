using Contract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools.Utility;

namespace Contract.Implementation
{
    public class IOWinForms : IO
    {
        UtilityWinForms _utility;

        public IOWinForms()
        {
            _utility = new UtilityWinForms();
        }

        public int GetUserAnswer(int answer = 0)
        {
            return answer;
        }

        public void PrintResult(ResultGame result)
        {
            if (result == ResultGame.Correct)
            {
                _utility.ShowMeesage(
                    "You succeeded",
                    "succeeded",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            else if (result == ResultGame.Bigger)
            {
                _utility.ShowMeesage(
                    "Your number is bigger",
                    "more",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (result == ResultGame.Smaller)
            {
                _utility.ShowMeesage(
                    "Your number is small",
                    "less",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
