﻿namespace MSILGenerator.Resources
{
    static class ResourceFileRouter
    {
        private static readonly string RESOURCE_DIRECTORY = "..\\..\\..\\MSILGenerator\\Resources\\MSILResource";

        public static readonly string INITIALIZE_ROUTE = $"{RESOURCE_DIRECTORY}\\Initialize.txt";
        public static readonly string ADD_OPERATION_ROUTE = $"{RESOURCE_DIRECTORY}\\AddOperation.txt";
        public static readonly string SUBTRACTION_OPERATION_ROUTE = $"{RESOURCE_DIRECTORY}\\SubstractionOperation.txt";
        public static readonly string WRITE_LINE_FUNCTION_ROUTE = $"{RESOURCE_DIRECTORY}\\WriteLine.txt";
        public static readonly string MAIN_FUNCTION_ROUTE = $"{RESOURCE_DIRECTORY}\\MainFunction.txt";
        public static readonly string STACK_CAPACITY_ROUTE = $"{RESOURCE_DIRECTORY}\\StackCapacity.txt";
    }
}
