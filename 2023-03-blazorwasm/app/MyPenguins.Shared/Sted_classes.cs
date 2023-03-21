namespace MyPenguins.Shared
{
#pragma warning disable CS8618
    public class Metadata
    {
        public int treffPerSide { get; set; }
        public int side { get; set; }
        public int totaltAntallTreff { get; set; }
        public int viserFra { get; set; }
        public int viserTil { get; set; }
        public string sokeStreng { get; set; }
    }

    public class Navn
    {
        public List<Stedsnavn> stedsnavn { get; set; }
        public string navneobjekttype { get; set; }
        public int stedsnummer { get; set; }
        public string stedstatus { get; set; }
        public Representasjonspunkt representasjonspunkt { get; set; }
        public int meterFraPunkt { get; set; }
    }

    public class Representasjonspunkt
    {
        public double øst { get; set; }
        public double nord { get; set; }
        public int koordsys { get; set; }
    }

    public class Sted
    {
        public Metadata metadata { get; set; }
        public List<Navn> navn { get; set; }
    }

    public class Stedsnavn
    {
        public string skrivemåte { get; set; }
        public string skrivemåtestatus { get; set; }
        public string navnestatus { get; set; }
        public string språk { get; set; }
        public int stedsnavnnummer { get; set; }
    }

#pragma warning restore CS8618
}
