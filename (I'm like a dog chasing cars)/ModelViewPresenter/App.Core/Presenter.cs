namespace App.Core
{
    public class Presenter
    {
        private readonly ICalculatorView _View;
        private decimal _Buffer = 0;

        public Presenter(ICalculatorView view)
        {
            this._View = view;
        }

        public void NumberButtonPressed(string numberButtonValue)
        {
            if (_View.ScreenDisplay == "0.")
            { _View.ScreenDisplay = numberButtonValue; }
            else
            { _View.ScreenDisplay += numberButtonValue; }
        }


        private char _CurrentOperation = ' ';

        public void OperatorButtonClicked(string @operator)
        {
            if (_CurrentOperation == ' ')
            {
                _CurrentOperation = @operator.Contains("+") ? '+' : @operator[0];
                _Buffer = decimal.Parse(_View.ScreenDisplay);
                _View.ScreenDisplay = "0.";
            }
            else
            {

                decimal currentValue = decimal.Parse(_View.ScreenDisplay);

                _Buffer = _CurrentOperation switch
                {
                    '+' => (_Buffer + currentValue),
                    '-' => (_Buffer - currentValue),
                    'x' => (_Buffer * currentValue),
                    '/' => (_Buffer / currentValue),
                    _ => 0m
                };

                _View.ScreenDisplay = _Buffer.ToString();
            }
        }
    }
}

