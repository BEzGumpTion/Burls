﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burls.Application.Core.Commands
{
    public class ApplicationInitializeCommand : IRequest
    {
        public string[] StartUpArgs { get; }

        public ApplicationInitializeCommand(string[] startUpArgs)
        {
            StartUpArgs = startUpArgs;
        }
    }
}