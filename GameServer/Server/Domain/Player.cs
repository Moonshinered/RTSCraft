namespace GameServer.Server.Domain;

/// <summary>
/// �������� ������ ������: ������������ � ������� ��������.
/// ������� ������������ ������, ������� ������ �� ������.
/// </summary>
public sealed class Player
{
    /// <summary>��������� ������������� (����� IdGen).</summary>
    public long Id { get; init; }

    /// <summary>��� �� ��������� join.</summary>
    public string Name { get; init; } = "";

    /// <summary>��������� ���� �� ��������� join (��� ������, �������� "#22aa66").</summary>
    public string Color { get; init; } = "";

    // ���� � ������������� ���� �� �������. ���� �� �������.
    // public int Gold { get; set; } = 0;
    // public int Wood { get; set; } = 0;
    // public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    // public DateTimeOffset LastSeenAt { get; set; } = DateTimeOffset.UtcNow;
}
