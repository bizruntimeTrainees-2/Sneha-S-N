class Example4
{
	public static void Main(string[] args)
	{
		int[] scores = new int[] { 97, 92, 81, 60};

		IEnumerable<int> scoreQuery = 
		from score in scores
		where score > 80
		select score;

		foreach(int i in scoreQuery)
		{
			Console.Write(i + " ");
		}

		}
	}
}

/*
    IEnumerable<int> scoreQuery = 
	from score in scores
	where score > 80
	select score;

    IEnumerable<int> highScoresQuery =
    from score in scores
    where score > 80
    orderby score descending
    select score;

    IEnumerable<string> highScoresQuery2 =
    from score in scores
    where score > 80
    orderby score descending
    select $"The score is {score}";

	int highScoreCount =
    (from score in scores
    where score > 80
    select score)
    .Count();

	IEnumerable<int> highScoresQuery3 =
    from score in scores
    where score > 80
    select score;
    int scoreCount = highScoresQuery3.Count();
*/