using System;

namespace TShockAPI.Net;

public class NetBuff
{
	public ushort Type { get; }
	public short Duration { get; }

	public NetBuff(ushort type, short duration)
	{
		Type = type;
		Duration = duration;
	}

	public override string ToString() => $"{Type},{Duration}";

	public static NetBuff Parse(string str)
	{
		if (str == null)
			throw new ArgumentNullException(nameof(str));

		var comp = str.Split(',');
		if (comp.Length != 2)
			throw new FormatException("String does not contain two sections.");

		return new NetBuff(ushort.Parse(comp[0]), short.Parse(comp[0]));
	}
}
