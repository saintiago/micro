﻿using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;
using Circuit;

namespace Circuit
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Consonants counter process started");
            ConsonantsSubscriber consonantTransport = new ConsonantsSubscriber();
            Console.ReadLine();
        }
    }
}
