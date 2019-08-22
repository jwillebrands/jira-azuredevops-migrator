using System;

namespace Migration.Common {
    public delegate MapResult FieldMapper<in T>(T revision) where T: ISourceRevision;
}