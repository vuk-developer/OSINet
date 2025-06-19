using System;
using System.Collections.Generic;

namespace OSI.Models;

public partial class Knjige
{
    public int? Id { get; set; }

    public string? Isbn { get; set; }

    public string? ImeKnjige { get; set; }

    public string? Autor { get; set; }

    public string? Status { get; set; }

    public string? Signatura { get; set; }

    public DateTime? DatumUnosa { get; set; }
}
