using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class CalculationHelper
    {
        /// <summary>
        /// Calls appropriate method based on CalculationTypes.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="calculation"></param>
        /// <param name="error"></param>
        /// <returns>Outcome of calculation. 0 if an error is thrown.</returns>
        public static decimal Calculate(decimal a, decimal b, CalculationTypes calculation, out string error)
        {
            error = "";

            switch (calculation)
            {
                case CalculationTypes.Multiply:
                    return Multiply(a, b, out error);
                case CalculationTypes.Divide:
                    return Divide(a, b, out error);
                case CalculationTypes.Plus:
                    return Plus(a, b, out error);
                case CalculationTypes.Minus:
                    return Minus(a, b, out error);
                default:
                    break;
            }
            return 0;
        }

        /// <summary>
        /// a * b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        private static decimal Multiply(decimal a, decimal b, out string error)
        {
            try
            {
                error = "";
                return a * b;
            }
            catch (Exception ex)
            {
                error = BeautifyError(ex);
                return 0;
            }
        }

        /// <summary>
        /// a / b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        private static decimal Divide(decimal a, decimal b, out string error)
        {
            try
            {
                error = "";
                return a / b;
            }
            catch (Exception ex)
            {
                error = BeautifyError(ex);
                return 0;
            }
        }

        /// <summary>
        /// a + b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        private static decimal Plus(decimal a, decimal b, out string error)
        {
            try
            {
                error = "";
                return a + b;
            }
            catch (Exception ex)
            {
                error = BeautifyError(ex);
                return 0;
            }
        }

        /// <summary>
        /// a - b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        private static decimal Minus(decimal a, decimal b, out string error)
        {
            try
            {
                error = "";
                return a - b;
            }
            catch (Exception ex)
            {
                error = BeautifyError(ex);
                return 0;
            }
        }
        /// <summary>
        /// Removes callstack and only returns base error. I.e. 'Cannot divide by zero'
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        private static string BeautifyError(Exception ex)
        {
            return ex.Message;
        }
    }
}
