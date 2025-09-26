using System.Net.WebSockets;

namespace GameServer.Server.Protocol;

public interface IMessageSerializer
{
    object Deserialize(string json);
    Task SendAsync(WebSocket socket, object payload, CancellationToken ct);

    // �����: ��������� �� ������ ���� ����������-���������.
    // ����������:
    //  - DTO (PingMsg/JoinMsg/...) � ���� ������ ��������� JSON,
    //  - null � ���� ������� Close,
    //  - MsgBase ��� type � ���� ���� �������� ��������� (�� ��� ����������).
    Task<object?> ReceiveAsync(WebSocket socket, byte[] buffer, CancellationToken ct);
}

