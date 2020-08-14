using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public class GætEtTal
    {
        public static Task GætTal(bool startGame)
        {
            Task task = new Task(() =>
            {
                int miliSeconds = 10000;
                int numberOfRepeats = 100;
                int newtest = 10;
                while (startGame)
                {
                    for (int i = 0; i < numberOfRepeats; i++)
                    {
                        Task.Delay(miliSeconds).Wait();
                        Console.WriteLine(newtest - 1);

                        if (newtest < 0)
                        {
                            startGame = false;
                        }
                    }
                }
            });
            task.Start();
            return task;
        }
    }
}
