﻿namespace BuildingBlocks.Messaging.MassTransit;

public record MessageBrokerSettings
{
    public string Host { get; set; } = default!;
    public string Username { get; set; } = default!;
    public string Password { get; set; } = default!;
}
