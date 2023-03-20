using System;
using System.Collections.Generic;

namespace AvaloniaApplication7.Data;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Roleid { get; set; }

    public virtual Role Role { get; set; } = null!;
}
