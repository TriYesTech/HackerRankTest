        // Complete the minimumBribes function below.
        static void minimumBribes(int[] q)
        {
            int bribeCount = 0;
            bool chaos = false;
            bool finished = false;
            int[] bribeCounter = new int[q.Length + 1];

            while (!finished)
            {
                finished = true;

                for (int i = 0; i < q.Length - 1; i++)
                {
                    if (q[i] > q[i + 1])
                    {
                        bribeCounter[q[i]]++;

                        if (bribeCounter[q[i]] > 2)
                        {
                            finished = true;
                            chaos = true;
                            break;
                        }

                        bribeCount++;
                        int temp = q[i];
                        q[i] = q[i + 1];
                        q[i + 1] = temp;
                        finished = false;
                    }

                }
            }

            if (chaos)
                System.Console.Out.WriteLine("Too chaotic");
            else
                System.Console.Out.WriteLine(bribeCount.ToString());
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));

                minimumBribes(q);

            }
        }
