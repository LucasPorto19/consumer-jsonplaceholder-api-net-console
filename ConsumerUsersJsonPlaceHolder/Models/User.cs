namespace ConsumerUsersJsonPlaceHolder.Models;

public sealed record User(
    int id,
    string? name,
    string? username,
    string? email,
    Address? address,
    string? phone,
    string? website,
    Company? company
);
