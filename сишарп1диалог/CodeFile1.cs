using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
class Enteringinteger
{
    static void Main()
    {
        // Текстовые переменные:
        string res, txt, gas;
        // Целочисленные переменные:
        int sum, notsum, born,gorn;
        // Отображение окна с полем ввода:
        res = Interaction.InputBox("Первое число");
        gas= Interaction.InputBox("Второе число");
        // Преобразование текста в число:
        born = Int32.Parse(res);
        gorn = Int32.Parse(gas);
        notsum =   born-gorn;
        sum = born + gorn;
        txt = "Сумма = " + sum + "\n А разность = "+notsum;
        // Окно с сообщением:
        MessageBox.Show(txt, "Результат");
    }
}