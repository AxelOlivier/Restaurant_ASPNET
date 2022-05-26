namespace RestoApi.models
{
    public class Commande
    {
        public int Id { get; }
        public Table Table { get; }
        public Alimentaire Entrees { get; }
        public List<Alimentaire> Plats { get; }
        public Alimentaire Desserts { get; }
        public Alimentaire? Boissons { get; }

    }
}
