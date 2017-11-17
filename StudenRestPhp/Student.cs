using System.Runtime.Serialization;

namespace StudenRestPhp
{
    [DataContract]
    public class Student
    {    
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Start { get; set; }

        [DataMember]
        public string School { get; set; }
    }
}