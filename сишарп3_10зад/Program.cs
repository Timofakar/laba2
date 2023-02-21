using System;

using System.Windows.Forms;

using Microsoft.VisualBasic;

class TryCatchDemo
{

    static void Main()
    {

        // Message about the beginning of the program execution:

        MessageBox.Show("The program is running!", "Starting"); // Catching and handling exceptions:
        string a, txt;
        int var = 0, sum = 0;
        do
        {
            try
            {// Controlled code

                a = Interaction.InputBox("Please enter a valid number:","Number");
                sum += var;
                var = Int32.Parse(a);
           }
            catch
            {
                // Отображение сообщения:

                MessageBox.Show(      "Надо было ввести число!",  "Ошибка",  MessageBoxButtons.OK,   MessageBoxIcon.Error);



            }// Завершение блока обработки исключений
        } while ((var % 5 == 2) & (var % 3 == 1));

            txt = "Сумма равна " + sum;


        MessageBox.Show(txt, "Рeзультат");

        // Сообщение о завершении выполнения программы:

        MessageBox.Show("Программа завершена!", "Завершение");


        }
} 

