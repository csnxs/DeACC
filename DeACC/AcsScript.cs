﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csnxs.DeACC
{
    enum ScriptType
    {
        Closed,
        Open,
        Respawn,
        Death,
        Enter,
        Pickup,
        BlueReturn,
        RedReturn,
        WhiteReturn,

        Lightning = 12,
        Unloading,
        Disconnect,
        Return
    }

    enum ScriptFlags
    {
        Net = 1 << 0,
        Clientside = 1 << 1
    }

    class AcsScript
    {
        public int Number { get; private set; }
        public string Name { get; set; }
        public ScriptType Type { get; private set; }
        public int NumberOfArguments { get; private set; }

        public AcsInstruction[] Code;

        public int Flags;

        public int Pointer { get; set; }
        public int CodeSize;

        public AcsScript(int number, ScriptType type, int argc, int ptr)
        {
            Number = number;
            Type = type;
            NumberOfArguments = argc;
            Pointer = ptr;
        }
    }
}
