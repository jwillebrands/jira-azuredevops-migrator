namespace Migration.Common {
    public class MapResult {
        public bool HasSourceValue {get; private set;}
        public bool IsMappedValue {get; private set;}
        public object Value {get; private set;}

        public MapResult(bool hasSourceValue, bool isMappedValue, object value)
        {
            HasSourceValue = hasSourceValue;
            IsMappedValue = isMappedValue;
            Value = value;
        }
    }
}
