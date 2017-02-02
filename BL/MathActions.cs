using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public enum ACTIONS { MINUS, PLUS, DIVIDE, MULTIPLY, NOACTION };

    public class MathActions
    {
        public double? NumberA { get; set; }
        public double? NumberB { get; set; }
        public List<string> HistoryShow { get; set; }
        public ACTIONS Action { get; set; }

        public MathActions()
        {
            HistoryShow = new List<string>();
            Action = ACTIONS.NOACTION;
        }

        public void Equal()
        {
            //double? value;
            switch (Action)
            {
                case ACTIONS.MINUS:
                    NumberA -= NumberB;
                    break;
                case ACTIONS.PLUS:
                    NumberA += NumberB;
                    break;
                case ACTIONS.DIVIDE:
                    NumberA /= NumberB;
                    break;
                case ACTIONS.MULTIPLY:
                    NumberA *= NumberB;
                    break;
                case ACTIONS.NOACTION:
                    NumberA = NumberA;
                    break;
                default:
                    NumberA = null;
                    break;
            }
            Action = ACTIONS.NOACTION;
            NumberB = null;
        }

        public string UpdateHistoryLog()
        {
            string log = string.Empty;
            foreach (var item in HistoryShow)
            {
                log += item;
            }
            return log;
        }

    }
}
