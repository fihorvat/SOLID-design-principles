﻿using System;

namespace Single_responsibility_principle
{
    internal static class StandardMessages
    {
        public static void SayWelcomeMessage()
        {
            Console.WriteLine("Welcome to my application !");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"Invalid {fieldName} name");
        }
    }
}