namespace HackerRankProblems.GeneralProblems
{
    internal class TwoBestEvents
    {
        //public static void Main(string[] args)
        //{
        //    // Declare and initialize a jagged array
        //    int[][] events = {
        //    new int[] { 1, 3, 2 },
        //    new int[] { 4, 5, 2 },
        //    new int[] { 1, 5, 5 }
        //};

        //    Console.WriteLine(MaxTwoEvents(events));
        //}
        public static int MaxTwoEvents(int[][] events)
        {
            var set = new Dictionary<int, int>();
            int maxTime = 1, maxEndTime = Int32.MinValue;
            for (int i = 0; i < events.Length; i++)
            {
                if (events[i][1] > maxEndTime) maxEndTime = events[i][1];
                int startTime = events[i][0];
                if (!set.ContainsKey(startTime))
                {
                    set.Add(startTime, i);
                }
                else
                {
                    int value = set[startTime];
                    //endtime less and value high
                    if (events[i][2] > events[value][2])
                    {
                        set[startTime] = i;
                    }
                }
            }
            Console.WriteLine(maxEndTime);
            int time = 1;
            int process = 1;
            int result = 0;
            int sTime = 0, eTime = 0;
            while (time <= maxEndTime)
            {
                if (time >= sTime && time > eTime && set.ContainsKey(time))
                {
                    result += events[set[time]][2];

                    sTime = events[set[time]][0];
                    eTime = events[set[time]][1];
                }
                time++;
            }

            return result;

        }
    }
}
