﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using Xeptions;

namespace OtripleS.Web.Api.Models.Attendances.Exceptions
{
    public class InvalidAttendanceException : Xeption
    {
        public InvalidAttendanceException(string parameterName, object parameterValue)
            : base($"Invalid Attendace, " +
                  $"ParameterName: {parameterName}, " +
                  $"ParameterValue: {parameterValue}.")
        { }

        public InvalidAttendanceException()
            : base("Invalid attendance. Please fix the errors and try again.") { }
    }
}
