﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Npgsql.Messages;

namespace Npgsql.TypeHandlers
{
    internal class DecimalHandler : SimpleTypeHandler
    {
        static readonly string[] _pgNames = { "decimal", "numeric" };
        internal override string[] PgNames { get { return _pgNames; } }
        internal override Type FieldType { get { return typeof(decimal); } }

        internal override void ReadText(NpgsqlBufferedStream buf, int len, FieldDescription field, NpgsqlValue output)
        {
            output.SetTo(Decimal.Parse(buf.ReadString(len)));
        }
    }
}