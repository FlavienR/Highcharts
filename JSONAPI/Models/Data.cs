namespace JSONAPI.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Data
    {
        [DataMemberAttribute]
        public string name { get; set; }

        [DataMemberAttribute]
        public double y { get; set; }

        public Data(string name, double y)
        {
            this.name = name;
            this.y = y;
        }
    }
}