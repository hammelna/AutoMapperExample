using AutoMapper;
using Domain;
using System;

namespace WithoutDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Program");
            var config = new MapperConfiguration(cfg => cfg.AddProfile<MapperProfile>());
            var mapper = config.CreateMapper();
            Console.WriteLine("Stopping Program");
        }
    }
}
