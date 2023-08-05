﻿/*
   Copyright 2018 Lip Wee Yeo Amano

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using System.Runtime.InteropServices;

namespace SoliditySHA3Miner.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Processor
    {
        public int Affinity;
        public ulong WorkSize;
        public ulong WorkPosition;

        public uint MaxSolutionCount;
        public uint SolutionCount;
        public IntPtr Solutions;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DeviceCPU
    {
        public int ProcessorCount;
        public IntPtr Processors;

        public IntPtr SolutionTemplate;
        public IntPtr Message;
        public IntPtr MidState;

        public IntPtr Target;
        public IntPtr High64Target;
    }
}