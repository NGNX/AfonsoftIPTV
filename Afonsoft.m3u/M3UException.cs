﻿using System;

namespace Afonsoft.m3u
{
    public class M3UException : Exception
    {
        public M3UException()
        {
        }

        public M3UException(string message) : base(message)
        {
        }

        public M3UException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}