using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    public class Model
    {
        public enum Operations
        {
            Add,
            Sub,
            Mul,
            Div
        }

        public double ExecuteOperation(double operand1, double operand2, Operations operation)
        {
            return operation switch
            {
                Operations.Add => Add(operand1, operand2),
                Operations.Sub => Sub(operand1, operand2),
                Operations.Mul => Mul(operand1, operand2),
                Operations.Div => Div(operand1, operand2),
                _ => throw new InvalidOperationException(),
            };
        }

        private double Add(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
        private double Sub(double operand1, double operand2)
        {
            return operand1 - operand2;
        }
        private double Mul(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
        private double Div(double operand1, double operand2)
        {
            return operand1 / operand2;
        }
    }
}
