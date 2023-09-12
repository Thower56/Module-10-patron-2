namespace Module_10___Patron_de_conception_02
{
    public class FactureModelEvent
    {
        public FactureModelEvent() {; }
        public FactureModelEventType Type { get; set; }
        public LigneFactureModel LigneFactureModel { get; set; }
        public FactureModel FactureModel { get; set; }
    }
}
 