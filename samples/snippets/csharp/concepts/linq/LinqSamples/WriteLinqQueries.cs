﻿namespace LinqSamples;

public static class WriteLinqQueries
{
    static readonly List<int> numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];
    static readonly List<int> numbers1 = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];
    static readonly List<int> numbers2 = [15, 14, 11, 13, 19, 18, 16, 17, 12, 10];

    public static void WriteLinqQueries1()
    {
        // <write_linq_queries_1>
        List<int> numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];

        // The query variables can also be implicitly typed by using var

        // Query #1.
        IEnumerable<int> filteringQuery =
            from num in numbers
            where num is < 3 or > 7
            select num;

        // Query #2.
        IEnumerable<int> orderingQuery =
            from num in numbers
            where num is < 3 or > 7
            orderby num ascending
            select num;

        // Query #3.
        string[] groupingQuery = ["carrots", "cabbage", "broccoli", "beans", "barley"];
        IEnumerable<IGrouping<char, string>> queryFoodGroups =
            from item in groupingQuery
            group item by item[0];
        // </write_linq_queries_1>
    }

    public static void WriteLinqQueries2()
    {
        // <write_linq_queries_2>
        List<int> numbers1 = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];
        List<int> numbers2 = [15, 14, 11, 13, 19, 18, 16, 17, 12, 10];

        // Query #4.
        double average = numbers1.Average();

        // Query #5.
        IEnumerable<int> concatenationQuery = numbers1.Concat(numbers2);
        // </write_linq_queries_2>
    }

    public static void WriteLinqQueries3()
    {
        // <write_linq_queries_3>
        // Query #6.
        IEnumerable<int> largeNumbersQuery = numbers2.Where(c => c > 15);
        // </write_linq_queries_3>
    }

    public static void WriteLinqQueries4()
    {
        // <write_linq_queries_4>
        // var is used for convenience in these queries
        double average = numbers1.Average();
        var concatenationQuery = numbers1.Concat(numbers2);
        var largeNumbersQuery = numbers2.Where(c => c > 15);
        // </write_linq_queries_4>
    }

    public static void WriteLinqQueries5()
    {
        // <write_linq_queries_5>
        // Query #7.

        // Using a query expression with method syntax
        var numCount1 = (
            from num in numbers1
            where num is < 3 or > 7
            select num
        ).Count();

        // Better: Create a new variable to store
        // the method call result
        IEnumerable<int> numbersQuery =
            from num in numbers1
            where num is < 3 or > 7
            select num;

        var numCount2 = numbersQuery.Count();
        // </write_linq_queries_5>
    }

    public static void WriteLinqQueries5a()
    {
        // <write_linq_queries_5a>
        var numCount = numbers.Count(n => n is < 3 or > 7);
        // </write_linq_queries_5a>
    }

    public static void WriteLinqQueries5b()
    {
        // <write_linq_queries_5b>
        var numCount = numbers.Count(n => n is < 3 or > 7);
        // </write_linq_queries_5b>
    }
}
