//This is the ToDoList Project that allow user to add the Tasks , view the task and mark them as completed
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;
using Pastel;

class ToDoList
{
    private static List<string> Tasks = new List<string>();
    public static void AddTask()
    {
        Console.WriteLine("Please Enter the task: ".Pastel(Color.Red));
        string Task = Console.ReadLine();
        Tasks.Add(Task);
        ViewTask();
    }
    public static void ViewTask()
    {
        for (int i = 0; i < Tasks.Count; i++)
        {
            Console.WriteLine(i + 1 + ":" + Tasks[i]);
        }
    }
    public static void MarkCompleted()
    {
        if (Tasks.Count == 0)
        {
            Console.WriteLine("Please enter the task first: ".Pastel(Color.Red));
        }
        else
        {
            ViewTask();
            Console.WriteLine("Please enter the task number to mark completed: ".Pastel(Color.Green));
            int TaskNumber = Convert.ToInt32(Console.ReadLine());
            if (TaskNumber < 1 || TaskNumber > Tasks.Count)
            {
                Console.WriteLine("Invalid task number".Pastel(Color.Red));
                return;
            }

            Tasks[TaskNumber - 1] += " [Completed]";
            ViewTask();
        }

    }
}

class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please Select: ".Pastel(Color.SkyBlue));
            Console.WriteLine("Please Select 1 to Add the task ".Pastel(Color.Wheat));
            Console.WriteLine("Please Select 2 to View all tasks ".Pastel(Color.Wheat));
            Console.WriteLine("Please Select 3 to Mark the task completed ".Pastel(Color.Wheat));
            Console.WriteLine("Please Select 4 to Exit the program ".Pastel(Color.Red));
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 4)
            {
                break;
            }
            else
            {
                switch (option)
                {
                    case 1:
                        ToDoList.AddTask();
                        break;
                    case 2:
                        ToDoList.ViewTask();
                        break;
                    case 3:
                        ToDoList.MarkCompleted();
                        break;
                    default:
                        Console.WriteLine("Please choose the valid option!".Pastel(Color.Red));
                        break;
                }
            }

        }
    }
}