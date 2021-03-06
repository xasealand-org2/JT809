﻿using JT809.Protocol.JT809Extensions;
using JT809.Protocol.JT809MessageBody;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace JT809.Protocol.JT809Formatters.JT809MessageBodyFormatters
{
    public class JT809_0x1008Formatter : IJT809Formatter<JT809_0x1008>
    {
        public JT809_0x1008 Deserialize(ReadOnlySpan<byte> bytes, out int readSize)
        {
            int offset = 0;
            JT809_0x1008 jT809_0X1008 = new JT809_0x1008();
            jT809_0X1008.ReasonCode =  (JT809Enums.JT809_0x1008_ReasonCode)JT809BinaryExtensions.ReadByteLittle(bytes, ref offset);
            readSize = offset;
            return jT809_0X1008;
        }

        public int Serialize(ref byte[] bytes, int offset, JT809_0x1008 value)
        {
            offset += JT809BinaryExtensions.WriteByteLittle(bytes, offset, (byte)value.ReasonCode);
            return offset;
        }
    }
}
