using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    static class TestInput
    {
        public static int TestInt32(string input)
        {

            if (input.Length == 0)
            {
                MessageBox.Show("Строка не содержит число!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            try
            {
                int number = Int32.Parse(input);
                return number;
            }
            catch (FormatException)
            {
                MessageBox.Show("Невозможно преобразовать строку в число: неверный формат", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ошибка переполнения", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
    }
}
