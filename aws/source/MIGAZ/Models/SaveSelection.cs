// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace MIGAZ.Models
{
    public class SaveSelection
    {
        public string AWSRegion;
        public List<string> VirtualNetworks;
        public List<SaveSelectioVirtualMachine> VirtualMachines;
    }

    public class SaveSelectioVirtualMachine
    {
        public string InstanceId;
        public string InstanceName;
    }
}

