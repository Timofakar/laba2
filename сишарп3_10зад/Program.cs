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
    lobo:
        try
        {// Controlled code

            // Attempt to convert text to number:


            a = Interaction.InputBox(

            // Text above the input field:

            "Please enter a valid number:",

            // Window title:

            "Number");
            sum += var;
            var = Int32.Parse(a);


            if ((var % 5 == 2) & (var % 3 == 1)) goto lobo;


            txt = "Сумма равна " + sum;


            MessageBox.Show(txt, "Рeзультат");


        }
        catch
        {

            // Отображение сообщения:

            MessageBox.Show(

            // Текст сообщения:

            "Надо было ввести число!",

            // Заголовок окна:

            "Ошибка",
            // В окне одна кнопка OK:

            MessageBoxButtons.OK,

            // Используется пиктограмма ошибки:

            MessageBoxIcon.Error);



        }// Завершение блока обработки исключений
       
        
            // Сообщение о завершении выполнения программы:

            MessageBox.Show("Программа завершена!", "Завершение");


        }
} 

