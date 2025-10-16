namespace ConsumerUsersJsonPlaceHolder.Models;

public sealed record Address(
    string? street,
    string? suite,
    string? city,
    string? zipcode,
    Geo? geo
);
