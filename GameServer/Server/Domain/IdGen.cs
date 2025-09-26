namespace GameServer.Server.Domain;

/// <summary>
/// ���������������� ��������� �������� ���������������.
/// ���������� ������������ ������������������: 1, 2, 3, ...
/// </summary>
public sealed class IdGen
{
    private long _id = 0;

    /// <summary>
    /// �������� ����������� ������� � ���������� ����� ��������.
    /// Interlocked ����������� ������������ ��� ������������� ������� �� ������ �������.
    /// </summary>
    public long Next() => Interlocked.Increment(ref _id);
}
