﻿// Copyright (c) 2012-2018 Vaughn Vernon. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using System;
using Vlingo.Common;

namespace Vlingo.Actors
{
    // TODO: implement as a thread
    public interface IMailbox : IRunnable
    {
        void Close();
        bool IsClosed { get; }
        bool IsDelivering { get; }
        bool Delivering(bool flag);
        void Send(IMessage message);
        void Send<T>(Actor actor, Action<T> consumer, ICompletes completes, string representation);
        IMessage Receive();
        bool IsPreallocated { get; }
        int PendingMessages { get; }
    }
}