﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;

namespace OtripleS.Web.Api.Models.TeacherAttachments.Exceptions
{
    public class NotFoundTeacherAttachmentException : Exception
    {
        public NotFoundTeacherAttachmentException(Guid teacherId, Guid attachmentId)
           : base(message: $"Couldn't find teacher attachment with teacher id: {teacherId} " +
                  $"and attachment id: {attachmentId}.")
        { }
    }
}
