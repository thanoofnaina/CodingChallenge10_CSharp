int n = 10;
List<string?> boardingPass = new List<string?>();

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter the boarding pass of passenger {i + 1}");
    boardingPass.Add(Console.ReadLine());
}

Queue<string?> Queue1 = new Queue<string?>();
Queue<string?> Queue2 = new Queue<string?>();
Queue<string?> Queue3 = new Queue<string?>();

for (int k = 0; k <= n; k++  )
{
    for (int j = 0; j < 3 && n>0 ; ++j)
    {
        if (Queue1.Count <= j)
        {
            Queue1.Enqueue(boardingPass[0]);
            Console.WriteLine($"Boarding pass {boardingPass[0]} : Counter 1");
            boardingPass.RemoveAt(0);
            n--;

            Queue2.Enqueue(boardingPass[0]);
            Console.WriteLine($"Boarding pass {boardingPass[0]} : Counter 2");
            boardingPass.RemoveAt(0);
            n--;

            Queue3.Enqueue(boardingPass[0]);
            Console.WriteLine($"Boarding pass {boardingPass[0]} : Counter 3");
            boardingPass.RemoveAt(0);
            n--;
        }
        else
        {
            Console.Write("Enter the counter number, if free space is available (1 , 2 or 3): ");
            var space = Console.ReadLine();

            if (space == "1")
            {
                Queue1.Dequeue();
                Queue1.Enqueue(boardingPass[0]);
                Console.WriteLine($"Boarding pass {boardingPass[0]} : Counter 1");
                boardingPass.RemoveAt(0);
                n--;
            }
            else if (space == "2")
            {
                Queue2.Dequeue();
                Queue2.Enqueue(boardingPass[0]);
                Console.WriteLine($"Boarding pass {boardingPass[0]} : Counter 2");
                boardingPass.RemoveAt(0);
                n--;
            }
            else if (space == "3")
            {
                Queue3.Dequeue();
                Queue3.Enqueue(boardingPass[0]);
                Console.WriteLine($"Boarding pass {boardingPass[0]} : Counter 3");
                boardingPass.RemoveAt(0);
                n--;
            }
        }
    }
}


