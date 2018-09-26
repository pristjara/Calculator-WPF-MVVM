using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModularCalculator.Model;
using System.ComponentModel;

namespace ModularCalculator.ViewModel
{
    class CalculatorViewModel : INotifyPropertyChanged
    {
        CalculatorModel calcModel;

        double secondNumber;

        // what action user selects +, -, *, / 
        enum Action
        {
            None,
            Plus, 
            Minus,
            Multiply,
            Divide
        }

        Action lastAction;

        bool secondTime; // determines if the func is called first or second time

        public CalculatorViewModel()
        {
            // initize
            calcModel = new CalculatorModel();
            secondNumber = 0;
            lastAction = Action.None;
            secondTime = false;
        }

        public double screenNumber
        {
            get { return calcModel.Number; }
            set
            {  
                // if 0 --> set number
                if (calcModel.Number == 0)
                {
                    calcModel.Number = value;
                }
                // if new val --> set number
                else if (secondTime)
                {
                    calcModel.Number = value;
                    secondTime = false;
                }
                // if not new val --> add to the current number like 1 --> 11
                else
                {
                    calcModel.Number = double.Parse(calcModel.Number.ToString() + value.ToString());
                }

                // update
                RaisePropertyChanged("screenNumber");
            }
        } // screen number

        public void ClearVars()
        {
            calcModel.Number = 0;
            screenNumber = 0;
        }

        public void ClearAll()
        {
            calcModel.Number = 0;
            screenNumber = 0;
            secondNumber = 0;
            secondTime = false;
            lastAction = Action.None;
        }

        public void Plus()
        {
            if (lastAction == Action.Plus) // if this is second time the func called --> do maths
            {
                double result = calcModel.Plus(screenNumber, secondNumber);
                ClearVars();
                screenNumber = result;
            }
            // First call --> lastAction == None 
            // set secondNumber to current screen val and prepare to set second number
            secondNumber = screenNumber;
            secondTime = true;

            // next time --> do maths
            lastAction = Action.Plus;
        } // func summ

        public void Minus()
        {
            if (lastAction == Action.Minus) // if this is second time the func called --> do maths
            {
                double result = calcModel.Minus(screenNumber, secondNumber);
                ClearVars();
                screenNumber = result;
            }
            // First call --> lastAction == None 
            // set secondNumber to current screen val and prepare to set second number
            secondNumber = screenNumber;
            secondTime = true;

            // next time --> do maths
            lastAction = Action.Minus;
        } // func substract

        public void Divide()
        {
            if (lastAction == Action.Divide) // if this is second time the func called --> do maths
            {
                double result = calcModel.Divide(screenNumber, secondNumber);
                ClearVars();
                screenNumber = result;
            }
            // First call --> lastAction == None 
            // set secondNumber to current screen val and prepare to set second number
            secondNumber = screenNumber;
            secondTime = true;

            // next time --> do maths
            lastAction = Action.Divide;
        } // func divide


        public void Multiply()
        {
            if (lastAction == Action.Multiply) // if this is second time the func called --> do maths
            {
                double result = calcModel.Multiply(screenNumber, secondNumber);
                ClearVars();
                screenNumber = result;
            }
            // First call --> lastAction == None 
            // set secondNumber to current screen val and prepare to set second number
            secondNumber = screenNumber;
            secondTime = true;

            // next time --> do maths
            lastAction = Action.Multiply;
        } // func multiply

        public void Calculate()
        {
            switch (lastAction)
            {
                case Action.Plus:
                    Plus();
                    break;
                case Action.Minus:
                    Minus();
                    break;
                case Action.Multiply:
                    Multiply();
                    break;
                case Action.Divide:
                    Divide();
                    break;
                default:
                    break;
            }

            lastAction = Action.None;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    } // class
}
