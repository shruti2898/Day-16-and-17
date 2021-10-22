using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class P11_TaskDoneByMaximumAmount
    {
        public void tasks()
        {
            Console.Write("Number of Tasks:   ");
            int T = Convert.ToInt32(Console.ReadLine());

            List<List<int>> taskList = new List<List<int>>();

            for (int i = 0; i < T; i++)
            {
                int M, D;
                List<int> inputs = new List<int>();
                Console.Write("\nTask-{0}\nDeadline:  ", i + 1);
                D = Convert.ToInt32(Console.ReadLine());
                inputs.Add(D);

                Console.Write("Time Taken: ");
                M = Convert.ToInt32(Console.ReadLine());
                inputs.Add(M);

                taskList.Add(inputs);
            }
            Console.WriteLine("\n\n");
          
            List<List<int>> result = TaskDone(taskList);
            for(int i =0; i<result.Count;i++)
            {
                Console.WriteLine("Task -{0} overshoots its deadline {1} by {2}\n",i+1,result[i][0], result[i][2]);
            }
        }

        List<List<int>> TaskDone(List<List<int>> taskList)
        {

            int first = 0;
            int sum = 0;
            bool[] time = new bool[1000000];
            for (int i = 0; i < taskList.Count; i++)
            {
                int deadline = taskList[i][0];
                int minutes = taskList[i][1];
              
                for (int j = deadline - 1; j >= first && minutes > 0; j--)
                {
                    if (!time[j])
                    {
                        time[j] = true;
                        minutes--;
                    }
                }

                sum = sum + minutes;
                taskList[i].Add(sum);

                for (int k = first; k < 1000000; k++)
                {
                    if (time[k] == false)
                    {
                        first = k;
                        break;
                    }
                }
            }
            return taskList;
        }
    }

}

