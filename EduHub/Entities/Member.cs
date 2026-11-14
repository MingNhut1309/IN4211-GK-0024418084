namespace EduHub.Domain.Entities;

public class Member : Entity
{
    public string Email { get; private set; }

    private Member(Guid id, string email)
    {
        Id = id;
        Email = email;
    }

    public static Member Create(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email không được để trống.", nameof(email));

        if (!email.Contains('@'))
            throw new ArgumentException("Email phải chứa ký tự '@'.", nameof(email));

        return new Member(Guid.NewGuid(), email);
    }

    public static Member Create(Guid id, string email)
    {
        if (id == Guid.Empty)
            throw new ArgumentException("Id không được để trống.", nameof(id));

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email không được để trống.", nameof(email));

        if (!email.Contains('@'))
            throw new ArgumentException("Email phải chứa ký tự '@'.", nameof(email));

        return new Member(id, email);
    }
}
