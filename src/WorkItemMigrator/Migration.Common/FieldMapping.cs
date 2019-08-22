using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Migration.Common
{
    [Serializable]
    public class FieldMapping<TRevision> : Dictionary<string, FieldMapper<TRevision>> where TRevision : ISourceRevision
    {
        public FieldMapping()
        {

        }

        public void AddOrMerge(String key, FieldMapper<TRevision> mapper) {
            if (ContainsKey(key)) {
                mapper = r => {
                    var result = this[key](r);
                    return result.IsMappedValue ? result : mapper(r);
                };
            }
            Add(key, mapper);
        }

        protected FieldMapping(SerializationInfo serializationInfo, StreamingContext streamingContext) : base (serializationInfo, streamingContext)
        {

        }
    } 
}