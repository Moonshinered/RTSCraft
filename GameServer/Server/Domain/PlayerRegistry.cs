using System.Collections.Concurrent;

namespace GameServer.Server.Domain;

/// <summary>
/// ���������������� ��������� �������.
/// ���� �������� ������ ��� "��� ������ � ����".
/// </summary>
public sealed class PlayerRegistry
{
    private readonly ConcurrentDictionary<long, Player> _players = new();

    /// <summary>�������� ������. ���������� false, ���� id ��� �����.</summary>
    public bool Add(Player p) => _players.TryAdd(p.Id, p);

    /// <summary>������� ������ �� id. true, ���� ��� �����.</summary>
    public bool Remove(long id) => _players.TryRemove(id, out _);

    /// <summary>����������� �������� ������.</summary>
    public bool TryGet(long id, out Player player) => _players.TryGetValue(id, out player!);

    /// <summary>������� ���������� �������.</summary>
    public int Count => _players.Count;

    /// <summary>
    /// ������ (�����) �������� ������ ������� ��� ���������� ��������/������������.
    /// �� "�����" �������, ��������� ����� ������ ���� �� ��������.
    /// </summary>
    public IReadOnlyDictionary<long, Player> Snapshot()
        => new Dictionary<long, Player>(_players);
}
