using System;
using System.Runtime.Serialization;

namespace ProgramForReadNr
{
    [Serializable]
    public class DuplicateNumberException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public DuplicateNumberException()
        {
        }

        public DuplicateNumberException(string message) : base(message)
        {
        }

        public DuplicateNumberException(string message, Exception inner) : base(message, inner)
        {
        }

        protected DuplicateNumberException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}