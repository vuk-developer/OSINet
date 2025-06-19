using System;
using System.Collections.Generic;

namespace OSI.Models;

public partial class Clanovi
{
    public string Id { get; set; }

    public string? Ime { get; set; }

    public string? Prezime { get; set; }

    public string? Mesto { get; set; }

    public DateTime? DatumRodjenja { get; set; }

    public string? Evidencija { get; set; }


}
