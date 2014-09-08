
namespace ConsoleApplication
{
    using System;
    using Library;

    class Program
    {
        static void Main(string[] args)
        {
            var g = new GraphContainer()
                        .AddGraph<int>()
                        .AddRoot(1)
                            .AddEdge<string>("1-2")
                            .AddEdge<string>("11-22")   // add multiple edges
                                .ToVertex<short>(2)
                                    .AddEdge<string>("2-4")
                                        .ToVertex<byte>(4)
                                            .AddEdge<string>("4-6")
                                                .ToVertex<int>(6)
                                                    .AddEdge<string>("6-7")
                                                        .ToVertex<int>(7)
                                        .AddEdge<string>("7-4")
                                        .ToVertex<int>(4)
                                                        .AtVertex<int>(7)
                                                            .AddEdge<string>("7-9")
                                                                .ToVertex<int>(9)
                                                .AtVertex<int>(6)
                                                    .AddEdge<string>("6-8")
                                                        .ToVertex<int>(8)
                        .AtVertex<int>(1)
                            .AddEdge<string>("1-3")
                                .ToVertex<int>(3)
                                    .AddEdge<string>("3-5")
                                        .ToVertex<int>(5)
                                            .AddEdge<string>("5-10")
                                                .ToVertex<int>(10)
                                                    .AddEdge<string>("10-4")
                                                        .ToVertex<int>(11)
                                                .AtVertex<int>(10)
                                                    .AddEdge<string>("10-12")
                                                        .ToVertex<int>(12)
                                                            .AddEdge<string>("12-13")
                                                                .ToVertex<int>(13)
                                                        .AtVertex<int>(12)
                                                            .AddEdge<string>("12-14")
                                                                .ToVertex<int>(14)
                                                        .AtVertex<int>(8)
                                                            .AddEdge<string>("8-15")
                                                                .ToVertex<int>(15)
                                                                    .AddEdge<string>("15-5")
                                                                        .ToVertex<int>(5)
                        ;
            g.Print();

            Console.ReadLine();
        }
    }
}
