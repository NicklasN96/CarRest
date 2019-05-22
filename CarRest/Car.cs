using System.Runtime.Serialization;

namespace CarRest
{
    [DataContract]
    public class Car
    {
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public int ModelYear { get; set; }
    }
}