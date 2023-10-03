using System;
using System.Collections.Generic;

namespace CRUD.Models;

public partial class Comic
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Edision { get; set; }
}
