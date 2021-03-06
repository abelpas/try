﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.DotNet.Interactive.Commands
{
    public class SubmitCode : KernelCommandBase
    {
        public SubmitCode(
            string code,
            string targetKernelName = null,
            SubmissionType submissionType = SubmissionType.Run)
        {
            Code = code ?? throw new ArgumentNullException(nameof(code));
            TargetKernelName = targetKernelName;
            SubmissionType = submissionType;
        }

        public string Code { get; }

        public string TargetKernelName { get; }

        public SubmissionType SubmissionType { get; }

        public override string ToString() => $"{nameof(SubmitCode)}: {Code.TruncateForDisplay()}";
    }
}