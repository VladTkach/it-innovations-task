﻿namespace Library.BLL.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(string type) : base($"{type} was not found")
    {
    }
}