using Contract;
using Contract.Implementation;
using Contract.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools.Utility;

namespace WindFormsUI
{
    public partial class FrmMain : Form
    {

        IO _io;
        Game _game;
        UtilityWinForms _utilityWinForm;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _io = new IOWinForms();
            _game = new GameImp();
            _utilityWinForm = new UtilityWinForms();
            NewRandomNumber();
        }

        public void NewRandomNumber()
        {
            _game.SetSecretNumber();
        }

        private void btnStartApp_Click(object sender, EventArgs e)
        {
            int answer;
            ResultGame result;
            answer = _io.GetUserAnswer(Convert.ToInt32(txtNumber.Value));
            result = _game.GetGameResult(answer);
            _io.PrintResult(result);
            if (result == ResultGame.Correct)
                NewRandomNumber();
        }
    }
}
