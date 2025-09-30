namespace GameServer.Server.Protocol;

/// <summary>
/// ������� �������: ������� Unix-����� � ������������� (UTC).
/// ������ ��� ��������� � �����.
/// </summary>
public static class UnixMs
{
    public static long Now() => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
}
