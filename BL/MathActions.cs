using System.Collections.Generic;

namespace BL
{
    public enum Actions { Minus, Plus, Divide, Multiply, Noaction };

    public class MathActions
    {
        public double? NumberA { get; set; }
        public double? NumberB { get; set; }
        public List<string> HistoryShow { get; set; } = new List<string>();
        public Actions Action { get; set; } = Actions.Noaction;

        public void Equal()
        {
            switch (Action)
            {
                case Actions.Minus:
                    NumberA -= NumberB;
                    break;
                case Actions.Plus:
                    NumberA += NumberB;
                    break;
                case Actions.Divide:
                    NumberA /= NumberB;
                    break;
                case Actions.Multiply:
                    NumberA *= NumberB;
                    break;
                case Actions.Noaction:
                    NumberA = NumberA;
                    break;
                default:
                    NumberA = null;
                    break;
            }
            Action = Actions.Noaction;
            NumberB = null;
        }

        public string UpdateHistoryLog()
        {
            var log = string.Empty;
            foreach (var item in HistoryShow)
                log += item;
            return log;
        }

    }
}
