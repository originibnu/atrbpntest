using System;
using System.Collections.Generic;

namespace TestAtrBpnBackend.Models;

public partial class LokasiPesertum
{
    public int Id { get; set; }

    public string? Ownername { get; set; }

    public string? Placename { get; set; }

    public string? Address { get; set; }

    public string? Placestype { get; set; }

    public DateOnly? Date { get; set; }
}
